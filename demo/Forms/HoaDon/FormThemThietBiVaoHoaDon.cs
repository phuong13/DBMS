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

namespace demo.Forms.HoaDon
{
    public partial class FormThemThietBiVaoHoaDon : Form
    {
        public FormThemThietBiVaoHoaDon()
        {
            InitializeComponent();
        }
        Connection conn =new Connection();
        private void Save_button_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.openConnection();
            string maHD = textBox_maHD.Text;
            string maTB = comboBox_maTB.Text;
            int soLuongValue = int.Parse(textBox_soLuong.Text);
            using (SqlCommand cmd = new SqlCommand("proc_ThemThietBiVaoHoaDon", connection.getConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", maHD));
                cmd.Parameters.Add(new SqlParameter("@maTB", maTB));
                cmd.Parameters.Add(new SqlParameter("@soLuong", soLuongValue));
               


                DialogResult rs = MessageBox.Show("Bạn có chắc muốn thêm hóa đơn ?", "Thêm hóa đơn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công", "Successfull", MessageBoxButtons.OK);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại!\n" + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void set_maHD(string maHD)
        {
            textBox_maHD.Text = maHD;

        }
        private void FormThemThietBiVaoHoaDon_Load(object sender, EventArgs e)
        {
            conn.openConnection();
            string sql1 = "select * from THIET_BI";
            comboBox_maTB.DataSource = conn.getTable(sql1);
            comboBox_maTB.DisplayMember = "maTB";
        }

        private void comboBox_maTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from THIET_BI where maTB = '" + comboBox_maTB.Text + "'";
            DataTable dt = conn.getTable(sql);
            foreach (DataRow hang in dt.Rows)
                textBox_TenTB.Text = hang["tenThietBi"].ToString();
            foreach (DataRow hang in dt.Rows)
                textBox_dongia.Text = hang["donGia"].ToString();
        }
    }
}
