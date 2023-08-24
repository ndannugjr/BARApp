using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BARApp.uc
{
    public partial class ucSpeechControl : UserControl
    {

        private List<string> textList = new List<string>();
        public List<string> TextList
        {
            get { return textList; }
            set { textList = value; }
        }

        private bool _isMaleVoice = false;
        public bool IsMaleVoice { get { return _isMaleVoice; } set { _isMaleVoice = value; } }

        SpeechSynthesizer speechSynthesizerObj;
        private bool isPaused;
        public ucSpeechControl()
        {
            InitializeComponent();
        }

        private async void btnPlay_Click(object sender, EventArgs e)
        {
            if (TextList.Count > 0)
            {
                if (speechSynthesizerObj != null)
                {
                    if (speechSynthesizerObj.State == SynthesizerState.Speaking)
                    {
                        speechSynthesizerObj.SpeakAsyncCancelAll();
                    }
                }

                btnPause.Enabled = true;
                btnStop.Enabled = true;
                speechSynthesizerObj = new SpeechSynthesizer();
                if(!IsMaleVoice)
                speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
                else
                    speechSynthesizerObj.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);

                StartTextToSpeech(textList);
             
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                btnPlay.Enabled = false;
                btnStop.Enabled = false;
                speechSynthesizerObj.Pause();
                btnPause.Text = "Resume";
            }
            else
            {
                btnPlay.Enabled = true;
                btnStop.Enabled = true;
                speechSynthesizerObj.Resume();
                btnPause.Text = "Pause";
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (speechSynthesizerObj != null)
            {
                if (speechSynthesizerObj.State == SynthesizerState.Speaking)
                {
                    btnStop.Enabled = false;
                    btnPause.Enabled = false;
                    speechSynthesizerObj.SpeakAsyncCancelAll();
                }
            }
        }

        private void StartTextToSpeech(List<string> textList)
        {
            foreach (string text in textList)
            {
                if (speechSynthesizerObj.State != SynthesizerState.Speaking)
                {
                    speechSynthesizerObj.SpeakAsync(text);
                }
            }
        }
    }
}
