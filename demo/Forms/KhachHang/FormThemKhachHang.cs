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
    public partial class FormThemKhachHang : Form
    {
        private Connection conn;
        private Boolean sysRole = false;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormThemKhachHang()
        {
            InitializeComponent();
        }


        private void FormADD_Customer_Load(object sender, EventArgs e)
        {
            conn = new Connection(sysRole);
        }
        private bool IsAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
            string maNV = textBoxMaKH.Text.Trim();
            string hoTen = textBoxHoTen.Text.Trim();
            string sdt = textBoxSDT.Text.Trim();
            DateTime ngaySinhValue = dateTimePicker_ngaysinh.Value;

            using (SqlCommand cmd = new SqlCommand("proc_ThemKhachHang", conn.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", maNV));
                cmd.Parameters.Add(new SqlParameter("@tenKH", hoTen));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", ngaySinhValue));

               
                DialogResult rs = MessageBox.Show("Bạn có muốn thêm khách hàng?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công", "Successfull", MessageBoxButtons.OK);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại!\n" + ex.Message, "Fail!!");
                    }
                }
            }
            conn.CloseConnection();
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
