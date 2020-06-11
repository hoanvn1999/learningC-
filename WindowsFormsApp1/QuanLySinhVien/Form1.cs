using QLSV.App_Code;
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

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Learning\learning C#\WindowsFormsApp1\QuanLySinhVien\App_Data\SV.mdf;Integrated Security=True";
            DataTable tb = new DataTable();
            con.Open();
            SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM [SINHVIEN]", con);
            adp.Fill(tb);
            con.Close();
            grd_SV.DataSource = tb;
            grd_SV.Columns["MASINHVIEN"].HeaderText = "Mã sinh viên";
            grd_SV.Columns[1].HeaderText = "Tên sinh viên";
            grd_SV.Columns[2].HeaderText = "Địa chỉ";
            grd_SV.Columns[3].HeaderText = "Giới tính";
            grd_SV.Columns[3].HeaderText = "Điểm";
        }
    }
}
