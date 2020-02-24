namespace PlayerMP4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftBar = new System.Windows.Forms.Panel();
            this.ListBookMarks = new System.Windows.Forms.ListBox();
            this.ButTable = new System.Windows.Forms.TableLayoutPanel();
            this.AddBM = new System.Windows.Forms.Button();
            this.DeleteBM = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.VideoOut = new System.Windows.Forms.Panel();
            this.FooterBar = new System.Windows.Forms.Panel();
            this.TimeLine = new System.Windows.Forms.TrackBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьВидеоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PlayPause = new System.Windows.Forms.Button();
            this.SyncTimeLab = new System.Windows.Forms.Timer(this.components);
            this.TimeView = new System.Windows.Forms.Label();
            this.LeftBar.SuspendLayout();
            this.ButTable.SuspendLayout();
            this.FooterBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLine)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftBar
            // 
            this.LeftBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeftBar.Controls.Add(this.ListBookMarks);
            this.LeftBar.Controls.Add(this.ButTable);
            this.LeftBar.Controls.Add(this.label1);
            this.LeftBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.LeftBar.Location = new System.Drawing.Point(631, 0);
            this.LeftBar.Name = "LeftBar";
            this.LeftBar.Size = new System.Drawing.Size(169, 450);
            this.LeftBar.TabIndex = 1;
            // 
            // ListBookMarks
            // 
            this.ListBookMarks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBookMarks.FormattingEnabled = true;
            this.ListBookMarks.Location = new System.Drawing.Point(0, 53);
            this.ListBookMarks.Name = "ListBookMarks";
            this.ListBookMarks.Size = new System.Drawing.Size(167, 395);
            this.ListBookMarks.TabIndex = 1;
            // 
            // ButTable
            // 
            this.ButTable.ColumnCount = 2;
            this.ButTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButTable.Controls.Add(this.AddBM, 0, 0);
            this.ButTable.Controls.Add(this.DeleteBM, 1, 0);
            this.ButTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButTable.Location = new System.Drawing.Point(0, 23);
            this.ButTable.Name = "ButTable";
            this.ButTable.RowCount = 1;
            this.ButTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButTable.Size = new System.Drawing.Size(167, 30);
            this.ButTable.TabIndex = 1;
            // 
            // AddBM
            // 
            this.AddBM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddBM.Location = new System.Drawing.Point(3, 3);
            this.AddBM.Name = "AddBM";
            this.AddBM.Size = new System.Drawing.Size(77, 24);
            this.AddBM.TabIndex = 0;
            this.AddBM.Text = "Добавить";
            this.AddBM.UseVisualStyleBackColor = true;
            // 
            // DeleteBM
            // 
            this.DeleteBM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteBM.Location = new System.Drawing.Point(86, 3);
            this.DeleteBM.Name = "DeleteBM";
            this.DeleteBM.Size = new System.Drawing.Size(78, 24);
            this.DeleteBM.TabIndex = 1;
            this.DeleteBM.Text = "Удалить";
            this.DeleteBM.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VideoOut
            // 
            this.VideoOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VideoOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoOut.Location = new System.Drawing.Point(0, 24);
            this.VideoOut.Name = "VideoOut";
            this.VideoOut.Size = new System.Drawing.Size(628, 395);
            this.VideoOut.TabIndex = 2;
            // 
            // FooterBar
            // 
            this.FooterBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FooterBar.Controls.Add(this.TimeLine);
            this.FooterBar.Controls.Add(this.PlayPause);
            this.FooterBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterBar.Location = new System.Drawing.Point(0, 419);
            this.FooterBar.Name = "FooterBar";
            this.FooterBar.Size = new System.Drawing.Size(628, 31);
            this.FooterBar.TabIndex = 3;
            // 
            // TimeLine
            // 
            this.TimeLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TimeLine.LargeChange = 1;
            this.TimeLine.Location = new System.Drawing.Point(75, 0);
            this.TimeLine.Name = "TimeLine";
            this.TimeLine.Size = new System.Drawing.Size(551, 29);
            this.TimeLine.TabIndex = 1;
            this.TimeLine.Scroll += new System.EventHandler(this.TimeLine_Scroll);
            this.TimeLine.ValueChanged += new System.EventHandler(this.TimeLine_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(628, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьВидеоToolStripMenuItem,
            this.открытьПроектToolStripMenuItem,
            this.сохранитьПроектToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьВидеоToolStripMenuItem
            // 
            this.открытьВидеоToolStripMenuItem.Name = "открытьВидеоToolStripMenuItem";
            this.открытьВидеоToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьВидеоToolStripMenuItem.Text = "Открыть видео";
            this.открытьВидеоToolStripMenuItem.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // открытьПроектToolStripMenuItem
            // 
            this.открытьПроектToolStripMenuItem.Name = "открытьПроектToolStripMenuItem";
            this.открытьПроектToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.открытьПроектToolStripMenuItem.Text = "Открыть проект";
            // 
            // сохранитьПроектToolStripMenuItem
            // 
            this.сохранитьПроектToolStripMenuItem.Name = "сохранитьПроектToolStripMenuItem";
            this.сохранитьПроектToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьПроектToolStripMenuItem.Text = "Сохранить проект";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Закладки";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(628, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // PlayPause
            // 
            this.PlayPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.PlayPause.Location = new System.Drawing.Point(0, 0);
            this.PlayPause.Name = "PlayPause";
            this.PlayPause.Size = new System.Drawing.Size(75, 29);
            this.PlayPause.TabIndex = 0;
            this.PlayPause.Text = "Пуск";
            this.PlayPause.UseVisualStyleBackColor = true;
            this.PlayPause.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // SyncTimeLab
            // 
            this.SyncTimeLab.Interval = 1000;
            this.SyncTimeLab.Tick += new System.EventHandler(this.SyncTimeLab_Tick);
            // 
            // TimeView
            // 
            this.TimeView.AutoSize = true;
            this.TimeView.Dock = System.Windows.Forms.DockStyle.Right;
            this.TimeView.ForeColor = System.Drawing.Color.Blue;
            this.TimeView.Location = new System.Drawing.Point(628, 24);
            this.TimeView.Name = "TimeView";
            this.TimeView.Size = new System.Drawing.Size(0, 13);
            this.TimeView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeView);
            this.Controls.Add(this.VideoOut);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.FooterBar);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.LeftBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.LeftBar.ResumeLayout(false);
            this.ButTable.ResumeLayout(false);
            this.FooterBar.ResumeLayout(false);
            this.FooterBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLine)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel LeftBar;
        private System.Windows.Forms.ListBox ListBookMarks;
        private System.Windows.Forms.TableLayoutPanel ButTable;
        private System.Windows.Forms.Button AddBM;
        private System.Windows.Forms.Button DeleteBM;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel VideoOut;
        private System.Windows.Forms.Panel FooterBar;
        private System.Windows.Forms.TrackBar TimeLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьВидеоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьПроектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button PlayPause;
        private System.Windows.Forms.Timer SyncTimeLab;
        private System.Windows.Forms.Label TimeView;
    }
}

