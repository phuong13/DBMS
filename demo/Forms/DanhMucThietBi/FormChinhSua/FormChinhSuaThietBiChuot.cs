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
using System.IO;

namespace demo.Forms.DanhMucThietBi.FormChinhSua
{
    public partial class FormChinhSuaThietBiChuot : Form
    {
        private Connection conn;
        private Boolean sysRole = false;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormChinhSuaThietBiChuot()
        {
            InitializeComponent();
            conn = Connection.Instance(sysRole);
        }

        public void setData(string maTB, string tenThietBi, string trongLuong, string mauSac, string donGia, string kieuKetNoi, string soLuong)
        {
            txt_maTB.Text = maTB;
            txt_TenThietBi.Text = tenThietBi;
            txt_kieuKetNoi.Text = kieuKetNoi;
            txt_mauSac.Text = mauSac;
            txt_donGia.Text = donGia;
            txt_trongLuong.Text = trongLuong;
            txt_soLuong.Text = soLuong;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();

            string maTB = txt_maTB.Text;
            string tenThietBi = txt_TenThietBi.Text;
            int soLuong = Convert.ToInt32(txt_soLuong.Text);
            int donGia = Convert.ToInt32(txt_donGia.Text);
            string trongLuong = txt_trongLuong.Text;
            string mauSac = txt_mauSac.Text;
            string kieuKetNoi = txt_kieuKetNoi.Text;
            string imageLink = txt_anhThietBi.Text;
            byte[] imageData = null;
            using (FileStream fileStream = new FileStream(imageLink, FileMode.Open, FileAccess.Read))
            {
                imageData = new Byte[fileStream.Length];
                fileStream.Read(imageData, 0, (int)fileStream.Length);
            }
            SqlCommand cmd = new SqlCommand("proc_SuaThietBiChuot", conn.getConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maTB", maTB));
            cmd.Parameters.Add(new SqlParameter("@tenThietBi", tenThietBi));
            cmd.Parameters.Add(new SqlParameter("@soLuong", soLuong));
            cmd.Parameters.Add(new SqlParameter("@donGia", donGia));
            cmd.Parameters.Add(new SqlParameter("@trongLuong", trongLuong));
            cmd.Parameters.Add(new SqlParameter("@kieuKetNoi", kieuKetNoi));
            cmd.Parameters.Add(new SqlParameter("@mauSac", mauSac));
            cmd.Parameters.Add(new SqlParameter("@anhThietBi", imageData));

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
            conn.CloseConnection();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_chonAnh_Click(object sender, EventArgs e)
        {
            try
            {
                imageFileDialog.Title = "Open Image";
                imageFileDialog.Filter = "Image file (*.jpeg; *.jpg; *.png)|*.jpeg; *.jpg; *.png";
                if (imageFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_anhThietBi.Text = imageFileDialog.FileName;
                    pictureBox_anhThietBi.ImageLocation = imageFileDialog.FileName;
                    imageFileDialog.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
