using System;

namespace CompilersProject
{
    /// <summary>
    /// Компонент голоса плагина, представляющий осциллятор.
    /// </summary>
    class Oscillator : AudioComponent
    {
        /// <summary>
        /// Играемая частота.
        /// </summary>
        private float frequency;

        /// <summary>
        /// Изменение фазы за 1 сэмпл.
        /// </summary>
        private float phaseIncrement;

        /// <summary>
        /// Текущая фаза осциллятора.
        /// </summary>
        private float phasor;

        /// <summary>
        /// Ссылка на используемый объект класса WaveTable.
        /// </summary>
        private WaveTableOscillator waveTable = Utilities.SawWaveTable;
        
        public void SetFrequency(float value)
        {
            if (frequency != value)
            {
                frequency = value;
                phaseIncrement = frequency / SampleRate;
                waveTable?.SetPhaseIncrement(phaseIncrement);
            }
        }

        /// <summary>
        /// Обработка новых входных данных.
        /// </summary>
        /// <param name="phaseModulation">Фазовая модуляция.</param>
        /// <returns>Выходной сигнал.</returns>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public float Process(float phaseModulation = 0)
        {
            // Расчёт текущей фазы.
            var phase = phasor + phaseModulation;
            phase -= (float)Math.Floor(phase);

            var waveTable = this.waveTable;
            float result;
            if (waveTable == null)
                result = 0;
            else
                result = waveTable.Process(phase);

            // Прибавление инкремента фазы текущей частоты.
            phasor += phaseIncrement;
            if (phasor >= 1)
                phasor -= 1;

            return result;
        }

        /// <summary>
        /// Обработчик изменения частоты дискретизации.
        /// </summary>
        /// <param name="newSampleRate">Новая частота дискретизации.</param>
        protected override void OnSampleRateChanged(float newSampleRate)
        {
            phaseIncrement = frequency / newSampleRate;
        }
    }
}
