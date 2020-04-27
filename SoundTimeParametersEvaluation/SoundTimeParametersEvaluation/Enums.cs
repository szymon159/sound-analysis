using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoundTimeParametersEvaluation
{
    public enum FrameLevelParamType
    {
        Volume,
        ShortTimeEnergy,
        ZeroCrossingRate,
        SilentRatio,
        SoundlessSpeech,
        SoundSpeech,
        Music
    }

    public enum ClipLevelParamType
    {
        VolumeStandardDeviation,
        VolumeDynamicRange,
        LowShortTimeEnergyRatio,
        HighZeroCrossingRateRatio
    }

    public enum StatisticsType
    {
        Silence,
        SoundlessSpeech,
        SoundSpeech,
        Music
    }

    public enum WindowType
    {
        Rectangular,
        Hamming,
        Hann
    }
}
