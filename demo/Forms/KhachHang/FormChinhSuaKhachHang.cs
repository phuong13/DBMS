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
        private Connection conn;
        private Boolean sysRole = false;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormChinhSuaKhachHang()
        {
            InitializeComponent();
            conn = Connection.Instance(sysRole);
        }
        private void FormEdit_Customer_Load(object sender, EventArgs e)
        {
            textBoxMaKH.ReadOnly = true;
        }

        public void SetData(string maNV, string hoTen, string sdt, DateTime? ngaySinh)
        {
            textBoxMaKH.Text = maNV;
            textBoxHoTen.Text = hoTen;
            textBoxSDT.Text = sdt;
            if (ngaySinh.HasValue && ngaySinh.Value != DateTime.MinValue)
            {
                dateTimePicker_ngaysinh.Value = ngaySinh.Value;
            }
            else
            {
                // Handle the case where ngaySinh is null or DateTime.MinValue
                // For example, you can set it to MinDate of the DateTimePicker
                dateTimePicker_ngaysinh.Value = dateTimePicker_ngaysinh.MinDate;
            }
            // EdateTimePicker_ngaysinh.Value = ngaySinh;
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();

            string maNV = textBoxMaKH.Text.Trim();
            string hoTen = textBoxHoTen.Text.Trim();
            string sdt = textBoxSDT.Text.Trim();
            DateTime ngaySinhValue = dateTimePicker_ngaysinh.Value;

            using (SqlCommand cmd = new SqlCommand("proc_CapNhatKhachHang", conn.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", maNV));
                cmd.Parameters.Add(new SqlParameter("@tenKH", hoTen));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", ngaySinhValue)); // Sử dụng ngaySinhValue đã lấy ở trên

               
                DialogResult rs = MessageBox.Show("Bạn có muốn chỉnh sửa thông tin khách hàng?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Chỉnh sửa thành công", "Successfull", MessageBoxButtons.OK);
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Chỉnh sửa thất bại!\n" + ex.Message, "Fail!!");
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
