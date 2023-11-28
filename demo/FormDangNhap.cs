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
    public partial class FormDangNhap : Form
    {
        private Connection conn = new Connection(true);

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
            DataTable dt = conn.getTable($"select * from ACCOUNT Where username = '{txt_username.Text}' " +
                $"and password='{txt_password.Text}'");
            if (dt.Rows.Count > 0)
            {
                Boolean fSysRole = false;
                if (txt_username.Text == "sa") fSysRole = true;
                    
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                FormMainMenu f = new FormMainMenu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), fSysRole);
                f.Show();
                this.Hide();
                f.Logout += Form_Logout;
            } else
            {
                MessageBox.Show("Đăng nhập thất bại!\nTên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            conn.CloseConnection();
        }

        private void Form_Logout(object sender, EventArgs e)
        {
            (sender as FormMainMenu).isExit = false;
            (sender as FormMainMenu).Close();
            this.Show();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void txt_password_IconRightClick(object sender, EventArgs e)
        {
            if (txt_password.UseSystemPasswordChar)
            {
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_password.UseSystemPasswordChar = true;
            }
        }
        
    }
}
