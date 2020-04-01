using SoundTimeParametersEvaluation.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundTimeParametersEvaluation
{
    public static class Calculator
    {
        public static double CalculateFrameLevelParameter(ParameterType parameter, CustomPoint[] parsedFile, int samplesPerFrame, double sampleRate, out double[] resultInFrame)
        {
            int framesCount = parsedFile.Length / samplesPerFrame;
            if (parsedFile.Length % samplesPerFrame != 0)
                framesCount++;

            switch (parameter)
            {
                case ParameterType.Volume:
                    return GetRootMeanSquareInFrame(parsedFile, samplesPerFrame, framesCount, out resultInFrame, true);
                case ParameterType.ShortTimeEnergy:
                    return GetRootMeanSquareInFrame(parsedFile, samplesPerFrame, framesCount, out resultInFrame);
                case ParameterType.ZeroCrossingRate:
                    return GetZeroCrossingRate(parsedFile, samplesPerFrame, framesCount, sampleRate, out resultInFrame);
                default:
                    resultInFrame = new double[framesCount];
                    return 0.0;
            }
        }

        private static double GetRootMeanSquareInFrame(CustomPoint[] parsedFile, int samplesPerFrame, int framesCount, out double[] resultInFrame, bool takeRoot = false)
        {
            double avgResult = 0.0f;
            resultInFrame = new double[framesCount];

            for (int i = 0; i < framesCount; i++)
            {
                double squaredSum = 0.0f;
                for (int j = 0; j < samplesPerFrame; j++)
                {
                    int sampleIdx = i * samplesPerFrame + j;
                    if (sampleIdx >= parsedFile.Length)
                        break;
                    squaredSum += parsedFile[sampleIdx].Y * parsedFile[sampleIdx].Y;
                }

                resultInFrame[i] = squaredSum / samplesPerFrame;
                if (takeRoot)
                    resultInFrame[i] = Math.Sqrt(resultInFrame[i]);
                avgResult += resultInFrame[i];
            }

            avgResult /= framesCount;
            return avgResult;
        }

        private static double GetZeroCrossingRate(CustomPoint[] parsedFile, int samplesPerFrame, int framesCount, double sampleRate, out double[] resultInFrame)
        {
            double avgResult = 0.0f;
            resultInFrame = new double[framesCount];

            for (int i = 0; i < framesCount; i++)
            {
                double squaredSum = 0.0f;
                for (int j = 0; j < samplesPerFrame; j++)
                {
                    int sampleIdx = i * samplesPerFrame + j;
                    if (sampleIdx >= parsedFile.Length)
                        break;

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
                }

                resultInFrame[i] = (sampleRate * squaredSum) / (2 * samplesPerFrame);
                avgResult += resultInFrame[i];
            }

            avgResult /= framesCount;
            return avgResult;
        }
    }
}
