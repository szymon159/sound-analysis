using MathNet.Numerics.IntegralTransforms;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SoundTimeParametersEvaluation
{
    public partial class MainForm : Form
    {
        private Dictionary<FrameLevelParamType, Chart> charts;
        private Dictionary<FrameLevelParamType, Label> chartLabels;
        private Dictionary<ClipLevelParamType, Label> labels;
        private Dictionary<AnalysisType, bool> shouldRecalculateChart;

        private int milisecondsPerFrame = 40;
        private int samplesPerFrame;
        private double sampleRate;
        private CustomPoint[] parsedFile;
        private double frameOverlapping = 0.5;
        private bool shouldUpdateTrackBarValue = true;

        private WindowType selectedWindowType = WindowType.Rectangular;
        private AnalysisType selectedAnalysisType = AnalysisType.SoundParameters;
        private FourierTransfromScope selectedFourierTransfromScope = FourierTransfromScope.WholeClip;
        private double selectedFrameStartTime = 0.0;

        private Statistics statistics;

        public MainForm()
        {
            InitializeComponent();
            InitializeCollections();

            UpdateMPFTextBox();
        }

        private void InitializeCollections()
        {
            statistics = new Statistics();

            charts = new Dictionary<FrameLevelParamType, Chart>();
            charts.Add(FrameLevelParamType.Volume, volumeChart);
            charts.Add(FrameLevelParamType.ShortTimeEnergy, steChart);
            charts.Add(FrameLevelParamType.ZeroCrossingRate, zcrChart);
            charts.Add(FrameLevelParamType.SilentRatio, silenceChart);
            charts.Add(FrameLevelParamType.SoundlessSpeech, soundlessSpeechChart);
            charts.Add(FrameLevelParamType.SoundSpeech, soundSpeechChart);
            charts.Add(FrameLevelParamType.Music, musicChart);

            chartLabels = new Dictionary<FrameLevelParamType, Label>();
            chartLabels.Add(FrameLevelParamType.Volume, volumeValueLabel);
            chartLabels.Add(FrameLevelParamType.ShortTimeEnergy, steValueLabel);
            chartLabels.Add(FrameLevelParamType.ZeroCrossingRate, zcrValueLabel);
            chartLabels.Add(FrameLevelParamType.SilentRatio, silenceValueLabel);
            chartLabels.Add(FrameLevelParamType.SoundlessSpeech, soundlessSpeechValueLabel);
            chartLabels.Add(FrameLevelParamType.SoundSpeech, soundSpeechValueLabel);
            chartLabels.Add(FrameLevelParamType.Music, musicValueLabel);

            labels = new Dictionary<ClipLevelParamType, Label>();
            labels.Add(ClipLevelParamType.VolumeStandardDeviation, vstdValueLabel);
            labels.Add(ClipLevelParamType.VolumeDynamicRange, vdrValueLabel);
            labels.Add(ClipLevelParamType.LowShortTimeEnergyRatio, lsterValueLabel);
            labels.Add(ClipLevelParamType.HighZeroCrossingRateRatio, hzcrrValueLabel);

            shouldRecalculateChart = new Dictionary<AnalysisType, bool>();
            shouldRecalculateChart.Add(AnalysisType.SoundParameters, true);
            shouldRecalculateChart.Add(AnalysisType.Fourier, true);
            shouldRecalculateChart.Add(AnalysisType.Spectrum, true);
            shouldRecalculateChart.Add(AnalysisType.FundamentalFrequency, true);
        }

        private void UpdateTimeParameters()
        {
            UpdateFrameLevelParameter(FrameLevelParamType.Volume);
            UpdateFrameLevelParameter(FrameLevelParamType.ShortTimeEnergy);
            UpdateFrameLevelParameter(FrameLevelParamType.ZeroCrossingRate);
            UpdateFrameLevelParameter(FrameLevelParamType.SilentRatio);
            UpdateFrameLevelParameter(FrameLevelParamType.SoundlessSpeech);
            UpdateFrameLevelParameter(FrameLevelParamType.SoundSpeech);
            UpdateFrameLevelParameter(FrameLevelParamType.Music);

            var volume = volumeChart.Series[0].Points.SelectMany(point => point.YValues).ToArray();
            var energy = steChart.Series[0].Points.SelectMany(point => point.YValues).ToArray();
            var zeroCrossingRate = zcrChart.Series[0].Points.SelectMany(point => point.YValues).ToArray();

            UpdateClipLevelParameter(ClipLevelParamType.VolumeStandardDeviation, volume, energy, zeroCrossingRate);
            UpdateClipLevelParameter(ClipLevelParamType.VolumeDynamicRange, volume, energy, zeroCrossingRate);
            UpdateClipLevelParameter(ClipLevelParamType.LowShortTimeEnergyRatio, volume, energy, zeroCrossingRate);
            UpdateClipLevelParameter(ClipLevelParamType.HighZeroCrossingRateRatio, volume, energy, zeroCrossingRate);

            UpdateStatistics();
        }

        private void UpdateFrameLevelParameter(FrameLevelParamType parameter)
        {
            double result = Calculator.CalculateFrameLevelParameter(parameter, parsedFile, samplesPerFrame, sampleRate, out double[] valueInFrame);
            chartLabels[parameter].Text = result.ToString("0.000");

            var chart = charts[parameter];
            ChartHelper.UpdateFrameLevelChart(ref chart, valueInFrame, samplesPerFrame, parsedFile.Length, sampleRate);
        }

        private void UpdateClipLevelParameter(ClipLevelParamType parameter, double[] volume, double[] energy, double[] zeroCrossingRate)
        {
            double result = Calculator.CalculateClipLevelParameter(parameter, volume, energy, zeroCrossingRate, parsedFile, sampleRate);
            labels[parameter].Text = result.ToString("0.000");
        }

        private void UpdateStatistics()
        {
            statistics.Clear();
            int framesCount = silenceChart.Series[0].Points.Count;

            for (int i = 0; i < framesCount; i++)
            {
                var silencePoint = new CustomPoint(silenceChart.Series[0].Points[i]);
                var soundlessSoundPoint = new CustomPoint(soundlessSpeechChart.Series[0].Points[i]);
                var soundPoint = new CustomPoint(soundSpeechChart.Series[0].Points[i]);
                var musicPoint = new CustomPoint(musicChart.Series[0].Points[i]);
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

        private void UpdateMPFTextBox()
        {
            mpfTextBox.Text = milisecondsPerFrame.ToString();
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
                case AnalysisType.SoundParameters:
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

            ChartHelper.UpdateCustomPointChart(ref fourierTransformChart, fourierResult);
        }

        private void UpdateSpectrum()
        {
            Calculator.CalculateSpectrogram(parsedFile, selectedWindowType, samplesPerFrame, frameOverlapping, out double[,] transformResult);
            ChartHelper.UpdateSpectrogram(ref spectrogramPlotView, transformResult, parsedFile.Last().X, sampleRate);
        }

        private void UpdateFundamentalFrequency()
        {
            var fundamentalFrequency = Calculator.CalculateFundamentalFrequency(parsedFile, selectedWindowType, frameOverlapping, samplesPerFrame, sampleRate, out double[] resultInFrame);
            fundamentalFrequencyValueLabel.Text = string.Format($"{fundamentalFrequency:N2} Hz");
            ChartHelper.UpdateFrameLevelChart(ref fundamentalFrequencyChart, resultInFrame, samplesPerFrame, parsedFile.Length, sampleRate);
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

                parsedFile = new CustomPoint[wholeFile.Count];
                sampleRate = audioFileReader.WaveFormat.SampleRate;
                samplesPerFrame = milisecondsPerFrame * audioFileReader.WaveFormat.SampleRate / 1000;
                for (int i = 0; i < wholeFile.Count; i++)
                {
                    double timeInSeconds = i / sampleRate;
                    parsedFile[i] = new CustomPoint(timeInSeconds, wholeFile[i]);

                    chart1.Series[0].Points.AddXY(parsedFile[i].X, parsedFile[i].Y);
                }
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
                chart1.Series[0].Points.Clear();

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
            InvalidateCharts();
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

        #endregion
    }
}
