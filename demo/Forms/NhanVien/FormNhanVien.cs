using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace demo.Forms
{
    public partial class FormNhanVien : Form
    {
        private Connection conn;
        private Boolean sysRole = false;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormNhanVien()
        {
            InitializeComponent();
            conn = Connection.Instance(sysRole);

        }

        public void load_data_employ()
        {
            conn.OpenConnection();
            dataGridViewEmployees.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            string sql = "select * from V_DSNV";
            dataGridViewEmployees.DataSource = conn.getTable(sql);
            conn.CloseConnection();
        }
        private void FormEmployees_Load(object sender, EventArgs e)
        {
            LoadTheme(panelEdit);
            load_data_employ();
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
        private void dataGridViewEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonChinhsua.Enabled = true;
            buttonChinhsua.Font = new Font(buttonChinhsua.Font, FontStyle.Bold);
            buttonXoa.Enabled = true;
            buttonXoa.Font = new Font(buttonXoa.Font, FontStyle.Bold);
            int rowIndex = e.RowIndex;
            dataGridViewEmployees.Rows[rowIndex].Selected = true;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormThemNhanVien f = new FormThemNhanVien();
            f.FormClosed += new FormClosedEventHandler(FormADD_EmployeeClosed);
            f.ShowDialog();
        }
        private void FormADD_EmployeeClosed(object sender, FormClosedEventArgs e)
        {
            load_data_employ();
        }


        private void buttonChinhsua_Click(object sender, EventArgs e)
        {
            {
                string maNV = dataGridViewEmployees.CurrentRow.Cells[0].Value.ToString();
                string hoTen = dataGridViewEmployees.CurrentRow.Cells[1].Value.ToString();
                string sdt = dataGridViewEmployees.CurrentRow.Cells[2].Value.ToString();
                DateTime ngaySinh = Convert.ToDateTime(dataGridViewEmployees.CurrentRow.Cells[3].Value);
                string gioiTinh = dataGridViewEmployees.CurrentRow.Cells[4].Value.ToString();
                string maNQL = dataGridViewEmployees.CurrentRow.Cells[5].Value.ToString();

                // Tạo form con và truyền dữ liệu
                FormChinhSuaNhanVien f = new FormChinhSuaNhanVien();
                f.SetData(maNV, hoTen, sdt, ngaySinh, gioiTinh, maNQL);
                f.FormClosed += new FormClosedEventHandler(FormEDIT_EmployeeClosed);
                f.ShowDialog();
            }
        }
        private void FormEDIT_EmployeeClosed(object sender, FormClosedEventArgs e)
        {
            load_data_employ();
        }
        private void buttonXoa_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();

            string maNV = dataGridViewEmployees.CurrentRow.Cells[0].Value.ToString();
            using (SqlCommand cmd = new SqlCommand("proc_XoaNhanVien", conn.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNV", maNV));

               
                DialogResult rs = MessageBox.Show("Are you sure??", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công", "Successfull", MessageBoxButtons.OK);
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại!\n" + ex.Message, "Fail!!");
                    }

                }
            }
            conn.CloseConnection();
        }



        private void dataGridViewEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
