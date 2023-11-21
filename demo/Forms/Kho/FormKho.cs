using demo.Forms.Customer;
using demo.Forms.Kho;
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
    public partial class FormKho : Form
    {
        private Connection conn;
        private Boolean sysRole = false;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormKho()
        {
            InitializeComponent();
            conn = Connection.Instance(sysRole);
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
        private void load_data_phieuNhap()
        {
            string sql = "select * from V_Kho";
            DataTable dt = conn.getTable(sql);
            dataGridViewKho.DataSource = dt;
        }
        private void FormStock_Load(object sender, EventArgs e)
        {
            LoadTheme(panelEdit);
            load_data_phieuNhap();
        }

        private void dataGridViewKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            dataGridViewKho.Rows[rowIndex].Selected = true;
        }

        private void dataGridViewKho_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.OpenConnection();
            string maPhieuNhap = dataGridViewKho.CurrentRow.Cells[0].Value.ToString();
            using (SqlCommand cmd = new SqlCommand("select * from func_XemPhieuNhapThietBi(@maPhieuNhap)", conn.getConnection()))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@maPhieuNhap", maPhieuNhap));
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridViewKho.DataSource=dataTable;
            }
            conn.CloseConnection();
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            load_data_phieuNhap();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormThemPhieuNhap f = new FormThemPhieuNhap();
            f.FormClosed += new FormClosedEventHandler(FormThem_PhieuNhapClosed);
            f.ShowDialog();
        }
        private void FormThem_PhieuNhapClosed(object sender, FormClosedEventArgs e)
        {
            load_data_phieuNhap();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {

        }
    }
}
