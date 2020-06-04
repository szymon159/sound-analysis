using MathNet.Numerics;
using MathNet.Numerics.IntegralTransforms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SoundAnalysis
{
    public static class Calculator
    {
        public static double CalculateFrameLevelParameter(FrameLevelParamType parameter, CustomPoint[] parsedFile, int samplesPerFrame, double sampleRate, out double[] resultInFrames)
        {
            int framesCount = parsedFile.Length / samplesPerFrame;
            if (parsedFile.Length % samplesPerFrame != 0)
                framesCount++;

            switch (parameter)
            {
                case FrameLevelParamType.Volume:
                    return GetVolume(parsedFile, samplesPerFrame, framesCount, out resultInFrames);
                case FrameLevelParamType.ShortTimeEnergy:
                    return GetEnergy(parsedFile, samplesPerFrame, framesCount, out resultInFrames);
                case FrameLevelParamType.ZeroCrossingRate:
                    return GetZeroCrossingRate(parsedFile, samplesPerFrame, framesCount, sampleRate, out resultInFrames);
                case FrameLevelParamType.SilentRatio:
                    return GetSilentRatio(parsedFile, samplesPerFrame, framesCount, sampleRate, out resultInFrames);
                case FrameLevelParamType.SoundlessSpeech:
                    return GetSoundlessSpeech(parsedFile, samplesPerFrame, framesCount, sampleRate, out resultInFrames);
                case FrameLevelParamType.SoundSpeech:
                    return GetSoundSpeech(parsedFile, samplesPerFrame, framesCount, sampleRate, out resultInFrames);
                case FrameLevelParamType.Music:
                    return GetMusic(parsedFile, samplesPerFrame, framesCount, sampleRate, out resultInFrames);
               default:
                    resultInFrames = new double[framesCount];
                    return 0.0;
            }
        }

        public static double CalculateClipLevelParameter(ClipLevelParamType parameter, double[] volume, double[] energy, double[] zeroCrossingRate, CustomPoint[] parsedFile, double sampleRate)
        {
            switch (parameter)
            {
                case ClipLevelParamType.VolumeStandardDeviation:
                    return GetVolumeStandardDeviation(volume);
                case ClipLevelParamType.VolumeDynamicRange:
                    return GetVolumeDynamicRange(volume);
                case ClipLevelParamType.LowShortTimeEnergyRatio:
                    return GetLowShortTimeEnergyRatio(energy, parsedFile, sampleRate);
                case ClipLevelParamType.HighZeroCrossingRateRatio:
                    return GetHighZeroCrossingRateRatio(zeroCrossingRate, parsedFile, sampleRate);
                default:
                    return 0.0;
            }
        }

        #region Frequency Analysis

        public static void CalculateFourierTransform(CustomPoint[] parsedFile, double sampleRate, WindowType selectedWindowType, out CustomPoint[] transformResult, int samplesPerFrame = 1, int? selectedSampleIndex = null)
        {
            // Get the samples for analysis
            var samplesToTransform = new List<CustomPoint>();
            Complex32[] transformData;
            int newSamplesCount;

            if (selectedSampleIndex != null)
            {
                if (selectedSampleIndex.Value + samplesPerFrame >= parsedFile.Length)
                    selectedSampleIndex = parsedFile.Length - samplesPerFrame - 1;

                for (int i = 0; i < samplesPerFrame; i++)
                    samplesToTransform.Add(parsedFile[selectedSampleIndex.Value + i]);

                transformData = GetSamplesForFourier(samplesToTransform, selectedWindowType, out newSamplesCount);
            }
            else
            {
                transformData = GetSamplesForFourier(parsedFile, selectedWindowType, out newSamplesCount);
            }

            // Perform transformation
            transformResult = new CustomPoint[newSamplesCount / 2];
            Fourier.Forward(transformData);

            // Compute frequency and magnitute to return
            var herzPerSample = sampleRate / newSamplesCount;
            for (int i = 0; i < (newSamplesCount / 2); i++)
            {
                transformResult[i].X = i * herzPerSample;
                transformResult[i].Y = Math.Log10(transformData[i].MagnitudeSquared()) + 10;
            }
        }

        public static void CalculateSpectrogram(CustomPoint[] parsedFile, WindowType selectedWindowType, int samplesPerFrame, double frameOverlapping, out double[,] transformResult)
        {
            // Get data for analysis
            var samplesToTransform = GetSamplesForSpectrogram(parsedFile, samplesPerFrame, frameOverlapping, selectedWindowType, out int rowCount, out int columnCount, out _);

            // Perform transformation
            transformResult = new double[columnCount, rowCount / 2];

            for (int i = 0; i < samplesToTransform.Length; i++)
            {
                Fourier.Forward(samplesToTransform[i]);

                // Compute value to return
                for (int j = 0; j < samplesToTransform[i].Length / 2; j++)
                {
                    transformResult[i, j] = 10 * Math.Log10(samplesToTransform[i][j].MagnitudeSquared());
                }

            }
        }

        public static float CalculateFundamentalFrequency(CustomPoint[] parsedFile, WindowType selectedWindowType, double frameOverlapping, int samplesPerFrame, double sampleRate, out CustomPoint[] transformResult)
        {
            // Frequency ranges where we look for peak
            const int minFrequency = 50;
            const int maxFrequency = 400;

            // Ids of first and last frame in each transformed frame (corresponding to min and max frequencies)
            var firstSample = (int)((2 * minFrequency * samplesPerFrame) / sampleRate);
            var lastSample = (int)((2 * maxFrequency * samplesPerFrame) / sampleRate);

            // Samples are same as for spectrogram
            var samplesToTransform = GetSamplesForSpectrogram(parsedFile, samplesPerFrame, frameOverlapping, selectedWindowType, out int rowCount, out int columnCount, out int frameOffset);

            transformResult = new CustomPoint[samplesToTransform.Length];
            for(int i = 0; i < samplesToTransform.Length; i++)
            {
                // First fft
                Fourier.Forward(samplesToTransform[i]);

                // Inverse fft
                var dataForInversedFourier = samplesToTransform[i]
                    .Select(complex => new Complex32((float)Math.Log10(complex.MagnitudeSquared), 0)).ToArray();
                Fourier.Inverse(dataForInversedFourier);

                // Take correct range to look for peak
                var inversedData = dataForInversedFourier.Select(complex => complex.Real).ToArray();
                var dataInRange = new ArraySegment<float>(inversedData, firstSample, lastSample - firstSample).ToList();
                var peakIdx = dataInRange.IndexOf(dataInRange.Max());

                // Adjust offset
                var frequencyInFrame = firstSample + peakIdx;

                // Adjust value
                var herzPerFrame = sampleRate / (2 * samplesPerFrame);
                transformResult[i].X = (i * frameOffset + samplesPerFrame / 2) / sampleRate; 
                transformResult[i].Y = frequencyInFrame * herzPerFrame;
            }

            return (float)transformResult.Max(point => point.Y);
        }

        #endregion

        #region Frequency Parameters

        public static double CalculateFrequencyVolume(CustomPoint[] parsedFile, double sampleRate, WindowType selectedWindowType, int samplesPerFrame, int framesCount, out double[] resultInFrames)
        {
            resultInFrames = new double[framesCount];
            var sampleIndex = 0;
            var average = 0.0;

            // Need to shift all the values so that min value is set to 0 
            CalculateFourierTransform(parsedFile, sampleRate, selectedWindowType, out CustomPoint[] wholeClipTransform);
            var shift = Math.Abs(wholeClipTransform.Min(p => p.Y));

            for (int i = 0; i < framesCount; i++)
            {
                CalculateFourierTransform(parsedFile, sampleRate, selectedWindowType, out CustomPoint[] transformResult, samplesPerFrame, sampleIndex);

                foreach (var spectrumPoint in transformResult)
                {
                    var spectrumValue = spectrumPoint.Y + shift;
                    resultInFrames[i] += spectrumValue * spectrumValue;
                }
                resultInFrames[i] /= transformResult.Length;
                average += resultInFrames[i];

                sampleIndex += samplesPerFrame;
            }

            return average / framesCount;
        }

        public static double CalculateFrequencyCentroid(CustomPoint[] parsedFile, double sampleRate, WindowType selectedWindowType, int samplesPerFrame, int framesCount, out double[] resultInFrames)
        {
            resultInFrames = new double[framesCount];
            var sampleIndex = 0;
            var average = 0.0;

            // Need to shift all the values so that min value is set to 0 
            CalculateFourierTransform(parsedFile, sampleRate, selectedWindowType, out CustomPoint[] wholeClipTransform);
            var shift = Math.Abs(wholeClipTransform.Min(p => p.Y));

            for (int i = 0; i < framesCount; i++)
            {
                CalculateFourierTransform(parsedFile, sampleRate, selectedWindowType, out CustomPoint[] transformResult, samplesPerFrame, sampleIndex);

                double nominator = 0.0;
                double denominator = 0.0;
                foreach (var spectrumPoint in transformResult)
                {
                    var spectrumValue = spectrumPoint.Y + shift;

                    nominator += spectrumPoint.X * spectrumValue;
                    denominator += spectrumValue;
                }
                resultInFrames[i] = nominator / denominator;
                average += resultInFrames[i];

                sampleIndex += samplesPerFrame;
            }

            return average / framesCount;
        }

        public static double CalculateEffectiveBandwith(CustomPoint[] parsedFile, double sampleRate, WindowType selectedWindowType, int samplesPerFrame, int framesCount, double[] frequencyCentroid, out double[] resultInFrames)
        {
            resultInFrames = new double[framesCount];
            var sampleIndex = 0;
            var average = 0.0;

            // Need to shift all the values so that min value is set to 0 
            CalculateFourierTransform(parsedFile, sampleRate, selectedWindowType, out CustomPoint[] wholeClipTransform);
            var shift = Math.Abs(wholeClipTransform.Min(p => p.Y));

            for (int i = 0; i < framesCount; i++)
            {
                CalculateFourierTransform(parsedFile, sampleRate, selectedWindowType, out CustomPoint[] transformResult, samplesPerFrame, sampleIndex);

                double nominator = 0.0;
                double denominator = 0.0;
                foreach (var spectrumPoint in transformResult)
                {
                    var spectrumValue = spectrumPoint.Y + shift;

                    nominator += Math.Pow((spectrumPoint.X - frequencyCentroid[i]) * spectrumValue, 2);
                    denominator += spectrumValue * spectrumValue;
                }
                resultInFrames[i] = Math.Sqrt(nominator / denominator);
                average += resultInFrames[i];

                sampleIndex += samplesPerFrame;
            }

            return average / framesCount;
        }

        #endregion

        #region Time Parameters

        private static double GetVolume(CustomPoint[] parsedFile, int samplesPerFrame, int framesCount, out double[] resultInFrames)
        {
            // Volume is almost the same as energy but the square root should be applied to result in each frame 
            // Call with the parameter takeRoot set to true
            return GetEnergy(parsedFile, samplesPerFrame, framesCount, out resultInFrames, true);
        }

        private static double GetEnergy(CustomPoint[] parsedFile, int samplesPerFrame, int framesCount, out double[] resultInFrames, bool takeRoot = false)
        {
            double avgResult = 0.0f;
            resultInFrames = new double[framesCount];

            for (int i = 0; i < framesCount; i++)
            {
                double squaredSum = 0.0f;
                for (int j = 0; j < samplesPerFrame; j++)
                {
                    int sampleIdx = i * samplesPerFrame + j;
                    if (sampleIdx >= parsedFile.Length)
                        break;

                    // Operations for each sample
                    squaredSum += parsedFile[sampleIdx].Y * parsedFile[sampleIdx].Y;
                    //
                }

                // Operations for each frame
                resultInFrames[i] = squaredSum / samplesPerFrame;
                if (takeRoot)
                    resultInFrames[i] = Math.Sqrt(resultInFrames[i]);
                //

                avgResult += resultInFrames[i];
            }

            avgResult /= framesCount;
            return avgResult;
        }

        private static double GetZeroCrossingRate(CustomPoint[] parsedFile, int samplesPerFrame, int framesCount, double sampleRate, out double[] resultInFrames)
        {
            double avgResult = 0.0f;
            resultInFrames = new double[framesCount];

            for (int i = 0; i < framesCount; i++)
            {
                double squaredSum = 0.0f;
                for (int j = 0; j < samplesPerFrame; j++)
                {
                    int sampleIdx = i * samplesPerFrame + j;
                    if (sampleIdx >= parsedFile.Length)
                        break;

                    // Operations for each sample
                    int signI = Math.Sign(parsedFile[sampleIdx].Y);
                    if (sampleIdx > 0)
                    {
                        sampleIdx--;
                        squaredSum += Math.Abs(signI - Math.Sign(parsedFile[sampleIdx].Y));
                    }
                    else
                    {
                        squaredSum += Math.Abs(signI);
                    }
                    //
                }

                // Operations for each frame
                resultInFrames[i] = squaredSum / (2.0 * samplesPerFrame);
                //

                avgResult += resultInFrames[i];
            }

            avgResult /= framesCount;
            return avgResult;
        }

        private static double GetSilentRatio(CustomPoint[] parsedFile, int samplesPerFrame, int framesCount, double sampleRate, out double[] resultInFrames)
        {
            double avgResult = 0.0f;
            resultInFrames = new double[framesCount];

            GetEnergy(parsedFile, samplesPerFrame, framesCount, out double[] volumeResultInFrame, true);
            GetZeroCrossingRate(parsedFile, samplesPerFrame, framesCount, sampleRate, out double[] zcrResultInFrame);

            for (int i = 0; i < framesCount; i++)
            {
                // Operations for each frame
                if (volumeResultInFrame[i] < 0.005 && zcrResultInFrame[i] < 0.1)
                    resultInFrames[i] = 1;
                //

                avgResult += resultInFrames[i];
            }

            avgResult /= framesCount;
            return avgResult;
        }

        private static double GetSoundlessSpeech(CustomPoint[] parsedFile, int samplesPerFrame, int framesCount, double sampleRate, out double[] resultInFrames)
        {
            double avgResult = 0.0f;
            resultInFrames = new double[framesCount];

            GetEnergy(parsedFile, samplesPerFrame, framesCount, out double[] energyResultInFrame);
            GetZeroCrossingRate(parsedFile, samplesPerFrame, framesCount, sampleRate, out double[] zcrResultInFrame);

            for (int i = 0; i < framesCount; i++)
            {
                // Operations for each frame
                if (energyResultInFrame[i] < 0.001 && zcrResultInFrame[i] < 0.1)
                    resultInFrames[i] = 1;
                //

                avgResult += resultInFrames[i];
            }

            avgResult /= framesCount;
            return avgResult;
        }

        private static double GetSoundSpeech(CustomPoint[] parsedFile, int samplesPerFrame, int framesCount, double sampleRate, out double[] resultInFrames)
        {
            double avgResult = 0.0f;
            resultInFrames = new double[framesCount];

            GetEnergy(parsedFile, samplesPerFrame, framesCount, out double[] energyResultInFrame);
            GetZeroCrossingRate(parsedFile, samplesPerFrame, framesCount, sampleRate, out double[] zcrResultInFrame);

            for (int i = 0; i < framesCount; i++)
            {
                // Operations for each frame
                if (energyResultInFrame[i] > 0.001 && zcrResultInFrame[i] < 0.1)
                    resultInFrames[i] = 1;
                //  

                avgResult += resultInFrames[i];
            }

            avgResult /= framesCount;
            return avgResult;
        }

        private static double GetMusic(CustomPoint[] parsedFile, int samplesPerFrame, int framesCount, double sampleRate, out double[] resultInFrames)
        {
            double avgResult = 0.0f;
            resultInFrames = new double[framesCount];

            GetEnergy(parsedFile, samplesPerFrame, framesCount, out double[] energyResultInFrame);
            GetEnergy(parsedFile, (int)sampleRate, framesCount, out double[] energyInOneSecFrame);
            GetZeroCrossingRate(parsedFile, samplesPerFrame, framesCount, sampleRate, out double[] zcrResultInFrame);

            var avg = energyInOneSecFrame.Average();

            for (int i = 0; i < framesCount; i++)
            {
                // Operations for each frame
                if (energyResultInFrame[i] > 0.001 && zcrResultInFrame[i] > 0.1)
                    resultInFrames[i] = 1;
                //  

                avgResult += resultInFrames[i];
            }

            avgResult /= framesCount;
            return avgResult;
        }

        private static double GetVolumeStandardDeviation(double[] volume)
        {
            if (volume.Length <= 1)
                return 0.0;

            var avg = volume.Average();
            var sum = volume.Sum(value => (value - avg) * (value - avg));
            sum /= volume.Length;

            return Math.Sqrt(sum) / volume.Max();
        }

        private static double GetVolumeDynamicRange(double[] volume)
        {
            var max = volume.Max();
            var min = volume.Min();

            return (max - min) / max;
        }

        private static double GetLowShortTimeEnergyRatio(double[] energy, CustomPoint[] parsedFile, double sampleRate)
        {
            int framesCount = parsedFile.Length / (int)sampleRate;
            if (parsedFile.Length % sampleRate != 0)
                framesCount++;

            GetEnergy(parsedFile, (int)sampleRate, framesCount, out double[] energyInOneSecFrame);

            var avg = energyInOneSecFrame.Average();
            var sum = energy.Sum(value => Math.Sign(0.5 * avg - value) + 1);

            return sum / (2.0 * energy.Length);
        }

        private static double GetHighZeroCrossingRateRatio(double[] zeroCrossingRate, CustomPoint[] parsedFile, double sampleRate)
        {
            int framesCount = parsedFile.Length / (int)sampleRate;
            if (parsedFile.Length % sampleRate != 0)
                framesCount++;

            GetZeroCrossingRate(parsedFile, (int)sampleRate, framesCount, sampleRate, out double[] zcrInOneSecFrame);

            var avg = zcrInOneSecFrame.Average();
            var sum = zeroCrossingRate.Sum(value => Math.Sign(value - 1.5 * avg) + 1);

            return sum / (2.0 * zeroCrossingRate.Length);
        }

        #endregion

        #region Fourier Helpers

        private static Complex32[] GetSamplesForFourier(IEnumerable<CustomPoint> samplesToTransform, WindowType selectedWindowType, out int newSamplesCount)
        {
            // Get window function for analysis
            double[] window = null;
            switch (selectedWindowType)
            {
                case WindowType.Rectangular:
                    window = Window.Dirichlet(samplesToTransform.Count());
                    break;
                case WindowType.Hamming:
                    window = Window.Hamming(samplesToTransform.Count());
                    break;
                case WindowType.Hann:
                    window = Window.Hann(samplesToTransform.Count());
                    break;
            }

            // Align samples number to next power of 2
            var closestPowerOfTwo = (int)Math.Ceiling(Math.Log(samplesToTransform.Count(), 2));
            newSamplesCount = (int)Math.Pow(2, closestPowerOfTwo);
            var transformData = new Complex32[newSamplesCount];

            // Assign data to array of Complex
            for (int i = 0; i < samplesToTransform.Count(); i++)
                transformData[i] = (float)(samplesToTransform.ElementAt(i).Y * window[i]);

            return transformData;
        }

        private static Complex32[][] GetSamplesForSpectrogram(CustomPoint[] parsedFile, int samplesPerFrame, double frameOverlapping, WindowType selectedWindowType, out int rowCount, out int columnCount, out int frameOffset)
        {
            frameOffset = (int)((1 - frameOverlapping) * samplesPerFrame);
            if (frameOffset == 0)
                frameOffset = 1;

            rowCount = samplesPerFrame;
            columnCount = (parsedFile.Length - samplesPerFrame) / frameOffset;

            var result = new Complex32[columnCount][];

            double[] window = null;
            switch (selectedWindowType)
            {
                case WindowType.Rectangular:
                    window = Window.Dirichlet(parsedFile.Length);
                    break;
                case WindowType.Hamming:
                    window = Window.Hamming(parsedFile.Length);
                    break;
                case WindowType.Hann:
                    window = Window.Hann(parsedFile.Length);
                    break;
            }

            for (int i = 0; i < columnCount; i++)
            {
                result[i] = new Complex32[rowCount];

                for(int j = 0; j < rowCount; j++)
                {
                    int sampleIdx;
                    if ((sampleIdx = j + i * frameOffset) < parsedFile.Length)
                        result[i][j] = (float)(parsedFile[sampleIdx].Y * window[sampleIdx]);
                    else
                        result[i][j] = 0;
                }
            }

            return result;
        }

        #endregion
    }
}
