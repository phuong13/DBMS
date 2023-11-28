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

namespace demo.Forms.Kho
{
    public partial class FormThemPhieuNhap : Form
    {
        private Connection conn;
        private Boolean sysRole = false;

        public void setSysRole(Boolean sysRole)
        {
            this.sysRole = sysRole;
        }
        public FormThemPhieuNhap()
        {
            InitializeComponent();
        }
        private void FormThemPhieuNhap_Load(object sender, EventArgs e)
        {
            conn = new Connection(sysRole);
            conn.OpenConnection();
            string sql = "select * from THIET_BI ";
            comboBox_maTB.DataSource = conn.getTable(sql);
            comboBox_maTB.DisplayMember = "maTB";

            string sql2 = "select * from NHA_CUNG_CAP";
            comboBox_maNCC.DataSource = conn.getTable(sql2);
            comboBox_maNCC.DisplayMember = "maNCC";
            conn.CloseConnection();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            conn.OpenConnection();
           
            string maPhieuNhap = textBox_maPN.Text.Trim();
            string maTB = comboBox_maTB.Text.Trim();
            string maNCC = comboBox_maNCC.Text.Trim();
            string tenNCC =textBox_TenNCC.Text.Trim();
            string xuatXu =textBox_Xuatxu.Text.Trim();
            int soLuongValue = int.Parse(textBox_soLuong.Text);


            using (SqlCommand cmd = new SqlCommand("proc_AddStock", conn.getConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maPhieuNhap", maPhieuNhap));
                cmd.Parameters.Add(new SqlParameter("@maTB", maTB));
                cmd.Parameters.Add(new SqlParameter("@maNCC", maNCC));
                cmd.Parameters.Add(new SqlParameter("@tenNCC", tenNCC));
                cmd.Parameters.Add(new SqlParameter("@xuatXu", xuatXu));    
                cmd.Parameters.Add(new SqlParameter("@soLuong", soLuongValue));
                
             
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn thêm phiếu nhập ?", "Thêm phiếu nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_maTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.OpenConnection();
            string sql = "select * from THIET_BI where maTB = '" + comboBox_maTB.Text + "'";
            DataTable dt = conn.getTable(sql);
            foreach (DataRow hang in dt.Rows)
                textBox_TenTB.Text = hang["tenThietBi"].ToString();
            conn.CloseConnection();
           
        }

        private void comboBox_maNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            conn.OpenConnection();
            string sql = "select * from NHA_CUNG_CAP where maNCC = '" + comboBox_maNCC.Text + "'";
            DataTable dt = conn.getTable(sql);
            foreach (DataRow hang in dt.Rows)
                textBox_TenNCC.Text = hang["tenNCC"].ToString();
            foreach (DataRow hang in dt.Rows)
                textBox_Xuatxu.Text = hang["xuatXu"].ToString();
            conn.CloseConnection();
        }
    }
}
