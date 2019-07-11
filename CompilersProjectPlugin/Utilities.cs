using Jacobi.Vst.Framework;
using System;
using System.IO;
using System.Text;

namespace CompilersProject
{
    /// <summary>
    /// Класс, содержащий различные вспомогательные методы.
    /// </summary>
    static class Utilities
    {
        /// <summary>
        /// Стандартная частота дискретизации.
        /// </summary>
        private const double DefaultSampleRate = 44100;
        
        /// <summary>
        /// Метод, переводящий номер клавиши в частоту.
        /// </summary>
        /// <param name="note"></param>
        /// <returns></returns>
        public static double MidiNoteToFrequency(double note)
        {
            return 440 * Math.Pow(2, (note - 69) / 12.0);
        }

        public static double CvToFrequency(double cv)
        {
            return MidiNoteToFrequency(cv * 12);
        }

        public static double Clamp(double value, double lo, double hi)
        {
            if (value < lo)
                return lo;
            else if (value < hi)
                return value;
            else
                return hi;
        }
        
        /// <summary>
        /// Функция-генератор пилообразной волны.
        /// </summary>
        /// <param name="phase"></param>
        /// <param name="freq"></param>
        /// <param name="maxFreq"></param>
        /// <returns></returns>
        private static double SawGenerator(double phase, double freq, double maxFreq)
        {
            int harmonicsCount = (int)(maxFreq / freq);
            double res = 0;
            for (int i = 1; i <= harmonicsCount; ++i)
                res += Math.Pow(-1, i + 1) * Math.Sin(2 * Math.PI * i * phase) / i;
            return res;
        }

        public static WaveTableOscillator SawWaveTable = new WaveTableOscillator(SawGenerator, 20, DefaultSampleRate / 2);
    }
}
