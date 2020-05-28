using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Sub_Form
{
    public partial class form_Sub1 : Form
    {
        private form_Main mainForm;
        public form_Sub1()
        {
            InitializeComponent();
        }

        private void btn_Form_1_Click(object sender, EventArgs e)
        {
            this.mainForm.Show();
            this.Close();
        }
    }
}
