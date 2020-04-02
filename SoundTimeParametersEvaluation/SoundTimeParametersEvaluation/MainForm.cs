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

        private int milisecondsPerFrame = 40;
        private int samplesPerFrame;
        private double sampleRate;

        private CustomPoint[] parsedFile;
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
        }

        private void UpdateParameters()
        {
            UpdateFrameLevelParameter(FrameLevelParamType.Volume);
            UpdateFrameLevelParameter(FrameLevelParamType.ShortTimeEnergy);
            UpdateFrameLevelParameter(FrameLevelParamType.ZeroCrossingRate);
            UpdateFrameLevelParameter(FrameLevelParamType.SilentRatio);
            UpdateFrameLevelParameter(FrameLevelParamType.SoundlessSpeech);
            UpdateFrameLevelParameter(FrameLevelParamType.SoundSpeech);
            UpdateFrameLevelParameter(FrameLevelParamType.Music);

            var volume = volumeChart.Series[0].Points.SelectMany(point => point.YValues).ToArray();
            var energy = steChart.Series[0].Points.SelectMany(point => point.YValues ).ToArray(); 
            var zeroCrossingRate = zcrChart.Series[0].Points.SelectMany(point => point.YValues ).ToArray(); 

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
            ChartHelper.UpdateChart(ref chart, valueInFrame, samplesPerFrame, parsedFile.Length, sampleRate);
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

            for(int i = 0; i < framesCount; i++)
            {
                var point = new CustomPoint(silenceChart.Series[0].Points[i]);
                if (point.Y == 1)
                {
                    statistics.SilenceTimeMarkers.Add(TimeMarker.FromSample(point.X, milisecondsPerFrame));
                }
            }
        }

        private void UpdateMPFTextBox()
        {
            mpfTextBox.Text = milisecondsPerFrame.ToString();
        }

        private void UpdateMPFValue()
        {
            if(int.TryParse(mpfTextBox.Text, out milisecondsPerFrame))
                samplesPerFrame = milisecondsPerFrame * (int)sampleRate / 1000;
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
            }

            UpdateParameters();
        }

        private void mpfButton_Click(object sender, EventArgs e)
        {
            UpdateMPFValue();
            if(parsedFile != null && parsedFile.Length > 0)
                UpdateParameters();
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var popup = new StatisticsPopup(statistics, StatisticsType.Silence);
            popup.Show(this);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statistics.ExportByType(StatisticsType.Silence);
        }

        #endregion
    }
}
