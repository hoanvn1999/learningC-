using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Message
{
    public partial class subForm : Form
    {
        private Fo_Message mainForm = new Fo_Message();
        public subForm(/*Fo_Message mainForm*/)
        {
            InitializeComponent();
            //this.mainForm = mainForm;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void btn_Out_Click(object sender, EventArgs e)
        {
            mainForm.Close();
        }
    }
}
