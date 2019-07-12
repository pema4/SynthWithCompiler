﻿using System;
using System.IO;

namespace CompilersProject
{
    /// <summary>
    /// Реализация осциллятора, основанного на таблицах сэмплов.
    /// </summary>
    public class WaveTableOscillator
    {
        /// <summary>
        /// Стандартная частота дискретизации.
        /// </summary>
        private const double DefaultSampleRate = 44100;
        
        /// <summary>
        /// Представляет собой одну таблицу сэмплов, записанную с заданным инкрементом фазы.
        /// </summary>
        private class WaveTable
        {
            /// <summary>
            /// Длина таблицы.
            /// </summary>
            public int Length;

            /// <summary>
            /// Сэмплы.
            /// </summary>
            public float[] Samples;

            /// <summary>
            /// Инкремент фазы, с которым эта таблица была сгенерирована.
            /// </summary>
            public float PhaseIncrement;
        }
        
        /// <summary>
        /// Список всех таблиц.
        /// </summary>
        private WaveTable[] waveTables;

        /// <summary>
        /// Текущая таблица.
        /// </summary>
        private WaveTable waveTable;

        /// <summary>
        /// Общее количество таблиц.
        /// </summary>
        private int waveTablesAmount;

        /// <summary>
        /// Текущий инкремент фазы.
        /// </summary>
        private float phaseIncrement;

        /// <summary>
        /// Представляет собой функцию-генератор для создания таблицы.
        /// </summary>
        /// <param name="phase">Текущая фаза.</param>
        /// <param name="freq">Минимальная частота, на которой будет проигрываться создаваемая таблица.</param>
        /// <param name="maxFreq">Максимальная частота, на которой будет проигрываться создаваемая таблица.</param>
        /// <returns>Значение функции-генератора при заданных параметрах.</returns>
        public delegate double GeneratorFunction(double phase, double freq, double maxFreq);

        /// <summary>
        /// Инициализирует новый объект типа WaveTableOscillator с заданными параметрами.
        /// </summary>
        /// <param name="generator">Функция-генератор.</param>
        /// <param name="startFrequency">Минимальная частота, на которой планируется генерировать звук.</param>
        /// <param name="endFrequency">Максимальная частота, на которой планируется генерировать звук.</param>
        public WaveTableOscillator(
            GeneratorFunction generator,
            double startFrequency,
            double endFrequency)
        {
            waveTablesAmount = (int)(Math.Floor(Math.Log(endFrequency / startFrequency, 2)) + 1);
            waveTables = new WaveTable[waveTablesAmount];
            for (int i = 0; i < waveTables.Length; ++i)
            {
                var frequency = startFrequency * (1 << i);
                var samples = PrepareSamples(generator, frequency, DefaultSampleRate / 2);
                waveTables[i] = new WaveTable
                {
                    Length = samples.Length,
                    PhaseIncrement = (float)(frequency / DefaultSampleRate),
                    Samples = samples,
                };
            }
            Normalize();
        }

        /// <summary>
        /// Метод, подготавливающий массив сэмплов.
        /// </summary>
        /// <param name="generator">Функция-генератор.</param>
        /// <param name="startFrequency">Частота, на которой генерируется этот массив сэмплов.</param>
        /// <param name="endFrequency">Максимальная частота, на которой планируется генерировать звук.</param>
        /// <returns>Массив сэмплов.</returns>
        private static float[] PrepareSamples(GeneratorFunction generator, double freq, double maxFreq)
        {
            var length = (int)DefaultSampleRate / 2;
            var result = new float[length];
            for (int i = 0; i < result.Length; ++i)
                result[i] = (float)generator((double)i / result.Length, freq, maxFreq);

            return result;
        }

        /// <summary>
        /// Метод, нормализующий все таблицы этого осциллятора.
        /// </summary>
        private void Normalize()
        {
            float maxAbs = 0;
            foreach (var wt in waveTables)
                foreach (var sample in wt.Samples)
                    if (Math.Abs(sample) > maxAbs)
                        maxAbs = Math.Abs(sample);
            foreach (var wt in waveTables)
                for (int i = 0; i < wt.Samples.Length; ++i)
                    wt.Samples[i] /= maxAbs;
        }        

        /// <summary>
        /// Устанавливает новое значение инкремента фазы.
        /// </summary>
        /// <param name="phaseIncrement">Инкремент фазы.</param>
        public void SetPhaseIncrement(double phaseIncrement)
        {
            this.phaseIncrement = (float)phaseIncrement;

            int wtIndex = 0;
            while (wtIndex < waveTablesAmount - 1 && phaseIncrement > waveTables[wtIndex].PhaseIncrement)
                wtIndex += 1;

            waveTable = waveTables[wtIndex];
        }

        /// <summary>
        /// Метод, возвращающий сэмпл по заданной фазе.
        /// </summary>
        /// <param name="phase">Фаза.</param>
        /// <returns>Выходной сэмпл.</returns>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public float Process(float phase)
        {
            if (phase >= 1)
                phase -= 1;

            var waveTable = this.waveTable;
            if (waveTable == null)
                return 0;

            var tableLength = waveTable.Length;
            float temp = phase * tableLength;
            int leftIndex = (int)temp;
            int rightIndex = leftIndex + 1;
            if (rightIndex == waveTable.Length)
                rightIndex = 0;
            float rightCoeff = temp - leftIndex;
            float leftCoeff = 1 - rightCoeff;
            return leftCoeff * waveTable.Samples[leftIndex] + rightCoeff * waveTable.Samples[rightIndex];
        }
    }
}
