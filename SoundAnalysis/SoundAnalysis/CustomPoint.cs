using OxyPlot;
using System.Linq;

namespace SoundAnalysis
{
    public struct CustomPoint
    {
        public double X { get; set; }
        public double Y { get; set; }

        public CustomPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public CustomPoint(DataPoint point)
        {
            X = point.X;
            Y = point.Y;
        }

        public DataPoint ToOxyPlotDataPoint()
        {
            return new DataPoint(X, Y);
        }
    }
}
