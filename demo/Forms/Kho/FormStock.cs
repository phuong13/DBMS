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
    public partial class FormStock : Form
    {
        public FormStock()
        {
            InitializeComponent();
        }

        Connection conn = new Connection();
        public void load_data_stock()
        {
            dataGridViewStock.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
            string sql = "select * from V_Stock";
            dataGridViewStock.DataSource = conn.getTable(sql);
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
        private void FormStock_Load(object sender, EventArgs e)
        {
            LoadTheme(panel1);
            conn.openConnection();
            load_data_stock();
        }
        

        private void button_add_Click(object sender, EventArgs e)
        {
            FormAddStock f = new FormAddStock();
            f.FormClosed += new FormClosedEventHandler(FormADD_StockClosed);
            f.ShowDialog();
        }

        private void FormADD_StockClosed(object sender, FormClosedEventArgs e)
        {
            load_data_stock();
        }


    }
}
