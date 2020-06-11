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
    public partial class Quan_ly_NV : Form
    {
        private Login Login;
        public Quan_ly_NV(Login login)
        {
            InitializeComponent();
            this.Login = Login;
        }
        public int addmin = 0;
        public static SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Winform\BichNi\SQL\Quan_ly_NV\Quan_ly_NV\Quan_ly_NV.mdf;Integrated Security=True");
        int index = 0;
        DataTable dataTable;
        //-------------------------------------
        public void Execute_Query(string query)
        {
            try
            {
                connect.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connect);
                int k = sqlCommand.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception) { MessageBox.Show("Error query !!!"); }
        }
        //Kiem tra khoa
        private bool Check_Key(string sql, string key)
        {
            bool ok = false;
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataReader data = command.ExecuteReader();
                if (data.Read() && (data.GetString(0).ToUpper() == key.ToUpper())) ok = true;
                connect.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error check_key !!!", "C# Programing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ok;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Login.Close();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NhanVien NhanVien = new NhanVien(this);
            NhanVien.Show();
            this.Hide();
        }

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phong_ban Phong_ban = new Phong_ban(this);
            Phong_ban.Show();
            this.Hide();
        }
        //---------------------------------
        private void View_database(int index)
        {
            try
            {
                this.textBox_maphongban.Text = dataTable.Rows[index][0].ToString();
                this.textBox_tenphongban.Text = dataTable.Rows[index][1].ToString();
                this.textBox_tentruongphong.Text = dataTable.Rows[index][2].ToString();
                string sql = "SELECT * FROM Quan_ly_NV WHERE (maphongban = '" + this.textBox_maphongban.Text + "')";
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable data_table = new DataTable();
                dataAdapter.Fill(data_table);
                connect.Close();
                this.dataGridView.DataSource = data_table;
            }
            catch (Exception)
            {
                MessageBox.Show("Error !!!", "C# Programing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //------------------------------------
        private void Quan_ly_NV_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Phong_ban";
            try {
                connect.Open();
                SqlCommand command = new SqlCommand(sql, connect);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable data_table = new DataTable();
                dataAdapter.Fill(data_table);
                connect.Close();
                index = 0;
                if (data_table.Rows.Count > 0) View_database(index);
            }
            catch (Exception)
            {
                MessageBox.Show("Error !!!", "C# Programing", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            try
            {
                if (index < dataTable.Rows.Count - 1)
                {
                    index++;
                    View_database(index);
                }
                else MessageBox.Show("Đx quá bản ghi cuối", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Information);
       
            }
            catch (Exception)
            {
                MessageBox.Show("Error !!!", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_pre_Click(object sender, EventArgs e)
        {
            try
            {
                if (index > 0)
                {
                    index--;
                    View_database(index);
                }
                else MessageBox.Show("Đã quá bản ghi đầu", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Error !!! ", "C# Programming", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //--------------------
        private void button_last_Click(object sender, EventArgs e)
        {
            index = dataTable.Rows.Count - 1;
            View_database(index);
        }

        private void button_first_Click(object sender, EventArgs e)
        {
            index = 0;
            View_database(index);
        }

        private void textBox_maphongban_TextChanged(object sender, EventArgs e)
        {

        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //----------------------------------






    }

    }
    //-------------------------------------

