﻿using System;
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
    public partial class FormDoanhThu : Form
    {
        private Connection conn;
        private Boolean sysRole = false;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormDoanhThu()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
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
        private void FormAccount_Load(object sender, EventArgs e)
        {
            conn = new Connection(sysRole);
            LoadTheme();
        }

        private void btn_XemDoanhThu_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
            DateTime startDate = dateTimePicker_start.Value;
            DateTime endDate = dateTimePicker_end.Value;
            using (SqlCommand command = new SqlCommand("SELECT dbo.func_DoanhThu(@startDate, @endDate)", conn.getConnection()))
            {
                command.Parameters.AddWithValue("@startDate", startDate);
                command.Parameters.AddWithValue("@endDate", endDate);
                decimal result = Convert.ToDecimal(command.ExecuteScalar());
                textbox_doanhthu.Text = result.ToString("#,##0 VND");
            }
            conn.CloseConnection();
        }
    }
}
