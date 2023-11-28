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
    public partial class FormKhachHang : Form
    {
        private Connection conn;
        private Boolean sysRole = false;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormKhachHang()
        {
            InitializeComponent();
        }
        private void load_data_customer()
        {
            string sql = "select * from V_DSKH";
            dataGridViewCustomer.DataSource = conn.getTable(sql);
        }
        private void FormCustomer_Load(object sender, EventArgs e)
        {
            conn = new Connection(sysRole);
            LoadTheme(panelEdit);
            load_data_customer();
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

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonChinhsua.Enabled = true;
            buttonChinhsua.Font = new Font(buttonChinhsua.Font, FontStyle.Bold);
            buttonXoa.Enabled = true;
            buttonXoa.Font = new Font(buttonXoa.Font, FontStyle.Bold);
          
            int rowIndex = e.RowIndex;
            dataGridViewCustomer.Rows[rowIndex].Selected = true;
            
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormThemKhachHang f = new FormThemKhachHang();
            f.FormClosed += new FormClosedEventHandler(FormADD_CustomerClosed);
            f.ShowDialog();
        }
        private void FormADD_CustomerClosed(object sender, FormClosedEventArgs e)
        {
            load_data_customer();
        }


        private void buttonChinhsua_Click(object sender, EventArgs e)
        {
            string maNV = dataGridViewCustomer.CurrentRow.Cells[0].Value.ToString();
            string hoTen = dataGridViewCustomer.CurrentRow.Cells[1].Value.ToString();
            string sdt = dataGridViewCustomer.CurrentRow.Cells[3].Value.ToString();
            DateTime? ngaySinh = null;
            object ngaySinhValue = dataGridViewCustomer.CurrentRow.Cells[2].Value;
            if (ngaySinhValue != null && ngaySinhValue != DBNull.Value)
            {
                ngaySinh = Convert.ToDateTime(ngaySinhValue);
            }

            FormChinhSuaKhachHang f = new FormChinhSuaKhachHang();
            f.SetData(maNV, hoTen, sdt, ngaySinh ?? DateTime.MinValue);
            f.FormClosed += new FormClosedEventHandler(FormEDIT_CustomerClosed);
            f.ShowDialog();
        }
        private void FormEDIT_CustomerClosed(object sender, FormClosedEventArgs e)
        {
            load_data_customer();
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();

            string maKH = dataGridViewCustomer.CurrentRow.Cells[0].Value.ToString();
            using (SqlCommand cmd = new SqlCommand("proc_XoaKhachHang", conn.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", maKH));

       
                DialogResult rs = MessageBox.Show("Are you sure??", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa  thành công", "Successfull", MessageBoxButtons.OK);
                        load_data_customer();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại!\n" + ex.Message, "Fail!!");
                    }
                }
            }
            conn.CloseConnection();
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
