using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundTimeParametersEvaluation.Enum
{
    public enum FrameLevelParamType
    {
        Volume,
        ShortTimeEnergy,
        ZeroCrossingRate,
        SilentRatio
    }

    public enum ClipLevelParamType
    {
        VolumeStandardDeviation
    }
}
