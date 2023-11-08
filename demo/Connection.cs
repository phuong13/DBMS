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
        SqlConnection cnn = new SqlConnection("Data Source=.;Initial Catalog=ThietBiViTinh;Persist Security Info=True;User ID=sa;Password=1234567890");
        public SqlConnection getConnection
        {
            get
            {
                return cnn;
            }
        }
        SqlConnection cnnAdmin = new SqlConnection("Data Source=.;Initial Catalog=ThietBiViTinh;Integrated Security=True");
        public SqlConnection getConnectionAdmin
        {
            get
            {
                return cnnAdmin;
            }
        }

        public void openConnection()
        {
            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
        }
        public void openConnectionAdmin()
        {
            if (cnnAdmin.State == ConnectionState.Closed)
            {
                cnnAdmin.Open();
            }
        }

        public void closeConnection()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
        public void closeConnectionAdmin()
        {
            if (cnnAdmin.State == ConnectionState.Open)
            {
                cnnAdmin.Close();
            }
        }
        public DataTable getTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, cnn);
            ds.Fill(dt);
            return dt;
        }
    }
}
