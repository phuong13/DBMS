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

namespace demo.Forms.Customer
{
    public partial class FormThemKhachHang : Form
    {
        public FormThemKhachHang()
        {
            InitializeComponent();
        }

        Connection conn = new Connection();

        private void FormADD_Customer_Load(object sender, EventArgs e)
        {
            conn.openConnection();
        }
        private bool IsAllDigits(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.getConnection.Open();
            if (textBoxSDT.Text.Length != 10 || !IsAllDigits(textBoxSDT.Text))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập 10 số.");
                return;
            }
            string maNV = textBoxMaKH.Text.Trim();
            string hoTen = textBoxHoTen.Text.Trim();
            string sdt = textBoxSDT.Text.Trim();
            DateTime ngaySinhValue = dateTimePicker_ngaysinh.Value;

            using (SqlCommand cmd = new SqlCommand("proc_ThemKhachHang", connection.getConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maKH", maNV));
                cmd.Parameters.Add(new SqlParameter("@tenKH", hoTen));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));
                cmd.Parameters.Add(new SqlParameter("@ngaySinh", ngaySinhValue));

                int rowsAffected = cmd.ExecuteNonQuery();
                DialogResult rs = MessageBox.Show("Are you sure??", "Add Customer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Successful!!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Fail!!");
                    }
                }
            }
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}