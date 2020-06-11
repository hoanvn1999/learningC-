using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace QLSV.App_Code
{
    public class DataConnection
    {
        SqlConnection con;
        public DataConnection()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Learning\learning C#\WindowsFormsApp1\QLSV\App_Data\SV.mdf;Integrated Security=True";
        }
        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public DataTable getTable(string SQL)
        {
            DataTable tb = new DataTable();
            this.OpenConnection();
            SqlDataAdapter adp = new SqlDataAdapter(SQL, this.con);
            adp.Fill(tb);
            this.CloseConnection();
            return tb;
        }

        public int executeSQL(string SQL)
        {
            this.OpenConnection();
            SqlCommand cmd = new SqlCommand(SQL, this.con);
            int k = (int)cmd.ExecuteNonQuery();
            this.CloseConnection();
            return k;
        }

        public object getValue(string SQL)
        {
            this.OpenConnection();
            SqlCommand cmd = new SqlCommand(SQL, this.con);
            object value = cmd.ExecuteScalar();
            this.CloseConnection();
            return value;
        }
    }
}