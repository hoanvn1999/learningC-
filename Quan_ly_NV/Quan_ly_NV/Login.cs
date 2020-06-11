using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quan_ly_NV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Quan_ly_NV Quan_Ly_NV = new Quan_ly_NV(this);
            Quan_Ly_NV.Show();
            this.Hide();

            
            if (this.textBox_user.Text.ToUpper() == "admin".ToUpper() && this.textBox_password.Text == "ni")
            {
                Quan_Ly_NV.addmin = 1;
                
            }
            else
                if (this.textBox_user.Text.ToUpper() == "gues".ToUpper() && this.textBox_password.Text == "gues")
            {
                Quan_Ly_NV.addmin = 0;
            }
            else this.button_cancel_Click(this,e);

            Quan_Ly_NV.Show();
            this.Hide();



        }

        private void textBox_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
