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
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                try
                {     
                    video = new Video(openFileDialog1.FileName);
                    video.Open(openFileDialog1.FileName);
                    video.Owner = VideoOut;
                    video.Play();
                } catch (Exception exp) { MessageBox.Show($"Открытие видео произошло с ошибкой: {exp}"); }
            }
        }
    }
}
