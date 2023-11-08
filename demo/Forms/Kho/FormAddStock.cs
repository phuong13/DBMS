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
    public partial class FormAddStock : Form
    {
        public FormAddStock()
        {
            InitializeComponent();
        }

        Connection conn = new Connection();

        private void FormADD_Stock_Load(object sender, EventArgs e)
        {
            conn.openConnection();
            
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            connection.getConnection.Open();

            if (int.TryParse(textBox6.Text, out int soLuong) && soLuong <= 0)
            {
                MessageBox.Show("Số Lượng phải lớn hơn 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maPhieuNhap = textBox1.Text.Trim();
            string maTB = textBox2.Text.Trim();
            string maNCC = textBox3.Text.Trim();
            int soLuongValue = int.Parse(textBox6.Text);
            

            using (SqlCommand cmd = new SqlCommand("proc_AddStock", connection.getConnection))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@maPhieuNhap", maPhieuNhap));
                cmd.Parameters.Add(new SqlParameter("@maTB", maTB));
                cmd.Parameters.Add(new SqlParameter("@maNCC", maNCC));
                cmd.Parameters.Add(new SqlParameter("@soLuong", soLuongValue));

                int rowsAffected = cmd.ExecuteNonQuery();
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn thêm phiếu nhập ?", "Thêm phiếu nhập", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.OK)
                {
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thành Công!!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thất Bại!!");
                    }
                }
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
