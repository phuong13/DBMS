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
    public partial class FormChinhSuaThietBiTaiNghe : Form
    {
        public FormChinhSuaThietBiTaiNghe()
        {
            InitializeComponent();
        }

        Connection conn = new Connection();

        public void setData(string maTB, string tenThietBi, string kieuKetNoi, string kieuTaiNghe, string donGia, string mauSac, string soLuong)
        {
            txt_maTB.Text = maTB;
            txt_TenThietBi.Text = tenThietBi;
            txt_kieuKetNoi.Text = kieuKetNoi;
            txt_mauSac.Text = mauSac;
            txt_donGia.Text = donGia;
            txt_kieuTaiNghe.Text = kieuTaiNghe;
            txt_soLuong.Text = soLuong;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            conn.openConnection();

            string maTB = txt_maTB.Text;
            string tenThietBi = txt_TenThietBi.Text;
            int soLuong = Convert.ToInt32(txt_soLuong.Text);
            int donGia = Convert.ToInt32(txt_donGia.Text);
            string kieuTaiNghe = txt_kieuTaiNghe.Text;
            string mauSac = txt_mauSac.Text;
            string kieuKetNoi = txt_kieuKetNoi.Text;

            SqlCommand cmd = new SqlCommand("proc_SuaThietBiTaiNghe", conn.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maTB", maTB));
            cmd.Parameters.Add(new SqlParameter("@tenThietBi", tenThietBi));
            cmd.Parameters.Add(new SqlParameter("@soLuong", soLuong));
            cmd.Parameters.Add(new SqlParameter("@donGia", donGia));
            cmd.Parameters.Add(new SqlParameter("@kieuTaiNghe", kieuTaiNghe));
            cmd.Parameters.Add(new SqlParameter("@kieuKetNoi", kieuKetNoi));
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

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
