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
        private int milisecondsPerFrame = 100;
        private int samplesPerFrame;
        private float sampleRate;

        private Point_f[] parsedFile;

        public MainForm()
        {
            InitializeComponent();

            UpdateMPFTextBox();
        }

        private void UpdateParameters()
        {
            UpdateVolume();
        }

        private void UpdateVolume()
        {
            float calculatedVolume = Calculator.CalculateVolume(parsedFile, samplesPerFrame, out float[] volumeInFrame);
            volumeValueLabel.Text = calculatedVolume.ToString("0.000");
            ChartHelper.UpdateChart(ref volumeChart, volumeInFrame, samplesPerFrame, parsedFile.Length, sampleRate);
        }

        private void UpdateMPFTextBox()
        {
            mpfTextBox.Text = milisecondsPerFrame.ToString();
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

                using (var audioFileReader = new AudioFileReader(filePath))
                {
                    var wholeFile = new List<float>((int)(audioFileReader.Length / 4));
                    var readBuffer = new float[audioFileReader.WaveFormat.SampleRate * audioFileReader.WaveFormat.Channels];
                    int samplesRead;
                    while ((samplesRead = audioFileReader.Read(readBuffer, 0, readBuffer.Length)) > 0)
                    {
                        wholeFile.AddRange(readBuffer.Take(samplesRead));
                    }

                    parsedFile = new Point_f[wholeFile.Count];
                    sampleRate = (float)audioFileReader.WaveFormat.SampleRate;
                    samplesPerFrame = milisecondsPerFrame * audioFileReader.WaveFormat.SampleRate / 1000;
                    for (int i = 0; i < wholeFile.Count; i++)
                    {
                        float timeInSeconds = i / sampleRate;
                        parsedFile[i] = new Point_f(timeInSeconds, wholeFile[i]);

                        chart1.Series[0].Points.AddXY(parsedFile[i].X, parsedFile[i].Y);
                    }
                }
            }

            UpdateParameters();
        }

        #endregion
    }
}
