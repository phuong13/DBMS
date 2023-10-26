using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.Forms
{
    public partial class FormEmployees : Form
    {
        public FormEmployees()
        {
            InitializeComponent();
           
        }
        Connection conn=new Connection();

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            LoadTheme(panelEdit);
            conn.myconnect();
            string sql = "select * from NHAN_VIEN";
            dataGridViewEmployees.DataSource = conn.taoBang(sql);
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
            if (e.ColumnIndex > 0 && e.RowIndex > 0)
            {
                textBoxMaNV.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[0].Value);
                textBoxHoTen.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[1].Value);
                textBoxSDT.Text= Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[2].Value);
                textBoxNgaySinh.Text = (dataGridViewEmployees.CurrentRow.Cells[3].Value as DateTime?)?.ToString("dd/MM/yyyy") ?? "";

                textBoxGioiTinh.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[4].Value);
                textBoxMaNQL.Text = Convert.ToString(dataGridViewEmployees.CurrentRow.Cells[5].Value);

            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {

        }

        private void buttonChinhsua_Click(object sender, EventArgs e)
        {

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
