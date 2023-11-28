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
        private Connection conn;
        private Boolean sysRole = false;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormThemNhanVien()
        {
            InitializeComponent();
        }

        private void FormADD_Employee_Load(object sender, EventArgs e)
        {
            conn = new Connection(sysRole);
            conn.OpenConnection();
            comboBox_gioitinh.SelectedIndex = 0;
            string sql = "select maNV from NHAN_VIEN";
            comboBox_maNQL.DataSource = conn.getTable(sql);
            comboBox_maNQL.DisplayMember = "maNV";
            conn.CloseConnection();
        }
  
        //SAVE Button
        private void button_save_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
            string maNV = textBoxMaNV.Text.Trim();
            string hoTen = textBoxHoTen.Text.Trim();
            string sdt = textBoxSDT.Text.Trim();
            string gioiTinhValue = comboBox_gioitinh.SelectedItem.ToString();
            string maNQLValue = comboBox_maNQL.Text.Trim();
            DateTime ngaySinhValue = dateTimePicker_ngaysinh.Value;

            using (SqlCommand cmd = new SqlCommand("proc_ThemNhanVien", conn.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maNV", maNV));
                cmd.Parameters.Add(new SqlParameter("@hoTen", hoTen));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", ngaySinhValue));
                cmd.Parameters.Add(new SqlParameter("@gioiTinh", gioiTinhValue));
                cmd.Parameters.Add(new SqlParameter("@maNQL", maNQLValue));
               
                DialogResult rs = MessageBox.Show("Bạn có thêm nhân viên?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
            conn.CloseConnection();
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
