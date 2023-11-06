using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.Forms.Customer
{
    public partial class FormChinhSuaKhachHang : Form
    {
        public FormChinhSuaKhachHang()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
        private void FormEdit_Customer_Load(object sender, EventArgs e)
        {
            conn.openConnection();
            textBoxMaKH.ReadOnly = true;
        }

        public void SetData(string maNV, string hoTen, string sdt, DateTime ngaySinh)
        {
            textBoxMaKH.Text = maNV;
            textBoxHoTen.Text = hoTen;
            textBoxSDT.Text = sdt;
            dateTimePicker_ngaysinh.Value = ngaySinh;
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.getConnection.Open();

            string maNV = textBoxMaKH.Text.Trim();
            string hoTen = textBoxHoTen.Text.Trim();
            string sdt = textBoxSDT.Text.Trim();
            DateTime ngaySinhValue = dateTimePicker_ngaysinh.Value;

            using (SqlCommand cmd = new SqlCommand("proc_CapNhatKhachHang", connection.getConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", maNV));
                cmd.Parameters.Add(new SqlParameter("@tenKH", hoTen));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", ngaySinhValue)); // Sử dụng ngaySinhValue đã lấy ở trên

                int rowsAffected = cmd.ExecuteNonQuery();
                DialogResult rs = MessageBox.Show("Are you sure??", "Edit Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successful!!", "Edit Customer");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Fail!!");
                    }
                }
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
