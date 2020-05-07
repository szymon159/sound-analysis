using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SoundAnalysis
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

        internal static void UpdateCustomPointChart(ref PlotView chart, CustomPoint[] points, string labelX, string labelY, string title = null)
        {
            var chartPlotModel = new PlotModel
            {
                PlotType = PlotType.XY,
                Background = OxyColors.White
            };
            if (!string.IsNullOrEmpty(title))
                chartPlotModel.Title = title;

            var series = new LineSeries();
            chartPlotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = labelY });
            chartPlotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = labelX });

            foreach (var point in points)
                series.Points.Add(new OxyPlot.DataPoint(point.X, point.Y));

            chartPlotModel.Series.Add(series);
            chart.Model = chartPlotModel;
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
