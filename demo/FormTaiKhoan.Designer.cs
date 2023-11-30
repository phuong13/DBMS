
namespace demo
{
    partial class FormTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTaiKhoan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dg_taiKhoan = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.check_isAdmin = new System.Windows.Forms.CheckBox();
            this.panel_edit = new System.Windows.Forms.Panel();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_taiKhoan)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel_edit.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 547);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dg_taiKhoan);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1088, 547);
            this.panel4.TabIndex = 10;
            // 
            // dg_taiKhoan
            // 
            this.dg_taiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_taiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_taiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_taiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.password});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_taiKhoan.DefaultCellStyle = dataGridViewCellStyle4;
            this.dg_taiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_taiKhoan.Location = new System.Drawing.Point(0, 0);
            this.dg_taiKhoan.Name = "dg_taiKhoan";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_taiKhoan.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dg_taiKhoan.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_taiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_taiKhoan.RowTemplate.Height = 24;
            this.dg_taiKhoan.Size = new System.Drawing.Size(714, 547);
            this.dg_taiKhoan.TabIndex = 0;
            this.dg_taiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_taiKhoan_CellClick);
            this.dg_taiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.check_isAdmin);
            this.panel3.Controls.Add(this.panel_edit);
            this.panel3.Controls.Add(this.lbl_username);
            this.panel3.Controls.Add(this.txt_username);
            this.panel3.Controls.Add(this.lbl_password);
            this.panel3.Controls.Add(this.txt_password);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(714, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 547);
            this.panel3.TabIndex = 9;
            // 
            // check_isAdmin
            // 
            this.check_isAdmin.AutoSize = true;
            this.check_isAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_isAdmin.Location = new System.Drawing.Point(260, 88);
            this.check_isAdmin.Name = "check_isAdmin";
            this.check_isAdmin.Size = new System.Drawing.Size(91, 24);
            this.check_isAdmin.TabIndex = 9;
            this.check_isAdmin.Text = "Quản trị";
            this.check_isAdmin.UseVisualStyleBackColor = true;
            this.check_isAdmin.CheckedChanged += new System.EventHandler(this.check_isAdmin_CheckedChanged);
            // 
            // panel_edit
            // 
            this.panel_edit.Controls.Add(this.btn_xoa);
            this.panel_edit.Controls.Add(this.btn_sua);
            this.panel_edit.Controls.Add(this.btn_them);
            this.panel_edit.Location = new System.Drawing.Point(26, 119);
            this.panel_edit.Name = "panel_edit";
            this.panel_edit.Size = new System.Drawing.Size(325, 92);
            this.panel_edit.TabIndex = 8;
            // 
            // btn_xoa
            // 
            this.btn_xoa.AutoSize = true;
            this.btn_xoa.Enabled = false;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::demo.Properties.Resources.cross32px;
            this.btn_xoa.Location = new System.Drawing.Point(0, 17);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_xoa.Size = new System.Drawing.Size(100, 48);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.AutoSize = true;
            this.btn_sua.Enabled = false;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Image = global::demo.Properties.Resources.edit32px;
            this.btn_sua.Location = new System.Drawing.Point(106, 17);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_sua.Size = new System.Drawing.Size(100, 48);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.AutoSize = true;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::demo.Properties.Resources.plus32px_02;
            this.btn_them.Location = new System.Drawing.Point(212, 17);
            this.btn_them.Name = "btn_them";
            this.btn_them.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_them.Size = new System.Drawing.Size(113, 48);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(22, 20);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(86, 20);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Tài khoản:";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(114, 17);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(237, 27);
            this.txt_username.TabIndex = 2;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(22, 58);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(82, 20);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Mật khẩu:";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(114, 55);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(237, 27);
            this.txt_password.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 547);
            this.panel2.TabIndex = 8;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.DefaultCellStyle = dataGridViewCellStyle2;
            this.username.HeaderText = "Tên tài khoản";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.DefaultCellStyle = dataGridViewCellStyle3;
            this.password.HeaderText = "Mật khẩu";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 547);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTaiKhoan";
            this.Text = "Quản lý tài khoản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTaiKhoan_FormClosed);
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_taiKhoan)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_edit.ResumeLayout(false);
            this.panel_edit.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dg_taiKhoan;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_edit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox check_isAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}