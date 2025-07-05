using Melanchall.DryWetMidi.Core;
using Melanchall.DryWetMidi.MusicTheory;
using Melanchall.DryWetMidi.Multimedia;
using System.Runtime.InteropServices;
using System;

namespace LearnNotes
{
    public partial class MainForm : Form
    {
        List<InputDevice> inputDevices = new List<InputDevice>();
        HashSet<string> images, images_1, images_2, images_3, images_4, images_5, images_6;
        string imageNoteName;

        InputDevice _inputDevice;

        private const int WM_DEVICECHANGE = 0x0219;

        int lastMidiCount;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lastMidiCount = InputDevice.GetAll().Count;
            images = new HashSet<string>();

            GetMidiDevices();
            GetAllImages();
            FillImages();
            LoadRandomImage();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_DEVICECHANGE)
            {
                int currentMidiCount = InputDevice.GetAll().Count;
                if (currentMidiCount > lastMidiCount)
                {
                    GetMidiDevices(); // MIDI connect
                }
                else
                {
                    GetMidiDevices(); // MIDI disconnect
                }
                lastMidiCount = currentMidiCount;
            }
        }

        void GetMidiDevices()
        {
            if (inputDevices.Count > 0)
            {
                inputDevices.Clear();
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.Items.Clear();
                comboBox1.Text = "";
            }

            if (InputDevice.GetAll().Count > 0)
            {
                foreach (var device in InputDevice.GetAll())
                {
                    inputDevices.Add(device);
                    comboBox1.Items.Add(device.Name);
                }
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        void SetInputDevice()
        {
            if (InputDevice.GetAll().Count > 0)
            {
                _inputDevice = InputDevice.GetByIndex(comboBox1.SelectedIndex);
                _inputDevice.EventReceived += OnMidiEventReceived;
                _inputDevice.StartEventsListening();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetInputDevice();
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

        //CheckBoxes region
        #region 
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

            FillImages();
        }

        private void checkBox_C1_CheckStateChanged(object sender, EventArgs e)
        {
            FillImages();
        }

        private void checkBox_C2_CheckStateChanged(object sender, EventArgs e)
        {
            FillImages();
        }

        private void checkBox_C3_CheckStateChanged(object sender, EventArgs e)
        {
            FillImages();
        }

        private void checkBox_C4_CheckStateChanged(object sender, EventArgs e)
        {
            FillImages();
        }

        private void checkBox_C5_CheckStateChanged(object sender, EventArgs e)
        {
            FillImages();
        }

        private void checkBox_C6_CheckStateChanged(object sender, EventArgs e)
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
        #endregion

    }
}
