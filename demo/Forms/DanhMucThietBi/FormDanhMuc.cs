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
        private Color themeColor;
        private Button currentButton;
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
            {"soLuong","Số lượng" },
            {"kieuTaiNghe" ,"Kiểu tai nghe"}
        };
        private void LoadTheme(Panel p)
        {
            DisableButton();
            foreach (Control btns in p.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Black;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            themeColor = ThemeColor.PrimaryColor;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = themeColor;
                    this.currentButton = (Button)btnSender;
                    this.currentButton.BackColor = color;
                    this.currentButton.ForeColor = Color.White;
                    this.currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel_DanhMuc.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

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
            dg_DanhMucSanPham.Columns[columnMapping["donGia"]].DefaultCellStyle.Format = "#,##0 VND";
            currentType = "laptop";
            load_sum("func_sumThietBiLaptop");
            ActivateButton(buttonLapTop);
        }

        private void buttonDeskTop_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucDesktop";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
            dg_DanhMucSanPham.Columns[columnMapping["donGia"]].DefaultCellStyle.Format = "#,##0 VND";
            currentType = "desktop";
            load_sum("func_sumThietBiDesktop");
            ActivateButton(buttonDeskTop);
        }

        private void buttonBanPhim_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucBanPhim";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
            dg_DanhMucSanPham.Columns[columnMapping["donGia"]].DefaultCellStyle.Format = "#,##0 VND";
            currentType = "banPhim";
            load_sum("func_sumThietBiBanPhim");
            ActivateButton(buttonBanPhim);
        }

        private void buttonChuot_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucChuot";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
            dg_DanhMucSanPham.Columns[columnMapping["donGia"]].DefaultCellStyle.Format = "#,##0 VND";
            currentType = "chuot";
            load_sum("func_sumThietBiChuot");
            ActivateButton(buttonChuot);
        }

        private void buttonTaiNghe_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucTaiNghe";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
            dg_DanhMucSanPham.Columns[columnMapping["donGia"]].DefaultCellStyle.Format = "#,##0 VND";
            currentType = "taiNghe";
            load_sum("func_sumThietBiTaiNghe");
            ActivateButton(buttonTaiNghe);
        }

        private void buttonManHinh_Click(object sender, EventArgs e)
        {
            string sql = "select * from V_DanhMucManHinh";
            DataTable dt = conn.getTable(sql);
            MappingCol(dt);
            dg_DanhMucSanPham.DataSource = dt;
            dg_DanhMucSanPham.Columns[columnMapping["donGia"]].DefaultCellStyle.Format = "#,##0 VND";
            currentType = "manHinh";
            load_sum("func_sumThietBiManHinh");
            ActivateButton(buttonManHinh);
        }

        private void dg_DanhMucSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            dg_DanhMucSanPham.Rows[rowIndex].Selected = true;
            btn_xoaThietBi.Enabled = true;
            btn_suaThietBi.Enabled = true;
        }
       
        private void btn_themThietBi_Click(object sender, EventArgs e)
        {
            FormThemThietBi f = new FormThemThietBi();
            f.ShowDialog();
        }

        private void btn_xoaThietBi_Click(object sender, EventArgs e)
        {
            
        }

        private void FormDanhMuc_Load(object sender, EventArgs e)
        {
            dg_DanhMucSanPham.AllowUserToAddRows = false;
            LoadTheme(panel3);
            dg_DanhMucSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
        }

        private void FromChinhSuaLaptop_Closed(object sender, FormClosedEventArgs e)
        {
            buttonLapTop_Click(sender, e);
        }
        private void FromChinhSuaDesktop_Closed(object sender, FormClosedEventArgs e)
        {
            buttonDeskTop_Click(sender, e);
        }
        private void FromChinhSuaBanPhim_Closed(object sender, FormClosedEventArgs e)
        {
            buttonBanPhim_Click(sender, e);
        }
        private void FromChinhSuaChuot_Closed(object sender, FormClosedEventArgs e)
        {
            buttonChuot_Click(sender, e);
        }
        private void FromChinhSuaTaiNghe_Closed(object sender, FormClosedEventArgs e)
        {
            buttonTaiNghe_Click(sender, e);
        }
        private void FromChinhSuaManHinh_Closed(object sender, FormClosedEventArgs e)
        {
            buttonManHinh_Click(sender, e);
        }
        private void load_sum(string func)
        {
            conn.openConnection();
            SqlCommand cmd = new SqlCommand($"select  dbo.{func}()", conn.getConnection);
            cmd.CommandType = CommandType.Text;
            textBox1.Text =cmd.ExecuteScalar().ToString();
            conn.closeConnection();
        }

        private void btn_suaThietBi_Click_1(object sender, EventArgs e)
        {
            string maTB = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["maTB"]].Value.ToString();
            string tenThietBi = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["tenThietBi"]].Value.ToString();
            string soLuong = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["soLuong"]].Value.ToString();
            string donGia = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["donGia"]].Value.ToString();

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
                    cauHinh = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["cauHinh"]].Value.ToString();
                    mauSac = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["mauSac"]].Value.ToString();
                    trongLuong = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["trongLuong"]].Value.ToString();
                    FormChinhSua.FormChinhSuaThietBiLaptop f1 = new FormChinhSua.FormChinhSuaThietBiLaptop();
                    f1.setData(maTB, tenThietBi, cauHinh, mauSac, donGia, trongLuong, soLuong);
                    f1.FormClosed += new FormClosedEventHandler(FromChinhSuaLaptop_Closed);
                    f1.ShowDialog();
                    break;
                case "desktop":
                    cauHinh = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["cauHinh"]].Value.ToString();
                    mauSac = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["mauSac"]].Value.ToString();
                    trongLuong = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["trongLuong"]].Value.ToString();
                    FormChinhSua.FormChinhSuaThietBiDesktop f2 = new FormChinhSua.FormChinhSuaThietBiDesktop();
                    f2.setData(maTB, tenThietBi, cauHinh, mauSac, donGia, trongLuong, soLuong);
                    f2.FormClosed += new FormClosedEventHandler(FromChinhSuaDesktop_Closed);
                    f2.ShowDialog();
                    break;
                case "banPhim":
                    kieuKetNoi = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["kieuKetNoi"]].Value.ToString();
                    layout = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["layout"]].Value.ToString();
                    mauSac = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["mauSac"]].Value.ToString();
                    FormChinhSua.FormChinhSuaThietBiBanPhim f3 = new FormChinhSua.FormChinhSuaThietBiBanPhim();
                    f3.setData(maTB, tenThietBi, layout, mauSac, donGia, kieuKetNoi, soLuong);
                    f3.FormClosed += new FormClosedEventHandler(FromChinhSuaBanPhim_Closed);
                    f3.ShowDialog();
                    break;
                case "chuot":
                    kieuKetNoi = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["kieuKetNoi"]].Value.ToString();
                    trongLuong = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["trongLuong"]].Value.ToString();
                    mauSac = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["mauSac"]].Value.ToString();
                    FormChinhSua.FormChinhSuaThietBiChuot f4 = new FormChinhSua.FormChinhSuaThietBiChuot();
                    f4.setData(maTB, tenThietBi, trongLuong, mauSac, donGia, kieuKetNoi, soLuong);
                    f4.FormClosed += new FormClosedEventHandler(FromChinhSuaChuot_Closed);
                    f4.ShowDialog();
                    break;
                case "taiNghe":
                    kieuKetNoi = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["kieuKetNoi"]].Value.ToString();
                    kieuTaiNghe = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["kieuTaiNghe"]].Value.ToString();
                    mauSac = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["mauSac"]].Value.ToString();
                    FormChinhSua.FormChinhSuaThietBiTaiNghe f5 = new FormChinhSua.FormChinhSuaThietBiTaiNghe();
                    f5.setData(maTB, tenThietBi, kieuKetNoi, kieuTaiNghe, donGia, mauSac, soLuong);
                    f5.FormClosed += new FormClosedEventHandler(FromChinhSuaTaiNghe_Closed);
                    f5.ShowDialog();
                    break;
                case "manHinh":
                    doPhanGiai = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["doPhanGiai"]].Value.ToString();
                    kieuKetNoi = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["kieuKetNoi"]].Value.ToString();
                    tanSoQuet = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["tanSoQuet"]].Value.ToString();
                    kichThuoc = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["kichThuoc"]].Value.ToString();
                    mauSac = dg_DanhMucSanPham.CurrentRow.Cells[columnMapping["mauSac"]].Value.ToString();
                    FormChinhSua.FormChinhSuaThietBiManHinh f6 = new FormChinhSua.FormChinhSuaThietBiManHinh();
                    f6.setData(maTB, tenThietBi, doPhanGiai, tanSoQuet, kieuKetNoi, kichThuoc, mauSac, donGia, soLuong);
                    f6.FormClosed += new FormClosedEventHandler(FromChinhSuaManHinh_Closed);
                    f6.ShowDialog();
                    break;
            }
        }
    }
}
