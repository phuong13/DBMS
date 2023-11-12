using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace demo.Forms.DanhMucThietBi.FormChinhSua
{
    public partial class FormChinhSuaThietBiLaptop : Form
    {
        public FormChinhSuaThietBiLaptop()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
        public void setData(string maTB, string tenThietBi, string cauHinh, string mauSac, string donGia, string trongLuong, string soLuong)
        {
            txt_maTB.Text = maTB;
            txt_TenThietBi.Text = tenThietBi;
            txt_cauHinh.Text = cauHinh;
            txt_mauSac.Text = mauSac;
            txt_donGia.Text = donGia;
            txt_trongLuong.Text = trongLuong;
            txt_soLuong.Text = soLuong;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            conn.openConnection();

            string maTB = txt_maTB.Text;
            string tenThietBi = txt_TenThietBi.Text;
            int soLuong = Convert.ToInt32(txt_soLuong.Text);
            int donGia = Convert.ToInt32(txt_donGia.Text);
            string cauHinh = txt_cauHinh.Text;
            string mauSac = txt_mauSac.Text;
            string trongLuong = txt_trongLuong.Text;

            SqlCommand cmd = new SqlCommand("proc_SuaThietBiLaptop", conn.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maTB", maTB));
            cmd.Parameters.Add(new SqlParameter("@tenThietBi", tenThietBi));
            cmd.Parameters.Add(new SqlParameter("@soLuong", soLuong));
            cmd.Parameters.Add(new SqlParameter("@donGia", donGia));
            cmd.Parameters.Add(new SqlParameter("@cauHinh", cauHinh));
            cmd.Parameters.Add(new SqlParameter("@trongLuong", trongLuong));
            cmd.Parameters.Add(new SqlParameter("@mauSac", mauSac));

            DialogResult rs = MessageBox.Show("Bạn có muốn sửa thông tin thiết bị?", "Lưu ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sửa thành công", "Successfull", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sửa thất bại!\nLỗi: " + ex.Message, "Fail!!");
                }

            }
            conn.closeConnection();
        }
    }
}
