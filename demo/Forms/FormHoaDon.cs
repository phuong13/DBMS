using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.Forms
{
    public partial class FormHoaDon : Form
    {
        public FormHoaDon()
        {
            InitializeComponent();
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
        Connection conn =new Connection();
        void load_data_hoadon()
        {
            string sql = "select * from V_XemHoaDon";
            DataTable dt = conn.getTable(sql);        
            dataGridViewHoaDon.DataSource = dt;
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadTheme(panelEdit);
            load_data_hoadon();
        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            dataGridViewHoaDon.Rows[rowIndex].Selected = true;
        }
    }
}
