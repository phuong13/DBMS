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
        private Connection conn;
        private Boolean sysRole = true;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = conn.getTable($"select * from ACCOUNT Where username = '{txt_username.Text}' " +
                $"and password='{txt_password.Text}'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                FormMainMenu f = new FormMainMenu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString());
                f.Show();
                this.Hide();
                f.Logout += Form_Logout;
            } else
            {
                MessageBox.Show("Đăng nhập thất bại!\nTên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

            conn = Connection.Instance(sysRole);
        }
    }
}
