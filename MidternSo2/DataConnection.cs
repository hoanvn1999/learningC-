using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MidternSo2
{
    class DataConnection
    {
        SqlConnection con;
        public DataConnection()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Learning\learning C#\MidternSo2\QLBH.mdf;Integrated Security=True");
        }
        private void openConnection()
        {
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        private void closeConnection()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public DataTable getTable(string SQL)
        {
            openConnection();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, con);
            DataTable tb = new DataTable();
            closeConnection();
            adp.Fill(tb);
            return tb;
        }
        public void executeData(string SQL)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            cmd.ExecuteNonQuery();
            closeConnection();
        }
    }
}
