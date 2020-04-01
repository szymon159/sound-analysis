using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundTimeParametersEvaluation
{
    public static class Calculator
    {
        public static float CalculateVolume(Point_f[] parsedFile, int samplesPerFrame, out float[] resultInFrames)
        {
            float avgVolume = 0.0f;
            int framesCount = parsedFile.Length / samplesPerFrame;
            if (parsedFile.Length % samplesPerFrame != 0)
                framesCount++;

            resultInFrames = new float[framesCount];

            for (int i = 0; i < framesCount; i++)
            {
                float squaredSum = 0.0f;
                for(int j = 0; j < samplesPerFrame; j++)
                {
                    int sampleIdx = i * samplesPerFrame + j;
                    if (sampleIdx >= parsedFile.Length)
                        break;
                    squaredSum += parsedFile[sampleIdx].Y * parsedFile[sampleIdx].Y;
                }

                resultInFrames[i] = squaredSum / samplesPerFrame;
                avgVolume += resultInFrames[i];
            }

            avgVolume /= framesCount;
            return avgVolume;
        }

    }
}
