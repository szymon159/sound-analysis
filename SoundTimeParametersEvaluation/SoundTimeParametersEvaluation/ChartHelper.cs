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
    }
}
