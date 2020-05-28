using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    public partial class main_Form : Form
    {
        sub_Form a;
        public main_Form()
        {
            InitializeComponent();
        }

        private void openFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openSubFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(a == null)
            {
                a = new sub_Form();
                a.FormClosed += new FormClosedEventHandler(sub_Form_FormClosed); 
                a.MdiParent = this;
                a.Show();
            }
        }
        private void sub_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            a = null;
        }
    }
}
