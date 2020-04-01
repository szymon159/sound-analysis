using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public List<TimeMarker> GetByType(StatisticsType type)
        {
            switch(type)
            {
                case StatisticsType.Silence:
                    return SilenceTimeMarkers;
                default:
                    return new List<TimeMarker>();
            }
        }

        public ListViewItem[] GetListViewItemsByType(StatisticsType type)
        {
            var list = GetByType(type);
            var result = new List<ListViewItem>();

            for(int i = 0; i < list.Count; i++)
            {
                var item = new ListViewItem((i+1).ToString());
                item.SubItems.Add(list[i].Begin.ToString());
                item.SubItems.Add(list[i].End.ToString());
                item.SubItems.Add(list[i].Duration.TotalMilliseconds.ToString());

                result.Add(item);
            }

            return result.ToArray();
        }
    }
}
