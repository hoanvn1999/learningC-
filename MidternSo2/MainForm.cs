using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidternSo2
{
    public partial class MainForm : Form
    {
        NhaCungCapForm ncc;
        DanhMucHangForm dmh;
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhMụcHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dmh == null)
            {
                dmh = new DanhMucHangForm();
                dmh.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DanhMucHangForm_FormClosed);
                dmh.MdiParent = this;
                dmh.Show();
            }
        }
        private void DanhMucHangForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            dmh = null;
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ncc == null)
            {
                ncc = new NhaCungCapForm();
                ncc.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DanhMucHangForm_FormClosed);
                ncc.MdiParent = this;
                ncc.Show();
            }
        }
        private void NhaCungCapForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ncc = null;
        }
    }
}
