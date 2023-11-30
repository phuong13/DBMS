using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace demo
{
    public partial class FormTaiKhoan : Form
    {
        private Connection conn;
        private Boolean sysRole;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormTaiKhoan()
        {
            InitializeComponent();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void LoadTheme(Panel p)
        {
            foreach (Control btns in p.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormTaiKhoan_Load(object sender, EventArgs e)
        {
            conn = new Connection(sysRole);
            LoadTheme(panel_edit);
            Load_Datagridview();
        }
        private void Load_Datagridview()
        {
            String sql = "Select * from ACCOUNT";
            dg_taiKhoan.DataSource = conn.getTable(sql);
        }

        private void dg_taiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_sua.Enabled = true;
            btn_xoa.Enabled = true;

            int rowIndex = e.RowIndex;
            dg_taiKhoan.Rows[rowIndex].Selected = true;

            txt_username.Text = dg_taiKhoan.Rows[rowIndex].Cells["username"].FormattedValue.ToString();
            txt_password.Text = dg_taiKhoan.Rows[rowIndex].Cells["password"].FormattedValue.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
            string username = txt_username.Text;
            string password = txt_password.Text;
            Boolean isAdmin = check_isAdmin.Checked;
            using (SqlCommand cmd = new SqlCommand("proc_ThemTaiKhoan", conn.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@password", password));
                cmd.Parameters.Add(new SqlParameter("@isAdmin", isAdmin));

                DialogResult rs = MessageBox.Show("Thêm tài khoản?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công", "Successfull", MessageBoxButtons.OK);
                        Load_Datagridview();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại!\n" + ex.Message, "Fail!!");
                    }
                }

            }
            conn.CloseConnection();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
            string username = txt_username.Text;
            string password = txt_password.Text;
            using (SqlCommand cmd = new SqlCommand("proc_ChinhSuaTaiKhoan", conn.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@username", username));
                cmd.Parameters.Add(new SqlParameter("@password", password));
                DialogResult rs = MessageBox.Show("Bạn có muốn chỉnh sửa thông tin tài khoản?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Chỉnh sửa thành công", "Successfull", MessageBoxButtons.OK);
                        Load_Datagridview();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Chỉnh sửa thất bại!\n" + ex.Message, "Fail!!");
                    }
                }
            }
            conn.CloseConnection();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
            string username = txt_username.Text;
            using (SqlCommand cmd = new SqlCommand("proc_XoaTaiKhoan", conn.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@username", username));
                DialogResult rs = MessageBox.Show("Bạn có xóa tài khoản?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công", "Successfull", MessageBoxButtons.OK);
                        Load_Datagridview();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại!\n" + ex.Message, "Fail!!");
                    }
                }
            }
            conn.CloseConnection();
        }

        private void FormTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.CloseConnection();
        }

        private void check_isAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
