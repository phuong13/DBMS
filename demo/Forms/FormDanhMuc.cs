using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo.Forms
{
    public partial class FormDanhMuc : Form
    {
        public FormDanhMuc()
        {
            InitializeComponent();
        }
        Dictionary<string, string> columnMapping = new Dictionary<string, string>
        {
            { "tenThietBi", "Tên thiết bị" },
            { "cauHinh", "Cấu hình" },
            { "mauSac", "Màu sắc" },
            { "donGia", "Đơn giá" },
            { "trongLuong", "Trọng lượng" },
            { "kieuKetNoi", "Kiểu kết nối" },
            { "doPhanGiai", "Độ phân giải" },
            { "tanSoQuet", "Tần số quét"},
            { "kichThuoc", "Kích thước"},
            { "layout", "Layout"}
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
        }

        private void buttonDeskTop_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucDesktop";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
        }

        private void buttonBanPhim_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucBanPhim";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
        }

        private void buttonChuot_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucChuot";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
        }

        private void buttonTaiNghe_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucTaiNghe";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
        }

        private void buttonManHinh_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucManHinh";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
        }
    }
}
