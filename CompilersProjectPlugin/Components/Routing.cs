using ControlScriptLanguage;
using Jacobi.Vst.Framework;
using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace CompilersProject
{
    /// <summary>
    /// Компонент плагина, предстающий собой всю цепочку создания обработки звука.
    /// </summary>
    class Routing : AudioComponent
    {
        private double[] samplesForOversampling = new double[8];
        private float amp;
        private Oscillator oscA = new Oscillator();
        private SvfFilter filter = new SvfFilter(SvfFilter.FilterType.Low);
        private Downsampler downsampler = new Downsampler();
        private Plugin plugin;
        private double midiNote;
        private float internalSampleRate;

        public object LockerObject { get; set; } = new object();

        public static string OscFrequencyScriptText { get; set; }
            = "yield 440;" + Environment.NewLine + "pause 1;";

        public static string FilterCutoffScriptText { get; set; }
            = "yield 1760;" + Environment.NewLine + "pause 1;";

        public static string FilterResonanceScriptText { get; set; }
            = "yield 0;" + Environment.NewLine + "pause 1;";

        public static string AmplitudeScriptText { get; set; }
            = "yield 1;" + Environment.NewLine + "pause 1;";

        public IControlScript OscAFrequencyScript { get; set; } = new DummyControlScript(440);

        public IControlScript FilterCutoffScript { get; set; } = new DummyControlScript(1760);

        public IControlScript FilterResonanceScript { get; set; } = new DummyControlScript(0);

        public IControlScript AmplitudeScript { get; set; } = new DummyControlScript(1);

        /// <summary>
        /// Инициализирует новый объект класса Routing, принадлежащий переданному плагину.
        /// </summary>
        /// <param name="plugin">Плагин, которому принадлежит создаваемый объект.</param>
        public Routing(Plugin plugin)
        {
            downsampler.Order = 2;
            this.plugin = plugin;

            plugin.MidiProcessor.NoteOn += MidiProcessor_NoteOn;
            plugin.MidiProcessor.NoteOff += MidiProcessor_NoteOff;
        }

        private void MidiProcessor_NoteOff(object sender, MidiNoteEventArgs e)
        {
            if (e.PressedNotesCount == 0)
            {
                OscAFrequencyScript.IsPlaying = false;
                FilterCutoffScript.IsPlaying = false;
                FilterResonanceScript.IsPlaying = false;
                AmplitudeScript.IsPlaying = false;
            }
        }

        private void MidiProcessor_NoteOn(object sender, MidiNoteEventArgs e)
        {
            midiNote = e.Note.NoteNo;
            OscAFrequencyScript.IsPlaying = true;
            FilterCutoffScript.IsPlaying = true;
            FilterResonanceScript.IsPlaying = true;
            AmplitudeScript.IsPlaying = true;
        }

        /// <summary>
        /// Генерация новых выходных данных.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Process(out float output)
        {
            lock (LockerObject)
            {
                UpdateScripts();
                for (int i = 0; i < downsampler.Order; ++i)
                {
                    ProcessScripts();
                    var oscAOutput = oscA.Process();
                    var filterOutput = filter.Process(oscAOutput);
                    var amplifiedOutput = filterOutput * amp;
                    samplesForOversampling[i] = amplifiedOutput;
                }
            
                output = (float)downsampler.Process(samplesForOversampling);
            }
        }

        private void ProcessScripts()
        {
            OscAFrequencyScript.MoveNext();
            var frequency = Utilities.Clamp(OscAFrequencyScript.Current, 0, oscA.SampleRate / 2);
            oscA.SetFrequency((float)frequency);

            FilterCutoffScript.MoveNext();
            var cutoff = Utilities.Clamp(FilterCutoffScript.Current, 0, filter.SampleRate / 2);
            filter.SetCutoff((float)cutoff);

            FilterResonanceScript.MoveNext();
            var resonance = Utilities.Clamp(FilterResonanceScript.Current, 0, 1);
            filter.SetQ((float)Math.Pow(16, resonance));

            AmplitudeScript.MoveNext();
            amp = (float)Utilities.Clamp(AmplitudeScript.Current, 0, 1);
        }

        private void UpdateScripts()
        {
            var bpm = plugin.Host.GetInstance<IVstHostSequencer>()
                .GetTime(Jacobi.Vst.Core.VstTimeInfoFlags.TempoValid).Tempo;
            
            OscAFrequencyScript.Bpm = bpm;
            OscAFrequencyScript.MidiNote = midiNote;
            OscAFrequencyScript.SampleRate = internalSampleRate;
            
            FilterCutoffScript.Bpm = bpm;
            FilterCutoffScript.MidiNote = midiNote;
            FilterCutoffScript.SampleRate = internalSampleRate;
            
            FilterResonanceScript.Bpm = bpm;
            FilterResonanceScript.MidiNote = midiNote;
            FilterResonanceScript.SampleRate = internalSampleRate;

            AmplitudeScript.Bpm = bpm;
            AmplitudeScript.MidiNote = midiNote;
            AmplitudeScript.SampleRate = internalSampleRate;
        }

        /// <summary>
        /// Обработчик изменения частоты дискретизации.
        /// </summary>
        /// <param name="newSampleRate">Новая частота дискретизации.</param>
        protected override void OnSampleRateChanged(float newSampleRate)
        {
            internalSampleRate = newSampleRate * downsampler.Order;
            oscA.SampleRate = internalSampleRate;
            filter.SampleRate = internalSampleRate;
        }
    }
}