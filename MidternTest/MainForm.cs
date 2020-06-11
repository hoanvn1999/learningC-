using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidternTest
{
    public partial class MainForm : Form
    {
        Form_Login loginForm;
        QuanLySinhVienForm qlsv_Form;
        public MainForm()
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void quảnLíSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(qlsv_Form == null)
            {
                qlsv_Form = new QuanLySinhVienForm();
                qlsv_Form.FormClosed += new FormClosedEventHandler(QuanLySinhVienForm_FormClosed);
                qlsv_Form.MdiParent = this;
                qlsv_Form.Show();
            }
        }

        private void QuanLySinhVienForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            qlsv_Form = null;
        }
    }
}
