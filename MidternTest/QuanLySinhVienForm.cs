using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidternTest
{
    public partial class QuanLySinhVienForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Learning\learning C#\MidternTest\dbQLSV.mdf;Integrated Security=True");
        public QuanLySinhVienForm()
        {
            InitializeComponent();
        }
        private void load()
        {
            try
            {
                DataTable tbSV = new DataTable();
                con.Open();
                SqlDataAdapter adp = new SqlDataAdapter("SELECT * FROM [SINHVIEN]", con);
                adp.Fill(tbSV);
                con.Close();
                grd_SinhVien.DataSource = tbSV;
            }
            catch (Exception) { MessageBox.Show("Lỗi hiển thị thông tin"); }
        }

        private void QuanLySinhVienForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imgLocation = dialog.FileName;
                    picture_Avata.ImageLocation = imgLocation;
                }
            }
            catch (Exception) { }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string SQL = "UPDATE [SINHVIEN] SET '" + txt_MaSV.Text + "N','" + txt_TenSV.Text + "',N'" + txt_DiaChi.Text + "',N'" + cbb_GioiTinh.Text + "','" + date_NgaySinh.Text + "','" + txt_DiemLT.Text + "','" + txt_DiemTH.Text + "','" + txt_DiemTB.Text + "',N'" + txt_XepLoai.Text + "'";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.ExecuteNonQuery();
            load();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string SQL = "INSERT INTO [SINHVIEN] VALUES('" + txt_MaSV.Text + "',N'" + txt_TenSV.Text + "',N'" + txt_DiaChi.Text + "',N'" + cbb_GioiTinh.Text + "','" + date_NgaySinh.Text + "','" + txt_DiemLT.Text + "','" + txt_DiemTH.Text + "','" + txt_DiemTB.Text + "',N'" + txt_XepLoai.Text + "'");
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.ExecuteNonQuery();
            load();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string SQL = "DELETE [SINHVIEN] WHERE MASINHVIEN = '" + txt_MaSV.Text + "'";
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.ExecuteNonQuery();
            load();
        }
    }
}
