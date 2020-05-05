using NAudio.Dsp;
using System;
using System.Windows.Forms;

namespace SoundAnalysis
{
    public static class ExtensionMethods
    {
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

        public static double SquaredModulus(this Complex complex)
        {
            return complex.X * complex.X + complex.Y * complex.Y;
        }

        public static double Modulus(this Complex complex)
        {
            return Math.Sqrt(complex.X * complex.X + complex.Y * complex.Y);
        }
    }
}
