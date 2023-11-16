using demo.Forms.HoaDon;
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
            button_Xoa.Enabled = true;
            button_xoaTB.Visible = false;
            button_ThemTB.Visible = false;
            button_Thanhtoan.Visible = true;
            button_them.Visible = true;
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

        private void button_them_Click(object sender, EventArgs e)
        {
            FormThemHoaDon f = new FormThemHoaDon();
            f.FormClosed += new FormClosedEventHandler(FormADD_HoaDonClosed);
            f.ShowDialog();
        }
        private void FormADD_HoaDonClosed(object sender, FormClosedEventArgs e)
        {
            load_data_hoadon();
        }

        private void dataGridViewHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            load_data_CTHD();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            load_data_hoadon();
        }
        private void load_data_CTHD()
        {
            button_ThemTB.Visible = true;
            button_them.Visible = false;
            button_Thanhtoan.Visible = false;
            button_xoaTB.Visible = true;
            button_Xoa.Visible = false;
       
            Connection connection = new Connection();
            connection.getConnection.Open();
            string maHD = dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString();
            using (SqlCommand cmd = new SqlCommand("select * from func_XemChiTietHoaDon(@maHD)", connection.getConnection))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@maHD", maHD));
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridViewHoaDon.DataSource = dataTable;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.getConnection.Open();

            string maHD = dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString();
            
            using (SqlCommand cmd = new SqlCommand("proc_XoaHoaDon", connection.getConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", maHD));

                DialogResult rs = MessageBox.Show("Are you sure??", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công", "Successfull", MessageBoxButtons.OK);
                        load_data_hoadon();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại!\n" + ex.Message, "Fail!!");
                    }

                }
            }
        }

        private void button_Thanhtoan_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.getConnection.Open();

            string maHD = dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString();
           
            using (SqlCommand cmd = new SqlCommand("proc_UpdateTrangThaiAndNgayThanhToan", connection.getConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", maHD));
         


                DialogResult rs = MessageBox.Show("Are you sure??", "Thanh toán", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thanh toán thành công", "Successfull", MessageBoxButtons.OK);
                        load_data_hoadon();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thanh toán thất bại!\n" + ex.Message, "Fail!!");
                    }
                }
            }
        }

        private void button_ThemTB_Click(object sender, EventArgs e)
        {
            string maHD=dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString();    
            
            FormThemThietBiVaoHoaDon f = new FormThemThietBiVaoHoaDon();
            f.FormClosed += new FormClosedEventHandler(FormADD_ThietBiVaoHoaDonClosed);
            f.set_maHD(maHD);
            f.ShowDialog();
        }
        private void FormADD_ThietBiVaoHoaDonClosed(object sender, FormClosedEventArgs e)
        {
            load_data_CTHD();
        }

        private void button_xoaTB_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.getConnection.Open();

            string maHD = dataGridViewHoaDon.CurrentRow.Cells[0].Value.ToString();
            string maTB = dataGridViewHoaDon.CurrentRow.Cells[2].Value.ToString();
            using (SqlCommand cmd = new SqlCommand("proc_XoaThietBiTrongHoaDon", connection.getConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", maHD));
                cmd.Parameters.Add(new SqlParameter("@maTB", maTB));


                DialogResult rs = MessageBox.Show("Are you sure??", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công", "Successfull", MessageBoxButtons.OK);
                        load_data_CTHD();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Xóa thất bại!\n" + ex.Message, "Fail!!");
                    }

                }
            }
        }
    }
}
