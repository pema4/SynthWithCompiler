using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlScriptLanguage
{
    public interface IControlScript : IEnumerator<double>
    {
        double Bpm { get; set; }

        double SampleRate { get; set; }

        double MidiNote { get; set; }

        bool IsPlaying { get; set; }
    }
}
