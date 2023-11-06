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

        public FormChinhSuaNhanVien()
        {
            InitializeComponent();
        }

        Connection conn = new Connection();
        private void FormEdit_Employee_Load(object sender, EventArgs e)
        {
            conn.openConnection();
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
            Connection connection = new Connection();
            connection.getConnection.Open();

            string maNV = textBoxMaNV.Text.Trim();
            string hoTen = textBoxHoTen.Text.Trim();
            string sdt = textBoxSDT.Text.Trim();
            string gioiTinhValue = comboBox_gioitinh.SelectedItem.ToString();
            string maNQLValue = textBoxmaNQL.Text.Trim();
            DateTime ngaySinhValue = dateTimePicker_ngaysinh.Value;

            using (SqlCommand cmd = new SqlCommand("proc_ChinhSuaNhanVien", connection.getConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maNV", maNV));
                cmd.Parameters.Add(new SqlParameter("@hoTen", hoTen));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", ngaySinhValue)); // Sử dụng ngaySinhValue đã lấy ở trên
                cmd.Parameters.Add(new SqlParameter("@gioiTinh", gioiTinhValue)); // Sử dụng gioiTinhValue đã lấy ở trên
                cmd.Parameters.Add(new SqlParameter("@maNQL", maNQLValue)); // Sử dụng maNQLValue đã lấy ở trên
                int rowsAffected = cmd.ExecuteNonQuery();
                DialogResult rs = MessageBox.Show("Are you sure??", "Edit Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successful!!", "Edit Nhân Viên");
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
