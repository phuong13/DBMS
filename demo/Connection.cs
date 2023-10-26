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
        public SqlConnection cnn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=ThietBiViTinh;Integrated Security=True");
        public void myconnect()
        {
            cnn.Open();
        }
        public void myClose()
        {
            cnn.Close();
        }

        public DataTable taoBang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, cnn);
            ds.Fill(dt);
            return dt;
        }
    }
}

