using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
   public class Connection
    {

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=ThietBiViTinh;Integrated Security=True");
        public SqlConnection getConnection
        {
            get
            {
                return conn;
            }
        }

        public void openConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable getTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, conn);
            ds.Fill(dt);
            return dt;
        }
    }
}

