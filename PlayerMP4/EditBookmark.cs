using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerMP4
{
    public partial class EditBookmark : Form
    {
        Bookmark bm;
        public EditBookmark(Bookmark bookmark)
        {
            InitializeComponent();
            this.bm = bookmark;
            NameBookmark.Text = bm.Name;
            Position.Text = string.Format("{0:00}:{1:00}:{2:00}", bm.Position / 3600, (bm.Position / 60) % 60, bm.Position % 60);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Main.selfref.CheckCloneBM(NameBookmark.Text))
                MessageBox.Show("Закаладка с таким именем уже существует.");
            else if(!String.IsNullOrEmpty(NameBookmark.Text))
            {
                bm.Name = NameBookmark.Text;
                Main.selfref.UpdateList();
                Close();
            } else MessageBox.Show("Закаладка имеет пустое имя.");
        }
    }
}
