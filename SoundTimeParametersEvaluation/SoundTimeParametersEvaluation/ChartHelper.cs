using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace SoundTimeParametersEvaluation
{
    public static class ChartHelper
    {
        public static void UpdateFrameLevelChart(ref Chart chart, double[] valueInFrame, int samplesPerFrame, int samplesCount, double sampleRate)
        {
            chart.Series[0].Points.Clear();

            int frameCenter =  -samplesPerFrame / 2;
            int samplesInLastFrame = samplesCount % samplesPerFrame;

            for(int i = 0; i < valueInFrame.Length; i++)
            {
                if (i == valueInFrame.Length - 1)
                    frameCenter += (samplesPerFrame + samplesInLastFrame) / 2;
                else
                    frameCenter += samplesPerFrame;

                double timeInSeconds = frameCenter / sampleRate;
                chart.Series[0].Points.AddXY(timeInSeconds, valueInFrame[i]);
            }
        }

        internal static void UpdateCustomPointChart(ref Chart chart, CustomPoint[] points)
        {
            chart.Series[0].Points.Clear();

            foreach(var point in points)
                chart.Series[0].Points.AddXY(point.X, point.Y);
        }

        internal static void UpdateSpectrogram(ref PlotView spectrogram, double[,] data, double lengthInSeconds, double sampleRate)
        {
            var spectrogramPlotModel = new PlotModel
            {
                PlotType = PlotType.XY,
                Background = OxyColors.White,
            };

            var spectrogramHeatMapSeries = new HeatMapSeries
            {
                X0 = 0,
                X1 = lengthInSeconds,
                Y0 = 0,
                Y1 = sampleRate / 2,
                Interpolate = true
            };

            spectrogramPlotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = "Frequency [Hz]" });
            spectrogramPlotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = "Time [s]" });

            spectrogramHeatMapSeries.Data = data;
            spectrogramPlotModel.Series.Add(spectrogramHeatMapSeries);
            spectrogramPlotModel.Axes.Add(new LinearColorAxis
            {
                Position = AxisPosition.Right,
                IsAxisVisible = false,
            });
            spectrogram.Model = spectrogramPlotModel;
        }
    }
}
