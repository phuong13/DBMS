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

namespace demo.Forms.DanhMucThietBi
{
    public partial class FormDanhMuc : Form
    {
        public FormDanhMuc()
        {
            InitializeComponent();
        }
        private string currentType = "";
        Dictionary<string, string> columnMapping = new Dictionary<string, string>
        {
            { "maTB", "Mã thiết bị" },
            { "tenThietBi", "Tên thiết bị" },
            { "cauHinh", "Cấu hình" },
            { "mauSac", "Màu sắc" },
            { "donGia", "Đơn giá" },
            { "trongLuong", "Trọng lượng" },
            { "kieuKetNoi", "Kiểu kết nối" },
            { "doPhanGiai", "Độ phân giải" },
            { "tanSoQuet", "Tần số quét"},
            { "kichThuoc", "Kích thước"},
            { "layout", "Layout"},
            { "soLuong", "Số lượng"},
            { "kieuTaiNghe", "Kiểu tai nghe" }
        };
        private void MappingCol(DataTable dt)
        {
            foreach (DataColumn column in dt.Columns)
            {
                if (columnMapping.ContainsKey(column.ColumnName))
                {
                    column.ColumnName = columnMapping[column.ColumnName];
                }
            }
        }
        Connection conn = new Connection();
        
        private void buttonLapTop_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucLaptop";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
            currentType = "laptop";
        }

        private void buttonDeskTop_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucDesktop";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
            currentType = "desktop";
        }

        private void buttonBanPhim_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucBanPhim";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
            currentType = "banPhim";
        }

        private void buttonChuot_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucChuot";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
            currentType = "chuot";
        }

        private void buttonTaiNghe_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucTaiNghe";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
            currentType = "taiNghe";
        }

        private void buttonManHinh_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucManHinh";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
            currentType = "manHinh";
        }

        private void dg_DanhMucSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_suaThietBi.Enabled = true;
            btn_xoaThietBi.Enabled = true;
        }

        private void btn_suaThietBi_Click(object sender, EventArgs e)
        {
            string maTB = dg_DanhMucSanPham.CurrentRow.Cells[0].Value.ToString();
            string tenTB = dg_DanhMucSanPham.CurrentRow.Cells[1].Value.ToString();
            string tgbh = dg_DanhMucSanPham.CurrentRow.Cells[2].Value.ToString();
            int soLuong = Convert.ToInt32(dg_DanhMucSanPham.CurrentRow.Cells[3].Value.ToString());
            int donGia = Convert.ToInt32(dg_DanhMucSanPham.CurrentRow.Cells[4].Value.ToString());

            string cauHinh;
            string trongLuong;
            string mauSac;
            string kieuKetNoi;
            string layout;
            string kieuTaiNghe;
            string tanSoQuet;
            string doPhanGiai;
            string kichThuoc;
            switch (currentType)
            {
                case "laptop":
                    break;
                case "desktop":
                    break;
                case "banPhim":
                    break;
                case "chuot":
                    break;
                case "taiNghe":
                    break;
                case "manHinh":
                    break;
            }
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            dg_DanhMucSanPham.AllowUserToAddRows = false;
        }

        private void FormDanhMuc_Load_1(object sender, EventArgs e)
        {
            dg_DanhMucSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        }

        private void btn_themThietBi_Click(object sender, EventArgs e)
        {
            FormThemThietBi f = new FormThemThietBi();
            f.ShowDialog();
        }

        private void btn_xoaThietBi_Click(object sender, EventArgs e)
        {
            conn.openConnection();
            string maTB = dg_DanhMucSanPham.CurrentRow.Cells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand("proc_XoaThietBi", conn.getConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maTB", maTB));
            cmd.ExecuteNonQuery();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công", "Successed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xóa thất bại" + maTB, "Falied!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.closeConnection();
            buttonLapTop_Click(sender, e);
        }
    }
}
