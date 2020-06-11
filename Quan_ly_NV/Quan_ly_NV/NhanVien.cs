using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_ly_NV
{
    public partial class NhanVien : Form
    {
        private Quan_ly_NV Quan_ly_NV;
        public NhanVien(Quan_ly_NV Quan_ly_NV)
        {
            InitializeComponent();
            this.Quan_ly_NV = Quan_ly_NV;
        }

        private void textBox_manhanvien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
