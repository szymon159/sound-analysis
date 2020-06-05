using NAudio.Wave;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SoundAnalysis
{
    public partial class MainForm : Form
    {
        private CustomPoint[] parsedFile;

        private Dictionary<FrameLevelParamType, PlotView> charts;
        private Dictionary<FrameLevelParamType, Label> chartLabels;
        private Dictionary<ClipLevelParamType, Label> labels;
        private Dictionary<AnalysisType, bool> shouldRecalculateChart;

        private int milisecondsPerFrame = 20;
        private int samplesPerFrame;
        private double sampleRate;
        private double frameOverlapping = 0.5;
        private bool shouldUpdateTrackBarValue = true;
        private double selectedFrameStartTime = 0.0;
        private int bandStart = 0;
        private int bandEnd = 100;

        private WindowType selectedWindowType = WindowType.Rectangular;
        private AnalysisType selectedAnalysisType = AnalysisType.SoundTimeParameters;
        private FourierTransfromScope selectedFourierTransfromScope = FourierTransfromScope.WholeClip;

        private Statistics statistics;

        public MainForm()
        {
            InitializeComponent();
            InitializeCollections();

            UpdateTextBoxes();
        }

        private void InitializeCollections()
        {
            statistics = new Statistics();
        
            charts = new Dictionary<FrameLevelParamType, PlotView>();
            charts.Add(FrameLevelParamType.Volume, volumePlotView);
            charts.Add(FrameLevelParamType.ShortTimeEnergy, stePlotView);
            charts.Add(FrameLevelParamType.ZeroCrossingRate, zcrPlotView);
            charts.Add(FrameLevelParamType.SilentRatio, silencePlotView);
            charts.Add(FrameLevelParamType.SoundlessSpeech, soundlessSpeechPlotView);
            charts.Add(FrameLevelParamType.SoundSpeech, soundSpeechPlotView);
            charts.Add(FrameLevelParamType.Music, musicPlotView);
            charts.Add(FrameLevelParamType.FrequencyVolume, freqVolumePlotView);
            charts.Add(FrameLevelParamType.FrequencyCentroid, fcPlotView);
            charts.Add(FrameLevelParamType.EffectiveBandwidth, bwPlotView);
            charts.Add(FrameLevelParamType.BandEnergy, bePlotView);

            chartLabels = new Dictionary<FrameLevelParamType, Label>();
            chartLabels.Add(FrameLevelParamType.Volume, volumeValueLabel);
            chartLabels.Add(FrameLevelParamType.ShortTimeEnergy, steValueLabel);
            chartLabels.Add(FrameLevelParamType.ZeroCrossingRate, zcrValueLabel);
            chartLabels.Add(FrameLevelParamType.SilentRatio, silenceValueLabel);
            chartLabels.Add(FrameLevelParamType.SoundlessSpeech, soundlessSpeechValueLabel);
            chartLabels.Add(FrameLevelParamType.SoundSpeech, soundSpeechValueLabel);
            chartLabels.Add(FrameLevelParamType.Music, musicValueLabel);
            chartLabels.Add(FrameLevelParamType.FrequencyVolume, freqVolumeValueLabel);
            chartLabels.Add(FrameLevelParamType.FrequencyCentroid, fcValueLabel);
            chartLabels.Add(FrameLevelParamType.EffectiveBandwidth, bwValueLabel);
            chartLabels.Add(FrameLevelParamType.BandEnergy, beValueLabel);

            labels = new Dictionary<ClipLevelParamType, Label>();
            labels.Add(ClipLevelParamType.VolumeStandardDeviation, vstdValueLabel);
            labels.Add(ClipLevelParamType.VolumeDynamicRange, vdrValueLabel);
            labels.Add(ClipLevelParamType.LowShortTimeEnergyRatio, lsterValueLabel);
            labels.Add(ClipLevelParamType.HighZeroCrossingRateRatio, hzcrrValueLabel);

            shouldRecalculateChart = new Dictionary<AnalysisType, bool>();
            shouldRecalculateChart.Add(AnalysisType.SoundTimeParameters, true);
            shouldRecalculateChart.Add(AnalysisType.Fourier, true);
            shouldRecalculateChart.Add(AnalysisType.Spectrum, true);
            shouldRecalculateChart.Add(AnalysisType.FundamentalFrequency, true);
            shouldRecalculateChart.Add(AnalysisType.SoundFrequencyParameters, true);
        }

        private void UpdateTimeParameters()
        {
            UpdateFrameLevelParameter(FrameLevelParamType.Volume, out CustomPoint[] volumePoints);
            UpdateFrameLevelParameter(FrameLevelParamType.ShortTimeEnergy, out CustomPoint[] energyPoints);
            UpdateFrameLevelParameter(FrameLevelParamType.ZeroCrossingRate, out CustomPoint[] zeroCrossingRatePoints);
            UpdateFrameLevelParameter(FrameLevelParamType.SilentRatio, out CustomPoint[] silencePoints);
            UpdateFrameLevelParameter(FrameLevelParamType.SoundlessSpeech, out CustomPoint[] soundlessSpeechPoints);
            UpdateFrameLevelParameter(FrameLevelParamType.SoundSpeech, out CustomPoint[] soundSpeechPoints);
            UpdateFrameLevelParameter(FrameLevelParamType.Music, out CustomPoint[] musicPoints);

            var volume = volumePoints.Select(p => p.Y).ToArray();
            var energy = energyPoints.Select(p => p.Y).ToArray();
            var zeroCrossingRate = zeroCrossingRatePoints.Select(p => p.Y).ToArray();

            UpdateClipLevelParameter(ClipLevelParamType.VolumeStandardDeviation, volume, energy, zeroCrossingRate);
            UpdateClipLevelParameter(ClipLevelParamType.VolumeDynamicRange, volume, energy, zeroCrossingRate);
            UpdateClipLevelParameter(ClipLevelParamType.LowShortTimeEnergyRatio, volume, energy, zeroCrossingRate);
            UpdateClipLevelParameter(ClipLevelParamType.HighZeroCrossingRateRatio, volume, energy, zeroCrossingRate);

            UpdateStatistics(silencePoints, soundlessSpeechPoints, soundSpeechPoints, musicPoints);
        }

        private void UpdateFrequencyParameters()
        {
            var framesCount = parsedFile.Length / samplesPerFrame;

            Calculator.CalculateFrequencyVolume(parsedFile, sampleRate, selectedWindowType, samplesPerFrame, framesCount, out double[] volume);
            var avgVolume = Calculator.Normalize(ref volume);
            chartLabels[FrameLevelParamType.FrequencyVolume].Text = avgVolume.ToString("0.00");
            var volumeChart = charts[FrameLevelParamType.FrequencyVolume];
            ChartHelper.UpdateFrameLevelChart(ref volumeChart, volume, samplesPerFrame, parsedFile.Length, sampleRate, out _, true);

            var avgFrequencyCentroid = Calculator.CalculateFrequencyCentroid(parsedFile, sampleRate, selectedWindowType, samplesPerFrame, framesCount, out double[] frequencyCentroid);
            chartLabels[FrameLevelParamType.FrequencyCentroid].Text = avgFrequencyCentroid.ToString("0.00");
            var fcChart = charts[FrameLevelParamType.FrequencyCentroid];
            ChartHelper.UpdateFrameLevelChart(ref fcChart, frequencyCentroid, samplesPerFrame, parsedFile.Length, sampleRate, out _, true);

            var avgBandwidth = Calculator.CalculateEffectiveBandwith(parsedFile, sampleRate, selectedWindowType, samplesPerFrame, framesCount, frequencyCentroid, out double[] effectiveBandwith);
            chartLabels[FrameLevelParamType.EffectiveBandwidth].Text = avgBandwidth.ToString("0.00");
            var bwChart = charts[FrameLevelParamType.EffectiveBandwidth];
            ChartHelper.UpdateFrameLevelChart(ref bwChart, effectiveBandwith, samplesPerFrame, parsedFile.Length, sampleRate, out _, true);

            var avgEnergy = Calculator.CalculateBandEnergy(parsedFile, sampleRate, selectedWindowType, samplesPerFrame, framesCount, bandStart, bandEnd, out double[] bandEnergy);
            chartLabels[FrameLevelParamType.BandEnergy].Text = avgEnergy.ToString("0.00");
            var beChart = charts[FrameLevelParamType.BandEnergy];
            ChartHelper.UpdateFrameLevelChart(ref beChart, bandEnergy, samplesPerFrame, parsedFile.Length, sampleRate, out _, true);
        }

        private void UpdateFrameLevelParameter(FrameLevelParamType parameter, out CustomPoint[] resultPoints)
        {
            double result = Calculator.CalculateFrameLevelParameter(parameter, parsedFile, samplesPerFrame, sampleRate, out double[] valueInFrames);
            chartLabels[parameter].Text = result.ToString("0.000");

            var chart = charts[parameter];
            ChartHelper.UpdateFrameLevelChart(ref chart, valueInFrames, samplesPerFrame, parsedFile.Length, sampleRate, out resultPoints);
        }

        private void UpdateClipLevelParameter(ClipLevelParamType parameter, double[] volume, double[] energy, double[] zeroCrossingRate)
        {
            double result = Calculator.CalculateClipLevelParameter(parameter, volume, energy, zeroCrossingRate, parsedFile, sampleRate);
            labels[parameter].Text = result.ToString("0.000");
        }

        private void UpdateStatistics(CustomPoint[] silencePoints, CustomPoint[] soundlessSpeechPoints, CustomPoint[] soundSpeechPoints, CustomPoint[] musicPoints)
        {
            statistics.Clear();
            int framesCount = silencePoints.Length;

            for (int i = 0; i < framesCount; i++)
            {
                var silencePoint = silencePoints[i];
                var soundlessSoundPoint = soundlessSpeechPoints[i];
                var soundPoint = soundSpeechPoints[i];
                var musicPoint = musicPoints[i];
                if (silencePoint.Y == 1)
                    statistics.AddMarkerByType(StatisticsType.Silence, TimeMarker.FromSample(silencePoint.X, milisecondsPerFrame));
                if (soundlessSoundPoint.Y == 1)
                    statistics.AddMarkerByType(StatisticsType.SoundlessSpeech, TimeMarker.FromSample(silencePoint.X, milisecondsPerFrame));
                if (soundPoint.Y == 1)
                    statistics.AddMarkerByType(StatisticsType.SoundSpeech, TimeMarker.FromSample(silencePoint.X, milisecondsPerFrame));
                if (musicPoint.Y == 1)
                    statistics.AddMarkerByType(StatisticsType.Music, TimeMarker.FromSample(silencePoint.X, milisecondsPerFrame));
            }
        }

        private void UpdateTextBoxes()
        {
            UpdateMPFTextBox();
            UpdateBandStartTextBox();
            UpdateBandEndTextBox();
        }

        private void UpdateMPFTextBox()
        {
            mpfTextBox.Text = milisecondsPerFrame.ToString();
        }

        private void UpdateBandStartTextBox()
        {
            bandStartTextBox.Text = bandStart.ToString();
        }

        private void UpdateBandEndTextBox()
        {
            bandEndTextBox.Text = bandEnd.ToString();
        }

        private void UpdateMPFValue()
        {
            if (int.TryParse(mpfTextBox.Text, out milisecondsPerFrame))
            {
                samplesPerFrame = milisecondsPerFrame * (int)sampleRate / 1000;
                InvalidateCharts();
            }
        }

        private void InvalidateCharts()
        {
            foreach(var analysisType in shouldRecalculateChart.Keys.ToList())
            {
                shouldRecalculateChart[analysisType] = true;
            }

            if (parsedFile != null && parsedFile.Length != 0)
                UpdateAnalysisResults(selectedAnalysisType);
        }

        private void UpdateAnalysisResults(AnalysisType analysisType)
        {
            switch(analysisType)
            {
                case AnalysisType.SoundTimeParameters:
                    UpdateTimeParameters();
                    break;
                case AnalysisType.Fourier:
                    UpdateFourierTransform();
                    break;
                case AnalysisType.Spectrum:
                    UpdateSpectrum();
                    break;
                case AnalysisType.FundamentalFrequency:
                    UpdateFundamentalFrequency();
                    break;
                case AnalysisType.SoundFrequencyParameters:
                    UpdateFrequencyParameters();
                    break;
            }

            shouldRecalculateChart[analysisType] = false;
        }

        private void UpdateFourierTransform()
        {
            var fourierResult = new CustomPoint[1];

            switch (selectedFourierTransfromScope)
            {
                case FourierTransfromScope.WholeClip:
                    Calculator.CalculateFourierTransform(parsedFile, sampleRate, selectedWindowType, out fourierResult);
                    break;
                case FourierTransfromScope.OneFrame:
                    Calculator.CalculateFourierTransform(parsedFile, sampleRate, selectedWindowType, out fourierResult, samplesPerFrame, (int)(sampleRate * selectedFrameStartTime));
                    break;
                default:
                    break;
            }

            ChartHelper.UpdateCustomPointChart(ref fourierPlotView, fourierResult, "Frequency [Hz]", "Magnitude", "Fourier Transform");
        }

        private void UpdateSpectrum()
        {
            Calculator.CalculateSpectrogram(parsedFile, selectedWindowType, samplesPerFrame, frameOverlapping, out double[,] transformResult);
            ChartHelper.UpdateSpectrogram(ref spectrogramPlotView, transformResult, parsedFile.Last().X, sampleRate);
        }

        private void UpdateFundamentalFrequency()
        {
            var fundamentalFrequency = Calculator.CalculateFundamentalFrequency(parsedFile, selectedWindowType, frameOverlapping, samplesPerFrame, sampleRate, out CustomPoint[] transformResult);
            fundamentalFrequencyValueLabel.Text = string.Format($"{fundamentalFrequency:N2} Hz");
            ChartHelper.UpdateCustomPointChart(ref fundamentalFrequencyPlotView, transformResult, "Time [s]", "Frequency [Hz]");
        }

        private void LoadFile(string filePath)
        {
            using (var audioFileReader = new AudioFileReader(filePath))
            {
                var wholeFile = new List<float>((int)(audioFileReader.Length / 4));
                var readBuffer = new float[audioFileReader.WaveFormat.SampleRate * audioFileReader.WaveFormat.Channels];
                int samplesRead;
                while ((samplesRead = audioFileReader.Read(readBuffer, 0, readBuffer.Length)) > 0)
                {
                    wholeFile.AddRange(readBuffer.Take(samplesRead));
                }

                var fileName = Path.GetFileName(filePath);
                parsedFile = new CustomPoint[wholeFile.Count];
                sampleRate = audioFileReader.WaveFormat.SampleRate;
                samplesPerFrame = milisecondsPerFrame * audioFileReader.WaveFormat.SampleRate / 1000;
                for (int i = 0; i < wholeFile.Count; i++)
                {
                    double timeInSeconds = i / sampleRate;
                    parsedFile[i] = new CustomPoint(timeInSeconds, wholeFile[i]);
                }
                ChartHelper.UpdateCustomPointChart(ref recordingPlotView, parsedFile, "Time [s]", "", fileName);
            }
        }

        #region Forms handlers

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "\\.";
            openFileDialog.Filter = "Wave form audio format (*.wav)|*.wav|" +
                                    "MP3 audio file (*.mp3)|*.mp3";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;

                LoadFile(filePath);
                UpdateAnalysisResults(selectedAnalysisType);
            }
        }

        private void mpfButton_Click(object sender, EventArgs e)
        {
            UpdateMPFValue();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var type = (sender as ToolStripMenuItem).ToStatisticsType();

            var popup = new StatisticsPopup(statistics, type);
            popup.Show(this);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var type = (sender as ToolStripMenuItem).ToStatisticsType();

            statistics.ExportByType(type);
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var shouldShowWindowType = mainTabControl.SelectedIndex != 0;

            windowTypeGroupBox.Visible = shouldShowWindowType;
            windowTypeComboBox.Visible = shouldShowWindowType;
            windowTypeComboBox.SelectedItem = selectedWindowType;

            selectedAnalysisType = (AnalysisType)mainTabControl.SelectedIndex;
            if (parsedFile != null && parsedFile.Length != 0 && shouldRecalculateChart[selectedAnalysisType])
                UpdateAnalysisResults(selectedAnalysisType);
        }

        private void oneFrameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedFourierTransfromScope = FourierTransfromScope.OneFrame;
            frameStartTextBox.Enabled = true;

            shouldRecalculateChart[AnalysisType.Fourier] = true;
            if (parsedFile != null && parsedFile.Length != 0)
                UpdateAnalysisResults(AnalysisType.Fourier);
        }

        private void wholeClipRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            selectedFourierTransfromScope = FourierTransfromScope.WholeClip;
            frameStartTextBox.Enabled = false;

            shouldRecalculateChart[AnalysisType.Fourier] = true;
            if (parsedFile != null && parsedFile.Length != 0)
                UpdateAnalysisResults(AnalysisType.Fourier);
        }

        private void frameStartTextBox_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(frameStartTextBox.Text, out selectedFrameStartTime) && selectedFrameStartTime >= 0)
            {
                if (selectedFrameStartTime > (parsedFile.Length - samplesPerFrame) / sampleRate)
                {
                    selectedFrameStartTime = (parsedFile.Length - samplesPerFrame) / sampleRate;
                    frameStartTextBox.Text = selectedFrameStartTime.ToString("N3");
                }

                shouldRecalculateChart[AnalysisType.Fourier] = true;
                if (parsedFile != null && parsedFile.Length != 0)
                    UpdateAnalysisResults(AnalysisType.Fourier);
            }
            else
            {
                frameStartTextBox.Text = selectedFrameStartTime.ToString("N3");
            }
        }

        private void windowTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedWindowType = (WindowType)windowTypeComboBox.SelectedIndex;

            shouldRecalculateChart[AnalysisType.Fourier] = true;
            shouldRecalculateChart[AnalysisType.Spectrum] = true;
            shouldRecalculateChart[AnalysisType.FundamentalFrequency] = true;
            shouldRecalculateChart[AnalysisType.SoundFrequencyParameters] = true;

            if (parsedFile != null && parsedFile.Length != 0)
                UpdateAnalysisResults(selectedAnalysisType);
        }

        private void frameOverlappingTrackBar_ValueChanged(object sender, EventArgs e)
        {
            if(!shouldUpdateTrackBarValue)
            {
                shouldUpdateTrackBarValue = true;
                return;
            }

            shouldUpdateTrackBarValue = false;
            var changedTrackBar = sender as TrackBar;
            if (changedTrackBar == frameOverlappingTrackBar)
                frameOverlappingTrackBar2.Value = changedTrackBar.Value;
            else
                frameOverlappingTrackBar.Value = changedTrackBar.Value;

            frameOverlapping = frameOverlappingTrackBar.Value / 100.0;
            frameOverlappingValueLabel.Text = frameOverlapping.ToString();
            frameOverlappingValueLabel2.Text = frameOverlapping.ToString();
            shouldRecalculateChart[AnalysisType.Spectrum] = true;
            shouldRecalculateChart[AnalysisType.FundamentalFrequency] = true;
            if (parsedFile != null && parsedFile.Length != 0)
                UpdateAnalysisResults(selectedAnalysisType);
        }

        private void applyBandButton_Click(object sender, EventArgs e)
        {
            var oldStart = bandStart;
            var oldEnd = bandEnd;

            int.TryParse(bandStartTextBox.Text, out bandStart);
            int.TryParse(bandEndTextBox.Text, out bandEnd);

            if(oldStart != bandStart || oldEnd != bandEnd)
            {
                shouldRecalculateChart[AnalysisType.SoundFrequencyParameters] = true;
                if (parsedFile != null && parsedFile.Length != 0)
                    UpdateAnalysisResults(AnalysisType.SoundFrequencyParameters);
            }
        }

        #endregion
    }
}
