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
    public partial class FormThemThietBi : Form
    {
        public FormThemThietBi()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
        private Dictionary<string, string[]> items = new Dictionary<string, string[]>();
        Dictionary<string, string> columnMapping = new Dictionary<string, string>
        {
            { "maTB", "Mã thiết bị" },
            { "tenThietBi", "Tên thiết bị" },
            { "cauHinh", "Cấu hình" },
            { "mauSac", "Màu sắc" },
            { "donGia", "Đơn giá" },
            { "tgbh", "Thời gian bảo hành" },
            { "trongLuong", "Trọng lượng" },
            { "kieuKetNoi", "Kiểu kết nối" },
            { "doPhanGiai", "Độ phân giải" },
            { "tanSoQuet", "Tần số quét"},
            { "kichThuoc", "Kích thước"},
            { "layout", "Layout"},
            { "soLuong", "Số lượng"},
            { "kieuTaiNghe", "Kiểu tai nghe" }
        };

        private void FormThemThietBi_Load(object sender, EventArgs e)
        {
            items.Add("laptop", new[] { "cauHinh", "trongLuong", "mauSac" });
            items.Add("desktop", new[] { "cauHinh", "trongLuong", "mauSac" });
            items.Add("banPhim", new[] { "kieuKetNoi", "layout", "mauSac" });
            items.Add("chuot", new[] { "kieuKetNoi", "trongLuong", "mauSac" });
            items.Add("taiNghe", new[] { "kieuTaiNghe", "kieuKetNoi", "mauSac" });
            items.Add("manHinh", new[] { "doPhanGiai", "tanSoQuet", "kichThuoc", "kieuKetNoi", "mauSac" });

            cbox_thietBi.DataSource = new BindingSource(items, null);

            cbox_thietBi.DisplayMember = "Value";
            cbox_thietBi.ValueMember = "Key";
        }

        private void cbox_thietBi_SelectedIndexChanged(object sender, EventArgs e)
        {

            panel_textBoxContainer.Controls.Clear();
            String selectType = cbox_thietBi.SelectedItem.ToString();
            AddTextBox(columnMapping["maTB"], "txt_maTB");
            AddTextBox(columnMapping["tenThietBi"], "txt_tenThietBi");
            AddTextBox(columnMapping["tgbh"], "txt_tgbh");
            AddTextBox(columnMapping["soLuong"], "txt_soLuong");
            AddTextBox(columnMapping["donGia"], "txt_donGia");
            string[] values = ((KeyValuePair<string, string[]>)cbox_thietBi.SelectedItem).Value;
            foreach (string value in values)
            {
                AddTextBox(columnMapping[value], $"txt_{value}");
            }
            conn.openConnection();
            SqlCommand cmd = new SqlCommand($"SELECT [dbo].[func_GetAndIncrementMaTB]()", conn.getConnection);
            cmd.CommandType = CommandType.Text;
            string maTB = cmd.ExecuteScalar().ToString();
            (this.FindForm().Controls.Find("txt_maTB", true).FirstOrDefault() as TextBox).Text = maTB;
            conn.closeConnection();
        }
        private void AddTextBox(string labelText, string textboxName)
        {
            Label label = new Label();
            label.Text = labelText;
            label.Width = 140;
            TextBox tbox = new TextBox();
            tbox.Width = 300;
            tbox.Name = textboxName;

            label.Location = new Point(10, panel_textBoxContainer.Controls.Count * 15);
            tbox.Location = new Point(150, panel_textBoxContainer.Controls.Count * 15);

            panel_textBoxContainer.Controls.Add(label);
            panel_textBoxContainer.Controls.Add(tbox);
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            conn.openConnection();
            var parent = this.FindForm();

            string tenTB = (parent.Controls.Find("txt_tenThietBi", true).FirstOrDefault() as TextBox).Text;
            string maTB = (parent.Controls.Find("txt_maTB", true).FirstOrDefault() as TextBox).Text;
            string tgbh = (parent.Controls.Find("txt_tgbh", true).FirstOrDefault() as TextBox).Text;
            int soLuong = Convert.ToInt32((parent.Controls.Find("txt_soLuong", true).FirstOrDefault() as TextBox).Text);
            int donGia = Convert.ToInt32((parent.Controls.Find("txt_donGia", true).FirstOrDefault() as TextBox).Text);
            string[] values = ((KeyValuePair<string, string[]>)cbox_thietBi.SelectedItem).Value;
            string key = ((KeyValuePair<string, string[]>)cbox_thietBi.SelectedItem).Key;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn.getConnection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@maTB", maTB));
            cmd.Parameters.Add(new SqlParameter("@tenThietBi", tenTB));
            cmd.Parameters.Add(new SqlParameter("@tgbh", tgbh));
            cmd.Parameters.Add(new SqlParameter("@soLuong", soLuong));
            cmd.Parameters.Add(new SqlParameter("@donGia", donGia));
            string cauHinh;
            string trongLuong;
            string mauSac;
            string kieuKetNoi;
            string layout;
            string kieuTaiNghe;
            string tanSoQuet;
            string doPhanGiai;
            string kichThuoc;
            switch (key)
            {
                case "laptop":
                    cauHinh = (parent.Controls.Find("txt_cauHinh", true).FirstOrDefault() as TextBox).Text;
                    trongLuong = (parent.Controls.Find("txt_trongLuong", true).FirstOrDefault() as TextBox).Text;
                    mauSac = (parent.Controls.Find("txt_mauSac", true).FirstOrDefault() as TextBox).Text;
                    cmd.CommandText = "proc_ThemThietBiLaptop";
                    cmd.Parameters.Add(new SqlParameter("@cauHinh", cauHinh));
                    cmd.Parameters.Add(new SqlParameter("@trongLuong", trongLuong));
                    cmd.Parameters.Add(new SqlParameter("@mauSac", mauSac));
                    DialogResult rs = MessageBox.Show("Bạn có muốn thêm?", "Lưu ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                            MessageBox.Show("Thêm thất bại!\nLỗi: " + ex.Message, "Fail!!");
                        }

                    }
                    break;
                case "desktop":
                    cauHinh = (parent.Controls.Find("txt_cauHinh", true).FirstOrDefault() as TextBox).Text;
                    trongLuong = (parent.Controls.Find("txt_trongLuong", true).FirstOrDefault() as TextBox).Text;
                    mauSac = (parent.Controls.Find("txt_mauSac", true).FirstOrDefault() as TextBox).Text;
                    cmd.CommandText = "proc_ThemThietBiDesktop";
                    cmd.Parameters.Add(new SqlParameter("@cauHinh", cauHinh));
                    cmd.Parameters.Add(new SqlParameter("@trongLuong", trongLuong));
                    cmd.Parameters.Add(new SqlParameter("@mauSac", mauSac));
                    rs = MessageBox.Show("Bạn có muốn thêm?", "Lưu ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                            MessageBox.Show("Thêm thất bại!\nLỗi: " + ex.Message, "Fail!!");
                        }
                    }
                    break;
                case "banPhim":
                    kieuKetNoi = (parent.Controls.Find("txt_kieuKetNoi", true).FirstOrDefault() as TextBox).Text;
                    layout = (parent.Controls.Find("txt_layout", true).FirstOrDefault() as TextBox).Text;
                    mauSac = (parent.Controls.Find("txt_mauSac", true).FirstOrDefault() as TextBox).Text;
                    cmd.CommandText = "proc_ThemThietBiBanPhim";
                    cmd.Parameters.Add(new SqlParameter("@kieuKetNoi", kieuKetNoi));
                    cmd.Parameters.Add(new SqlParameter("@layout", layout));
                    cmd.Parameters.Add(new SqlParameter("@mauSac", mauSac));
                    rs = MessageBox.Show("Bạn có muốn thêm?", "Lưu ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                            MessageBox.Show("Thêm thất bại!\nLỗi: " + ex.Message, "Fail!!");
                        }
                    }
                    break;
                case "chuot":
                    kieuKetNoi = (parent.Controls.Find("txt_kieuKetNoi", true).FirstOrDefault() as TextBox).Text;
                    trongLuong = (parent.Controls.Find("txt_trongLuong", true).FirstOrDefault() as TextBox).Text;
                    mauSac = (parent.Controls.Find("txt_mauSac", true).FirstOrDefault() as TextBox).Text;
                    cmd.CommandText = "proc_ThemThietBiChuot";
                    cmd.Parameters.Add(new SqlParameter("@kieuKetNoi", kieuKetNoi));
                    cmd.Parameters.Add(new SqlParameter("@trongLuong", trongLuong));
                    cmd.Parameters.Add(new SqlParameter("@mauSac", mauSac));
                    rs = MessageBox.Show("Bạn có muốn thêm?", "Lưu ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                            MessageBox.Show("Thêm thất bại!\nLỗi: " + ex.Message, "Fail!!");
                        }
                    }
                    break;
                case "taiNghe":
                    kieuKetNoi = (parent.Controls.Find("txt_kieuKetNoi", true).FirstOrDefault() as TextBox).Text;
                    kieuTaiNghe = (parent.Controls.Find("txt_kieuTaiNghe", true).FirstOrDefault() as TextBox).Text;
                    mauSac = (parent.Controls.Find("txt_mauSac", true).FirstOrDefault() as TextBox).Text;
                    cmd.CommandText = "proc_ThemThietBiTaiNghe";
                    cmd.Parameters.Add(new SqlParameter("@kieuKetNoi", kieuKetNoi));
                    cmd.Parameters.Add(new SqlParameter("@kieuTaiNghe", kieuTaiNghe));
                    cmd.Parameters.Add(new SqlParameter("@mauSac", mauSac));
                    rs = MessageBox.Show("Bạn có muốn thêm?", "Lưu ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                            MessageBox.Show("Thêm thất bại!\nLỗi: " + ex.Message, "Fail!!");
                        }
                    }
                    break;
                case "manHinh":
                    kieuKetNoi = (parent.Controls.Find("txt_kieuKetNoi", true).FirstOrDefault() as TextBox).Text;
                    doPhanGiai = (parent.Controls.Find("txt_doPhanGiai", true).FirstOrDefault() as TextBox).Text;
                    tanSoQuet = (parent.Controls.Find("txt_tanSoQuet", true).FirstOrDefault() as TextBox).Text;
                    kichThuoc = (parent.Controls.Find("txt_kichThuoc", true).FirstOrDefault() as TextBox).Text;
                    mauSac = (parent.Controls.Find("txt_mauSac", true).FirstOrDefault() as TextBox).Text;
                    cmd.CommandText = "proc_ThemThietBiManHinh";
                    cmd.Parameters.Add(new SqlParameter("@kieuKetNoi", kieuKetNoi));
                    cmd.Parameters.Add(new SqlParameter("@doPhanGiai", doPhanGiai));
                    cmd.Parameters.Add(new SqlParameter("@tanSoQuet", tanSoQuet));
                    cmd.Parameters.Add(new SqlParameter("@kichThuoc", kichThuoc));
                    cmd.Parameters.Add(new SqlParameter("@mauSac", mauSac));
                    rs = MessageBox.Show("Bạn có muốn thêm?", "Lưu ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
                            MessageBox.Show("Thêm thất bại!\nLỗi: " + ex.Message, "Fail!!");
                        }
                    }
                    break;
            }
            conn.closeConnection();
        }
    }
}
