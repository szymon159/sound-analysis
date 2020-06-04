using System;
using System.Windows.Forms;

namespace SoundAnalysis
{
    public static class ExtensionMethods
    {
        // StatisticsType Extensions
        //
        public static StatisticsType ToStatisticsType(this ToolStripMenuItem item)
        {
            if (item.Name.ToLower().Contains("silence"))
                return StatisticsType.Silence;
            else if (item.Name.ToLower().Contains("soundless"))
                return StatisticsType.SoundlessSpeech;
            else if (item.Name.ToLower().Contains("sound"))
                return StatisticsType.SoundSpeech;
            else if (item.Name.ToLower().Contains("music"))
                return StatisticsType.Music;

            throw new ArgumentOutOfRangeException($"No StatisticsType corresponds item with name {item.Name}");
        }

    }
}
