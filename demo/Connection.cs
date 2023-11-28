using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace demo
{
    public class Connection
    {
        private string _connectionString;

        private SqlConnection _connection;

        public Connection(bool sysRole)
        {
            if (sysRole)
            {
                _connectionString = "Data Source=.;Initial Catalog=ThietBiViTinh;User Id=sa;Password=1234567890;";
            }
            else
            {
                _connectionString = "Data Source=.;Initial Catalog=ThietBiViTinh;User Id=stafflogin;Password=nv123456;";
            }
            this._connection = new SqlConnection(_connectionString);
        }
        public void OpenConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection != null && _connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return _connection;
        }

        public DataTable getTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, _connection);
            CloseConnection();
            ds.Fill(dt);
            return dt;
        }
    }
}
