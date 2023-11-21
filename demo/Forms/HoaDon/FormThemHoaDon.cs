using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.Forms.HoaDon
{
    public partial class FormThemHoaDon : Form
    {
        private Connection conn;
        private Boolean sysRole = false;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormThemHoaDon()
        {
            InitializeComponent();
            conn = Connection.Instance(sysRole);
        }
        private void FormThemHoaDon_Load(object sender, EventArgs e)
        {
            conn.OpenConnection();
            string sql1 = "select * from THIET_BI";
            comboBox_maTB.DataSource = conn.getTable(sql1);
            comboBox_maTB.DisplayMember = "maTB";

            string sql2 = "select * from NHAN_VIEN";
            comboBox_nguoiLapHD.DataSource = conn.getTable(sql2);
            comboBox_nguoiLapHD.DisplayMember = "maNV";
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

        private void Save_button_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
            string maHD= textBox_maHD.Text;
            string maNguoiLapHD =comboBox_nguoiLapHD.Text;
            string maTB = comboBox_maTB.Text;
            string maKH = textBox_makh.Text;
            string tenKH =textBox_tenKH.Text;
            string sdt =textBox_sdt.Text;
            int soLuongValue = int.Parse(textBox_soLuong.Text);
            using (SqlCommand cmd = new SqlCommand("proc_ThemHoaDon", conn.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maHD", maHD));
                cmd.Parameters.Add(new SqlParameter("@maTB", maTB));
                cmd.Parameters.Add(new SqlParameter("@nguoiLapHoaDon", maNguoiLapHD));
                cmd.Parameters.Add(new SqlParameter("@maKH", maKH));
                cmd.Parameters.Add(new SqlParameter("@tenKH", tenKH));
                cmd.Parameters.Add(new SqlParameter("@soLuong", soLuongValue));
                cmd.Parameters.Add(new SqlParameter("@sdt", sdt));


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
                        MessageBox.Show("Thêm thất bại!\n Lỗi" + ex.Message, "Fail!!");
                    }
                }
            }
            conn.CloseConnection();
        }
    }
}
