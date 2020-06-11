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
    public partial class NhaCungCapForm : Form
    {
        public NhaCungCapForm()
        {
            InitializeComponent();
        }
        private void load()
        {
            DataConnection con = new DataConnection();
            try
            {
                grd_NCC.DataSource = con.getTable("SELECT * FROM [NHA_CUNG_CAP]");
            }
            catch (Exception) { MessageBox.Show("Lỗi hiển thị thông tin"); }
        }
        private void NhaCungCapForm_Load(object sender, EventArgs e)
        {
            load();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataConnection con = new DataConnection();
            
            try
            {
                con.executeData("INSERT INTO [NHA_CUNG_CAP] VALUES(" + txt_MaNCC.Text + ",N'" + txt_TenNCC.Text + "',N'" + txt_DiaChi.Text + "','" + txt_SDT.Text + "')");
            }
            catch (Exception) { MessageBox.Show("Lỗi thêm thông tin"); }
            load();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DataConnection con = new DataConnection();
            try
            {
                con.executeData("UPDATE [NHA_CUNG_CAP] SET " + txt_MaNCC.Text + ",N'" + txt_TenNCC.Text + "',N'" + txt_DiaChi.Text + "','" + txt_SDT.Text + "'");
            }
            catch (Exception) { MessageBox.Show("Lỗi sửa thông tin"); }
            load();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DataConnection con = new DataConnection();
            try
            {
                con.executeData("DELETE [NHA_CUNG_CAP] WHERE MA_NHACC = " + txt_MaNCC.Text);
            }
            catch (Exception) { MessageBox.Show("Lỗi xoá thông tin"); }
            load();
        }
        private void grd_Click(int index)
        {
            txt_MaNCC.Text = grd_NCC.Rows[index].Cells[0].Value.ToString();
            txt_TenNCC.Text = grd_NCC.Rows[index].Cells[1].Value.ToString();
            txt_DiaChi.Text = grd_NCC.Rows[index].Cells[2].Value.ToString();
            txt_SDT.Text = grd_NCC.Rows[index].Cells[3].Value.ToString();
        }
        private void grd_NCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grd_Click(grd_NCC.CurrentRow.Index);
        }
    }
}
