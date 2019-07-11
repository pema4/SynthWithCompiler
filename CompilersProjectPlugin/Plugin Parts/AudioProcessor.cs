using Jacobi.Vst.Core;
using Jacobi.Vst.Framework.Plugin;
using System.Threading;

namespace CompilersProject
{
    /// <summary>
    /// Реализация интерфейса IVstPluginAudioProcessor.
    /// </summary>
    class AudioProcessor : VstPluginAudioProcessorBase
    {
        /// <summary>
        /// Ссылка на плагин, которому принадлежит этот компонент.
        /// </summary>
        private Plugin plugin;

        /// <summary>
        /// Ссылка на объект, предстающий собой всю цепочку создания и обработки звука.
        /// </summary>
        public Routing Routing { get; private set; }

        /// <summary>
        /// Текущая частота дискретизации.
        /// </summary>
        public override float SampleRate
        {
            get => Routing.SampleRate;
            set => Routing.SampleRate = value;
        }

        /// <summary>
        /// Инициализирует новых объект типа AudioProcessor, принадлежащий заданному плагину.
        /// </summary>
        /// <param name="plugin"></param>
        public AudioProcessor(Plugin plugin) : base(0, 1, 0)
        {
            this.plugin = plugin;
            Routing = new Routing(plugin);
        }

        /// <summary>
        /// Метод, обрабатывающий входные данные, поступающие от плагина, и генерирующий новые выходные данные.
        /// </summary>
        /// <param name="inChannels">Входные каналы.</param>
        /// <param name="outChannels">Выходные каналы.</param>
        public override void Process(VstAudioBuffer[] inChannels, VstAudioBuffer[] outChannels)
        {
            for (int i = 0; i < outChannels[0].SampleCount; ++i)
            {
                Routing.Process(out var output);

                outChannels[0][i] = output;
            }
        }
    }
}
