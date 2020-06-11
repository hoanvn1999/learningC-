using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidternTest
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Learning\learning C#\MidternTest\dbQLSV.mdf;Integrated Security=True");
                DataTable tbSV = new DataTable();
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM [USER] WHERE USER_NAME='"+txt_Username.Text+"' AND PASSWORD='"+txt_password.Text+"'", con);
                adp.Fill(tbSV);
                con.Close();
                if (tbSV.Rows.Count > 0)
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
            }
            catch (Exception) { MessageBox.Show("Lỗi hiển thị thông tin"); }
            
        }
    }
}
