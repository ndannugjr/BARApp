
using System;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;
using NAudio.Wave;
using BAR.Core.Models;
using BAR.Core.Classes;
using System.Data.Entity.Core.Common;

namespace BARApp.uc
{
    public partial class ucVoiceCard : UserControl
    {


        private QuestionAnswer _model;
        public QuestionAnswer Model { get { return _model; } set { _model = value; } }

        private AudioFileReader audioFile;
        private WaveOutEvent outputDevice;
        private WaveInEvent waveIn;
        private WaveFileWriter writer;
        private string outputFilePath;
        private TimeSpan elapsedTime;
        private TimeSpan recordingElapsedTime;
        private bool isPlayback = false;
        bool isStopSignal = false;
        public ucVoiceCard(QuestionAnswer model)
        {
            InitializeComponent();
            _model = model;

            string basePath = AppContext.BaseDirectory;
            outputFilePath = System.IO.Path.Combine(basePath, "Recording");

            lblItem.Text = "Item #" + model.ItemNo.ToString();
            lblQuestion.Text = model.Value;

            if (model.ItemNo % 2 == 0)
                this.BackColor = Color.Azure;
            else
                this.BackColor = Color.White;
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            isPlayback = false;
            if (waveIn == null)
            {
                lblTimer.Text = "Ready...";
                for (int i = 0; i <= 5; i++)
                {
                    try
                    {
                        if (outputFilePath.Contains(".wav"))
                        {
                            File.Delete(outputFilePath);

                            string basePath = AppContext.BaseDirectory;
                            outputFilePath = System.IO.Path.Combine(basePath, "Recording");
                        }

                        break;
                    }
                    catch (Exception ex)
                    {
                        Thread.Sleep(1000);
                    }
                }


                waveIn = new WaveInEvent();
                waveIn.WaveFormat = new WaveFormat(44100, 1);
                waveIn.DataAvailable += WaveIn_DataAvailable;
                string fileName = string.Format("{0}_{1}.wav", RuntimeInfo.UserId, DateTime.Now.ToString("ddMMyyyyHHmmssff"));
                outputFilePath = System.IO.Path.Combine(outputFilePath, fileName);
                _model.StudentAnswer = outputFilePath;
                writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);
                recordingElapsedTime = new TimeSpan();
                waveIn.StartRecording();
                timer.Start();
                btnRecord.Text = "Stop";
            }
            else
            {
                timer.Enabled = false;
                waveIn.StopRecording();
                recordingElapsedTime = elapsedTime;
                waveIn.Dispose();
                writer.Close();
                writer.Dispose();
                waveIn = null;
                btnRecord.Text = "Retry";


                tableLayoutPanel1.BackColor = Color.LightGreen;

                lblItem.ForeColor = Color.Black;
                lblQuestion.ForeColor = Color.Black;
                btnPlay.ForeColor = Color.Black;
                btnRecord.ForeColor = Color.Black;

            }
        }


        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (writer != null)
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded);
                writer.Flush();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (waveIn == null)
            {
                elapsedTime = new TimeSpan();

                if (outputDevice == null || outputDevice.PlaybackState != PlaybackState.Playing)
                {
                    isPlayback = true;
                    string filePath = outputFilePath;
                    try
                    {
                        audioFile = new AudioFileReader(filePath);
                    }
                    catch
                    {
                        isPlayback = false;
                        timer.Enabled = false;
                        return;
                    }
                    outputDevice = new WaveOutEvent();
                    outputDevice.Init(audioFile);

                    outputDevice.Play();
                    timer.Start();
                    btnPlay.Text = "Stop";
                }
                else
                {
                    isPlayback = false;
                    timer.Enabled = false;
                    outputDevice.Stop();
                    audioFile.Dispose();
                    outputDevice.Dispose();
                    btnPlay.Text = "Play";
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1));

            if (!isStopSignal)
            {
                if (Convert.ToInt32(elapsedTime.ToString("ss")) % 2 == 0)
                    lblTimer.ForeColor = Color.DimGray;
                else
                    lblTimer.ForeColor = Color.Red;

                lblTimer.Text = elapsedTime.ToString(@"hh\:mm\:ss");
            }

            if (isPlayback)
            {
                if (isStopSignal)
                {
                    elapsedTime = new TimeSpan();
                    isPlayback = false;
                    isStopSignal = false;
                    timer.Enabled = false;
                    outputDevice.Stop();
                    audioFile.Dispose();
                    outputDevice.Dispose();
                    btnPlay.Text = "Play";
                    lblTimer.ForeColor = Color.DimGray;
                    return;
                }

                if (recordingElapsedTime == elapsedTime)
                    isStopSignal = true;
            }

        }
    }
}
