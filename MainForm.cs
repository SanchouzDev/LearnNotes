using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.MusicTheory;
using Melanchall.DryWetMidi.Multimedia;
using System.Runtime.InteropServices;
using System;

namespace LearnNotes
{
    public partial class MainForm : Form
    {
        HashSet<string> images, images_1, images_2, images_3, images_4, images_5, images_6;
        string imageNoteName;

        InputDevice _inputDevice;

        private const int WM_DEVICECHANGE = 0x0219;
        //private const int DBT_DEVICEARRIVAL = 0x8000;
        //private const int DBT_DEVICEREMOVECOMPLETE = 0x8004;

        uint lastMidiCount;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lastMidiCount = MIDI_Init.MidiCount();

            checkBox.Checked = true;
            checkBox_allNotes.Checked = true;
            images = new HashSet<string>();


            GetAllImages();
            FillImages();
            LoadRandomImage();

            if (InputDevice.GetAll().Count > 0)
            {
                _inputDevice = InputDevice.GetByIndex(0);
                _inputDevice.EventReceived += OnMidiEventReceived;
                _inputDevice.StartEventsListening();
            }
            else
            {
                DialogResult result = MessageBox.Show("Connect any MIDI-device first! Run the application anyway?", "Error", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    return;
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_DEVICECHANGE)
            {
                uint currentMidiCount = MIDI_Init.MidiCount();
                if (currentMidiCount > lastMidiCount)
                {
                    tipText.Text = "Midi connected";
                }
                else
                {
                    tipText.Text = "Midi disconected";
                }
                lastMidiCount = currentMidiCount;

                //if (m.WParam.ToInt32() == DBT_DEVICEARRIVAL || m.WParam.ToInt32() == DBT_DEVICEREMOVECOMPLETE)
                //{
                //    tipText.Text = "Midi connected";
                //    uint currentMidiCount = MIDI_Init.MidiCount();
                //    if (currentMidiCount > lastMidiCount)
                //    {
                //        tipText.Text = "Midi connected";
                //    }
                //    else
                //    {
                //        tipText.Text = "Midi disconected";
                //    }
                //    lastMidiCount = currentMidiCount;
                //}
            }
        }

        void GetAllImages()
        {
            images_1 = new HashSet<string>();
            foreach (string image in Directory.GetFiles("./Images/1"))
            {
                images_1.Add(image);
            }

            images_2 = new HashSet<string>();
            foreach (string image in Directory.GetFiles("./Images/2"))
            {
                images_2.Add(image);
            }

            images_3 = new HashSet<string>();
            foreach (string image in Directory.GetFiles("./Images/3"))
            {
                images_3.Add(image);
            }

            images_4 = new HashSet<string>();
            foreach (string image in Directory.GetFiles("./Images/4"))
            {
                images_4.Add(image);
            }

            images_5 = new HashSet<string>();
            foreach (string image in Directory.GetFiles("./Images/5"))
            {
                images_5.Add(image);
            }

            images_6 = new HashSet<string>();
            foreach (string image in Directory.GetFiles("./Images/6"))
            {
                images_6.Add(image);
            }
        }

        private void NewImageButton_Click(object sender, EventArgs e)
        {
            LoadRandomImage();
        }

        private void OnMidiEventReceived(object sender, MidiEventReceivedEventArgs e)
        {
            if (_inputDevice != null)
            {
                NoteOnEvent noteOnEvent = new();
                var midiDevice = (MidiDevice)sender;
                if (e.Event as NoteOnEvent != null)
                {
                    noteOnEvent = (NoteOnEvent)e.Event;
                }

                string midiNoteName = Note.Get(noteOnEvent.NoteNumber).ToString();

                if (midiNoteName == "C-1")
                {
                    midiNoteName = "----------";
                }

                midiOutText.Text = $"Midi out:\n\n{midiDevice.Name}: {e.Event}";
                midiNoteNameText.Text = "Midi note name:\n\n" + midiNoteName;

                if (midiNoteName == imageNoteName)
                {
                    LoadRandomImage();
                }
                if (midiNoteName == "A0")
                {
                    LoadRandomImage();
                }
            }
        }

        private void LoadRandomImage()
        {
            if (images.Count > 0 && images != null)
            {
                Random rnd = new();
                int a = rnd.Next(0, images.Count);
                pictureBox.Image = Image.FromFile(images.ElementAt(a));


                imageNoteName = $"{Path.GetFileNameWithoutExtension(images.ElementAt(a))}";
                if (checkBox.Checked)
                {
                    imageNoteNameText.Text = $"Image note:\n\n{imageNoteName}";
                }
                else
                {
                    imageNoteNameText.Text = $"Image note:\n\n----------";
                }
            }
        }

        private void checkBox_allNotes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_allNotes.Checked)
            {
                checkBox_C1.Checked = true;
                checkBox_C2.Checked = true;
                checkBox_C3.Checked = true;
                checkBox_C4.Checked = true;
                checkBox_C5.Checked = true;
                checkBox_C6.Checked = true;
            }
            else
            {
                checkBox_C1.Checked = false;
                checkBox_C2.Checked = false;
                checkBox_C3.Checked = false;
                checkBox_C4.Checked = false;
                checkBox_C5.Checked = false;
                checkBox_C6.Checked = false;
            }
        }

        private void Apply_Button_Click(object sender, EventArgs e)
        {
            FillImages();
        }

        void FillImages()
        {
            if (images.Count > 0)
            {
                images.Clear();
            }

            if (checkBox_C1.Checked)
            {
                images.UnionWith(images_1);
            }
            if (checkBox_C2.Checked)
            {
                images.UnionWith(images_2);
            }
            if (checkBox_C3.Checked)
            {
                images.UnionWith(images_3);
            }
            if (checkBox_C4.Checked)
            {
                images.UnionWith(images_4);
            }
            if (checkBox_C5.Checked)
            {
                images.UnionWith(images_5);
            }
            if (checkBox_C6.Checked)
            {
                images.UnionWith(images_6);
            }
        }
    }
}
