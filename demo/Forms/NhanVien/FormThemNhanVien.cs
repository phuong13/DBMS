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
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();

        private void FormADD_Employee_Load(object sender, EventArgs e)
        {
            conn.openConnection();
            comboBox_gioitinh.SelectedIndex = 0;
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
        //SAVE Button
        private void button_save_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.getConnection.Open();
            //check sdt 10 so 
            if (textBoxSDT.Text.Length != 10 || !IsAllDigits(textBoxSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập 10 số.");
                return;
            }

            // Kiểm tra tuổi
            int age = DateTime.Now.Year - dateTimePicker_ngaysinh.Value.Year;
            if (dateTimePicker_ngaysinh.Value > DateTime.Now.AddYears(-age))
            {
                age--;
            }
            if (age < 18)
            {
                MessageBox.Show("Bạn phải ít nhất 18 tuổi để thực hiện thao tác này.");
                return;
            }

            string maNV = textBoxMaNV.Text.Trim();
            string hoTen = textBoxHoTen.Text.Trim();
            string sdt = textBoxSDT.Text.Trim();
            string gioiTinhValue = comboBox_gioitinh.SelectedItem.ToString();
            string maNQLValue = textBoxmaNQL.Text.Trim();
            DateTime ngaySinhValue = dateTimePicker_ngaysinh.Value;

            using (SqlCommand cmd = new SqlCommand("proc_ThemNhanVien", connection.getConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maNV", maNV));
                cmd.Parameters.Add(new SqlParameter("@hoTen", hoTen));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", ngaySinhValue));
                cmd.Parameters.Add(new SqlParameter("@gioiTinh", gioiTinhValue));
                cmd.Parameters.Add(new SqlParameter("@maNQL", maNQLValue));
                int rowsAffected = cmd.ExecuteNonQuery();
                DialogResult rs = MessageBox.Show("Are you sure??", "Add Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successful!!");
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
