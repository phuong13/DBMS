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
            string sql = "select maNV from NHAN_VIEN";
            comboBox_maNQL.DataSource = conn.getTable(sql);
            comboBox_maNQL.DisplayMember = "maNV";
        }
  
        //SAVE Button
        private void button_save_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.getConnection.Open();

            string maNV = textBoxMaNV.Text.Trim();
            string hoTen = textBoxHoTen.Text.Trim();
            string sdt = textBoxSDT.Text.Trim();
            string gioiTinhValue = comboBox_gioitinh.SelectedItem.ToString();
            string maNQLValue = comboBox_maNQL.Text.Trim();
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
               
                DialogResult rs = MessageBox.Show("Are you sure??", "Add Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công", "Successfull", MessageBoxButtons.OK);
                        this.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Thêm thất bại!\n" + ex.Message, "Fail!!");
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
