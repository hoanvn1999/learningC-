using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTB2
{
    public partial class PTB2 : Form
    {
        public PTB2()
        {
            InitializeComponent();
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            double a, b, c;
            try
            {
                a = double.Parse(txt_a.Text);
                b = double.Parse(txt_b.Text);
                c = double.Parse(txt_c.Text);
                Phuong_trinh P = new Phuong_trinh(a, b, c);
                lb_kq.Visible = true;
                switch (P.giai_Pt())
                {
                    case 0:
                        lb_kq.Text = "Phương trình vô số nghiệm";
                        break;
                    case 1:
                        lb_kq.Text = "Phương trình vô nghiệm";
                        break;
                    case 2:
                        lb_kq.Text = "x = " + P.X;
                        break;
                    case 3:
                        lb_kq.Text = "Phương trình có nghiệm phức\n\tx1 = " + (-(P.B / (2 * P.A))) + " + i * " + (P.Delta / (2 * P.A)) + "\n\tx2 = " + (-(P.B / (2 * P.A))) + " - i * " + (P.Delta / (2 * P.A));
                        break;
                    case 4:
                        lb_kq.Text = "Phương trình có nghiệm kép\n\tx = " + -(P.B / (2 * P.A));
                        break;
                    case 5:
                        lb_kq.Text = "x1 = " + P.X1 + "\nx2 = " + P.X2;
                        break;
                    default:
                        MessageBox.Show("Vui lòng nhập đúng");
                        break;
                }
            }
            catch (Exception)
            {
                lb_kq.Text = "Vui lòng nhập đúng định dạng";
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_a.Text = "";
            txt_b.Text = "";
            txt_c.Text = "";
            lb_kq.Text = "";
            lb_kq.Visible = false;
        }
    }
}
