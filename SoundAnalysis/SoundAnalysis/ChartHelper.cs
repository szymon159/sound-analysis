using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System;
using System.Linq;

namespace SoundAnalysis
{
    public static class ChartHelper
    {
        public static void UpdateFrameLevelChart(ref PlotView chart, double[] valueInFrame, int samplesPerFrame, int samplesCount, double sampleRate, out CustomPoint[] resultPoints, bool displayAxes = false)
        {
            resultPoints = new CustomPoint[valueInFrame.Length];

            var chartPlotModel = new PlotModel
            {
                PlotType = PlotType.XY,
                Background = OxyColors.White
            };

            var series = new LineSeries();
            var chartMaxY = 1.2 * valueInFrame.Max();
            chartPlotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, IsAxisVisible = displayAxes, Maximum = chartMaxY });
            chartPlotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, IsAxisVisible = displayAxes });

            int frameCenter = -samplesPerFrame / 2;
            int samplesInLastFrame = samplesCount % samplesPerFrame;

            for (int i = 0; i < valueInFrame.Length; i++)
            {
                if (i == valueInFrame.Length - 1)
                    frameCenter += (samplesPerFrame + samplesInLastFrame) / 2;
                else
                    frameCenter += samplesPerFrame;

                double timeInSeconds = frameCenter / sampleRate;
                resultPoints[i] = new CustomPoint(timeInSeconds, valueInFrame[i]);
                series.Points.Add(resultPoints[i].ToOxyPlotDataPoint());
            }

            chartPlotModel.Series.Add(series);
            chart.Model = chartPlotModel;
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
            var chartMaxY = 1.2 * points.Max(p => p.Y);
            var chartMinY = 1.2 * points.Min(p => p.Y);
            chartPlotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Title = labelY, Maximum = chartMaxY, Minimum = chartMinY });
            chartPlotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Title = labelX });

            foreach (var point in points)
                series.Points.Add(new DataPoint(point.X, point.Y));

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
