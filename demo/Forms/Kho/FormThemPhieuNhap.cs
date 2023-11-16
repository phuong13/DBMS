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
        public FormThemPhieuNhap()
        {
            InitializeComponent();
        }
        Connection conn = new Connection();
        private void FormThemPhieuNhap_Load(object sender, EventArgs e)
        {
            conn.openConnection();
            string sql = "select * from THIET_BI ";
            comboBox_maTB.DataSource = conn.getTable(sql);
            comboBox_maTB.DisplayMember = "maTB";

            string sql2 = "select * from NHA_CUNG_CAP";
            comboBox_maNCC.DataSource = conn.getTable(sql2);
            comboBox_maNCC.DisplayMember = "maNCC";
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.getConnection.Open();

           
            string maPhieuNhap = textBox_maPN.Text.Trim();
            string maTB = comboBox_maTB.Text.Trim();
            string maNCC = comboBox_maNCC.Text.Trim();
            string tenNCC =textBox_TenNCC.Text.Trim();
            string xuatXu =textBox_Xuatxu.Text.Trim();
            int soLuongValue = int.Parse(textBox_soLuong.Text);


            using (SqlCommand cmd = new SqlCommand("proc_AddStock", connection.getConnection))
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
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_maTB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from THIET_BI where maTB = '" + comboBox_maTB.Text + "'";
            DataTable dt = conn.getTable(sql);
            foreach (DataRow hang in dt.Rows)
                textBox_TenTB.Text = hang["tenThietBi"].ToString();
           
        }

        private void comboBox_maNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from NHA_CUNG_CAP where maNCC = '" + comboBox_maNCC.Text + "'";
            DataTable dt = conn.getTable(sql);
            foreach (DataRow hang in dt.Rows)
                textBox_TenNCC.Text = hang["tenNCC"].ToString();
            foreach (DataRow hang in dt.Rows)
                textBox_Xuatxu.Text = hang["xuatXu"].ToString();
        }
    }
}
