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
    public partial class DanhMucHangForm : Form
    {
        public DanhMucHangForm()
        {
            InitializeComponent();
        }

        private void DanhMucHangForm_Load(object sender, EventArgs e)
        {
            DataConnection con = new DataConnection();
            try
            {
                grd_TTMH.DataSource = con.getTable("SELECT * FROM [DANH_MUC_HANG]");
            }
            catch (Exception) { MessageBox.Show("Lỗi hiển thị thông tin"); }
        }
    }
}
