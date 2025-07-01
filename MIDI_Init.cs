using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LearnNotes
{
    internal class MIDI_Init
    {
        [DllImport("winmm.dll")]
        static extern uint midiInGetNumDevs();

        internal static uint MidiCount()
        {
            return midiInGetNumDevs();
        }
    }
}
