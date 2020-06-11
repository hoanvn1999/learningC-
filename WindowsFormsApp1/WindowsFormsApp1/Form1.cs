using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tb_a.Text == "" || tb_b.Text == "" || tb_a_mau.Text == "" || tb_b_mau.Text == "" || tb_a_mau.Text == "0" || tb_b_mau.Text == "0")
                MessageBox.Show("Sai dữ liệu");
            else
            {
                try
                {
                    if (signal.Text == "+")
                    {
                        tb_c.Text = (Double.Parse(tb_a.Text) * Double.Parse(tb_b_mau.Text) + Double.Parse(tb_b.Text) * Double.Parse(tb_a_mau.Text)).ToString();
                        tb_c_mau.Text = (Double.Parse(tb_a_mau.Text) * Double.Parse(tb_b_mau.Text)).ToString();
                    }
                    else if (signal.Text == "-")
                    {
                        tb_c.Text = (Double.Parse(tb_a.Text) * Double.Parse(tb_b_mau.Text) - Double.Parse(tb_b.Text) * Double.Parse(tb_a_mau.Text)).ToString();
                        tb_c_mau.Text = (Double.Parse(tb_a_mau.Text) * Double.Parse(tb_b_mau.Text)).ToString();
                    }                       
                    else if (signal.Text == "*")
                    {
                        tb_c.Text = (Double.Parse(tb_a.Text) * Double.Parse(tb_b.Text)).ToString();
                        tb_c_mau.Text = (Double.Parse(tb_a_mau.Text) * Double.Parse(tb_b_mau.Text)).ToString();
                    }
                    else
                    {
                        tb_c.Text = (Double.Parse(tb_a.Text) * Double.Parse(tb_b_mau.Text)).ToString();
                        tb_c_mau.Text = (Double.Parse(tb_a_mau.Text) * Double.Parse(tb_b.Text)).ToString();
                    }
                    tb_c.Text = (Int16.Parse(tb_c.Text) / gcd(Int16.Parse(tb_c.Text), Int16.Parse(tb_c_mau.Text))).ToString();
                    tb_c_mau.Text = (Int16.Parse(tb_c_mau.Text) / gcd(Int16.Parse(tb_c.Text), Int16.Parse(tb_c_mau.Text))).ToString();
                }
                catch (Exception ){
                    MessageBox.Show("Vui lòng nhập đúng định dạng");
                }
            }
        }
        public int gcd(int a, int b)
        {
            // Nếu a = 0 => ucln(a,b) = b
            // Nếu b = 0 => ucln(a,b) = a
            if (a == 0 || b == 0)
            {
                return a + b;
            }
            while (a != b)
            {
                if (a > b)
                {
                    a -= b; // a = a - b
                }
                else
                {
                    b -= a;
                }
            }
            return a; // return a or b, bởi vì lúc này a và b bằng nhau
        }
    }
}
