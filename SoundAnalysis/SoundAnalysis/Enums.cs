namespace SoundAnalysis
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

    public enum AnalysisType
    {
        SoundParameters,
        Fourier,
        Spectrum,
        FundamentalFrequency
    }

    public enum FourierTransfromScope
    {
        WholeClip,
        OneFrame
    }
}
