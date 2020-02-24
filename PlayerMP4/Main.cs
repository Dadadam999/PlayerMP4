using Microsoft.DirectX.AudioVideoPlayback;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerMP4
{
    public partial class Main : Form
    {

        Video video;
        VideoProject project;
        int CurrentPosition = 0, MaxPosition = 0;

        FileStream fStream;
        BinaryFormatter formatter;

        public Main()
        {
            InitializeComponent();
        }

        #region menu
        private void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "mp4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                init_video(openFileDialog1.FileName);
        }

        void init_video(string FileName)
        {
            try
            {
                video = new Video(FileName);
                video.Open(FileName);
                video.Owner = VideoOut;
                video.Ending += Video_Ending;

                CurrentPosition = Convert.ToInt32(video.CurrentPosition);
                MaxPosition = Convert.ToInt32(video.Duration);

                TimeLine.Minimum = 0;
                TimeLine.Maximum = MaxPosition;
                TimeLine.LargeChange = 1;

                project = new VideoProject(FileName);
                Text = project.Name;

                MessageBox.Show("Видео загружено. Для воспроизведения нажмите кнопку Пуск.");
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Открытие видео произошло с ошибкой: {exp}");
            }
        }

        private void открытьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "project files (*.pvb)|*.pvb";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(openFileDialog1.FileName);
                long size = file.Length;
                if (size > 0)
                {
                    fStream = new FileStream(openFileDialog1.FileName, FileMode.Open);
                    formatter = new BinaryFormatter();
                    project = (VideoProject)formatter.Deserialize(fStream);
                    fStream.Close();
                    if(File.Exists(project.FilePath))
                       init_video(project.FilePath);
                    else
                        MessageBox.Show("Исходный файл не найден по сохранненому пути.");
                }
                else 
                    MessageBox.Show("Файл пустой.");
            }
        }

        private void сохранитьПроектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "project files (*.pvb)|*.pvb";
            saveFileDialog1.FileName = project.Name;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                formatter = new BinaryFormatter();
                using (fStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    formatter.Serialize(fStream, project);
                    fStream.Close();
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region base function
        private void PlayPause_Click(object sender, EventArgs e)
        {
            if (video != null)
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

        private void SyncTimeLab_Tick(object sender, EventArgs e)
        {
            CurrentPosition = Convert.ToInt32(video.CurrentPosition);
            MaxPosition = Convert.ToInt32(video.Duration);

            TimeView.Text = string.Format("{0:00}:{1:00}:{2:00}", CurrentPosition / 3600, (CurrentPosition / 60) % 60, CurrentPosition % 60)
                            + " / " +
                            string.Format("{0:00}:{1:00}:{2:00}", MaxPosition / 3600, (MaxPosition / 60) % 60, MaxPosition % 60);

            TimeLine.Value = CurrentPosition;
        }

        private void TimeLine_Scroll(object sender, EventArgs e)
        {
            video.CurrentPosition = TimeLine.Value;
        }

        private void Video_Ending(object sender, EventArgs e)
        {
            video.Pause();
            PlayPause.Text = "Пуск";
            video.CurrentPosition = 0;
        }
        #endregion

        #region bookmarks function
        private void AddBM_Click(object sender, EventArgs e)
        {
            if (video != null && project != null) {
                project.Bookmarks.Add(new Bookmark("Закладка " + project.Bookmarks.Count + 1, video.CurrentPosition));
                update_list();
            } 
        }

        private void DeleteBM_Click(object sender, EventArgs e)
        {
            if (video != null && project != null)
            {
                if(ListBookmarks.Items[ListBookmarks.SelectedIndex] != null && project.Bookmarks.Count > 0)
                    project.Bookmarks.Remove(project.Bookmarks.Find(x => x.Name == ListBookmarks.Items[ListBookmarks.SelectedIndex].ToString()));
                update_list();
            }
        }

        private void EditBM_Click(object sender, EventArgs e)
        {
            if (video != null && project != null)
            {

                update_list();
            }
        }

        public void update_list() { 
        

        
        }
        #endregion
    }
}
