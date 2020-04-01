using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundTimeParametersEvaluation
{
    public class Statistics
    {
        public List<TimeMarker> SilenceTimeMarkers { get; set; }

        public Statistics()
        {
            SilenceTimeMarkers = new List<TimeMarker>();
        }

        public void Clear()
        {
            SilenceTimeMarkers.Clear();
        }
    }
}
