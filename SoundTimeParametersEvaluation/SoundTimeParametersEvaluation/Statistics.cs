using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundTimeParametersEvaluation
{
    public class Statistics
    {
        public List<TimeMarker> SilenceTimeMarkers { get; private set; }
        public List<TimeMarker> SoundlessSpeechTimeMarkers { get; private set; }
        public List<TimeMarker> SoundSpeechTimeMarkers { get; private set; }
        public List<TimeMarker> MusicTimeMarkers { get; private set; }

        public Statistics()
        {
            SilenceTimeMarkers = new List<TimeMarker>();
            SoundlessSpeechTimeMarkers = new List<TimeMarker>();
            SoundSpeechTimeMarkers = new List<TimeMarker>();
            MusicTimeMarkers = new List<TimeMarker>();
        }

        public void Clear()
        {
            SilenceTimeMarkers.Clear();
            SoundlessSpeechTimeMarkers.Clear();
            SoundSpeechTimeMarkers.Clear();
            MusicTimeMarkers.Clear();
        }

        public List<TimeMarker> GetListByType(StatisticsType type)
        {
            switch(type)
            {
                case StatisticsType.Silence:
                    return SilenceTimeMarkers;
                case StatisticsType.SoundlessSpeech:
                    return SoundlessSpeechTimeMarkers;
                case StatisticsType.SoundSpeech:
                    return SoundSpeechTimeMarkers;
                case StatisticsType.Music:
                    return MusicTimeMarkers;
                default:
                    return new List<TimeMarker>();
            }
        }

        public void AddMarkerByType(StatisticsType type, TimeMarker markerToAdd)
        {
            var list = GetListByType(type);
            if(list.Count == 0)
            {
                list.Add(markerToAdd);
                return;
            }

            if (list[list.Count - 1].End == markerToAdd.Begin)
                list[list.Count - 1] = new TimeMarker(list[list.Count - 1].Begin, markerToAdd.End);
            else
                list.Add(markerToAdd);
        }

        public ListViewItem[] GetListViewItemsByType(StatisticsType type)
        {
            var list = GetListByType(type);
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

        public void ExportByType(StatisticsType type)
        {
            var list = GetListByType(type);
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = "\\.";
            saveFileDialog.Filter = "Comma-separated values (*.csv)|*.csv";
            saveFileDialog.FileName = type.ToString() + DateTime.Now.Ticks + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = saveFileDialog.FileName;

                using (StreamWriter file = new StreamWriter(filePath))
                {
                    for(int i = 0; i < list.Count; i++)
                    {
                        file.WriteLine(i + "," + list[i]);
                    }
                }
            }
        }
    }
}
