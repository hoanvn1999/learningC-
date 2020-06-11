using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QLSV.App_Code;
using System.Runtime.Remoting.Channels;

namespace QLSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataConnection con;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sVDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.sVDataSet.SINHVIEN);
            con = new DataConnection();
            string SQL = "SELECT * FROM [SINHVIEN]";
            DataTable a = con.getTable(SQL);
            this.dataGridView2.DataSource = a;
        }
    }
}
