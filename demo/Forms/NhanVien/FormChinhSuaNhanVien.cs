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

namespace demo.Forms
{
    public partial class FormChinhSuaNhanVien : Form
    {
        private Connection conn;
        private Boolean sysRole = false;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormChinhSuaNhanVien()
        {
            InitializeComponent();
        }

        private void FormEdit_Employee_Load(object sender, EventArgs e)
        {
            conn = new Connection(sysRole);
            textBoxMaNV.ReadOnly = true;
        }

        public void SetData(string maNV, string hoTen, string sdt, DateTime ngaySinh, string gioiTinh, string maNQL)
        {
            textBoxMaNV.Text = maNV;
            textBoxHoTen.Text = hoTen;
            textBoxSDT.Text = sdt;
            dateTimePicker_ngaysinh.Value = ngaySinh;
            comboBox_gioitinh.SelectedItem = gioiTinh;
            textBoxmaNQL.Text = maNQL;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
            string maNV = textBoxMaNV.Text.Trim();
            string hoTen = textBoxHoTen.Text.Trim();
            string sdt = textBoxSDT.Text.Trim();
            string gioiTinhValue = comboBox_gioitinh.SelectedItem.ToString();
            string maNQLValue = textBoxmaNQL.Text.Trim();
            DateTime ngaySinhValue = dateTimePicker_ngaysinh.Value;

            using (SqlCommand cmd = new SqlCommand("proc_ChinhSuaNhanVien", conn.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maNV", maNV));
                cmd.Parameters.Add(new SqlParameter("@hoTen", hoTen));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", ngaySinhValue)); // Sử dụng ngaySinhValue đã lấy ở trên
                cmd.Parameters.Add(new SqlParameter("@gioiTinh", gioiTinhValue)); // Sử dụng gioiTinhValue đã lấy ở trên
                cmd.Parameters.Add(new SqlParameter("@maNQL", maNQLValue)); // Sử dụng maNQLValue đã lấy ở trên
                
                DialogResult rs = MessageBox.Show("Bạn có muốn chỉnh sửa thông tin nhân viên?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
