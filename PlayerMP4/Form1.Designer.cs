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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftBar = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.VideoOut = new System.Windows.Forms.Panel();
            this.Bar = new System.Windows.Forms.Panel();
            this.ContolVideo = new System.Windows.Forms.Panel();
            this.TimeLine = new System.Windows.Forms.TrackBar();
            this.LeftBar.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLine)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftBar
            // 
            this.LeftBar.Controls.Add(this.listBox1);
            this.LeftBar.Controls.Add(this.tableLayoutPanel1);
            this.LeftBar.Controls.Add(this.button1);
            this.LeftBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.LeftBar.Location = new System.Drawing.Point(631, 0);
            this.LeftBar.Name = "LeftBar";
            this.LeftBar.Size = new System.Drawing.Size(169, 450);
            this.LeftBar.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(169, 397);
            this.listBox1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 23);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(169, 30);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 24);
            this.button2.TabIndex = 0;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(87, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 24);
            this.button3.TabIndex = 1;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Открыть файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VideoOut
            // 
            this.VideoOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VideoOut.Location = new System.Drawing.Point(0, 0);
            this.VideoOut.Name = "VideoOut";
            this.VideoOut.Size = new System.Drawing.Size(631, 350);
            this.VideoOut.TabIndex = 2;
            // 
            // Bar
            // 
            this.Bar.Controls.Add(this.ContolVideo);
            this.Bar.Controls.Add(this.TimeLine);
            this.Bar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bar.Location = new System.Drawing.Point(0, 350);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(631, 100);
            this.Bar.TabIndex = 3;
            // 
            // ContolVideo
            // 
            this.ContolVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContolVideo.Location = new System.Drawing.Point(0, 45);
            this.ContolVideo.Name = "ContolVideo";
            this.ContolVideo.Size = new System.Drawing.Size(631, 55);
            this.ContolVideo.TabIndex = 0;
            // 
            // TimeLine
            // 
            this.TimeLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimeLine.Location = new System.Drawing.Point(0, 0);
            this.TimeLine.Name = "TimeLine";
            this.TimeLine.Size = new System.Drawing.Size(631, 45);
            this.TimeLine.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VideoOut);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.LeftBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.LeftBar.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Bar.ResumeLayout(false);
            this.Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel LeftBar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel VideoOut;
        private System.Windows.Forms.Panel Bar;
        private System.Windows.Forms.Panel ContolVideo;
        private System.Windows.Forms.TrackBar TimeLine;
    }
}

