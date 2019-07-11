using System;

namespace ControlScriptLibrary
{
    public class ControlScriptLibrary
    {
        private static Random rnd = new Random();

        public static double Length(Array arr) => arr.Length;

        public static double MidiNoteToFrequency(double note) => 440 * Math.Pow(2, (note - 69) / 12.0);

        public static double Rnd() => rnd.NextDouble();
    }
}
