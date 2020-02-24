using Microsoft.DirectX.AudioVideoPlayback;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerMP4 {
    public partial class Form1 : Form {

        Video video;
        int CurrentPosition = 0, MaxPosition = 0;
        public Form1() {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                try
                {     
                    video = new Video(openFileDialog1.FileName);
                    video.Open(openFileDialog1.FileName);
                    video.Owner = VideoOut;
                    video.Ending += Video_Ending;

                    PlayPause.PerformClick();

                    CurrentPosition = Convert.ToInt32(video.CurrentPosition);
                    MaxPosition = Convert.ToInt32(video.Duration);

                    TimeLine.Minimum = 0;
                    TimeLine.Maximum = MaxPosition;
                    TimeLine.LargeChange = 1;

                    MessageBox.Show("Видео загружено. Нажмите кнопку Пуск.");

                } catch (Exception exp) { MessageBox.Show($"Открытие видео произошло с ошибкой: {exp}"); }
            }
        }

        private void Video_Ending(object sender, EventArgs e) {
            video.Pause();
            PlayPause.Text = "Пуск";
            video.CurrentPosition = 0;
        }

        private void PlayPause_Click(object sender, EventArgs e)
        {
            if (PlayPause.Text == "Пуск")
            {
                video.Play();
                SyncTimeLab.Start();
                PlayPause.Text = "Пауза";
            }
            else
            {
                video.Pause();
                SyncTimeLab.Stop();
                PlayPause.Text = "Пуск";
            }
        }

        private void TimeLine_Scroll(object sender, EventArgs e)
        {
            video.CurrentPosition = TimeLine.Value;
        }

        private void TimeLine_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SyncTimeLab_Tick(object sender, EventArgs e)
        {
            CurrentPosition = Convert.ToInt32(video.CurrentPosition);
            MaxPosition = Convert.ToInt32(video.Duration);

            TimeView.Text = string.Format("{0:00}:{1:00}:{2:00}", CurrentPosition / 3600, (CurrentPosition / 60) % 60, CurrentPosition % 60)
                            + " / " +
                            string.Format("{0:00}:{1:00}:{2:00}", MaxPosition / 3600, (MaxPosition / 60) % 60, MaxPosition % 60);

            TimeLine.Value = CurrentPosition;
        }
    }
}
