using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace SoundTimeParametersEvaluation
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
            X = point.XValue;
            Y = point.YValues.Single();
        }
    }
}
