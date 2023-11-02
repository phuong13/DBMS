namespace demo.Forms
{
    partial class FormEmployees
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
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonChinhsua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.Column_maNQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ngáyinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.textBoxMaNQL = new System.Windows.Forms.TextBox();
            this.labelMaNQL = new System.Windows.Forms.Label();
            this.textBoxGioiTinh = new System.Windows.Forms.TextBox();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.textBoxNgaySinh = new System.Windows.Forms.TextBox();
            this.labelngaySinh = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.labelsdt = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.labelMaNV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonXoa
            // 
            this.buttonXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonXoa.Location = new System.Drawing.Point(1308, 0);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(90, 58);
            this.buttonXoa.TabIndex = 0;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonChinhsua
            // 
            this.buttonChinhsua.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonChinhsua.Location = new System.Drawing.Point(1196, 0);
            this.buttonChinhsua.Name = "buttonChinhsua";
            this.buttonChinhsua.Size = new System.Drawing.Size(112, 58);
            this.buttonChinhsua.TabIndex = 1;
            this.buttonChinhsua.Text = "Chỉnh sửa";
            this.buttonChinhsua.UseVisualStyleBackColor = true;
            this.buttonChinhsua.Click += new System.EventHandler(this.buttonChinhsua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonThem.Location = new System.Drawing.Point(1106, 0);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(90, 58);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // Column_maNQL
            // 
            this.Column_maNQL.DataPropertyName = "maNQL";
            this.Column_maNQL.HeaderText = "Mã NQL";
            this.Column_maNQL.MinimumWidth = 8;
            this.Column_maNQL.Name = "Column_maNQL";
            // 
            // Column_gioitinh
            // 
            this.Column_gioitinh.DataPropertyName = "gioiTinh";
            this.Column_gioitinh.HeaderText = "Giới Tính";
            this.Column_gioitinh.MinimumWidth = 8;
            this.Column_gioitinh.Name = "Column_gioitinh";
            // 
            // Column_ngáyinh
            // 
            this.Column_ngáyinh.DataPropertyName = "ngaySinh";
            this.Column_ngáyinh.HeaderText = "Ngày Sinh";
            this.Column_ngáyinh.MinimumWidth = 8;
            this.Column_ngáyinh.Name = "Column_ngáyinh";
            // 
            // Column_sdt
            // 
            this.Column_sdt.DataPropertyName = "sdt";
            this.Column_sdt.HeaderText = "SDT";
            this.Column_sdt.MinimumWidth = 8;
            this.Column_sdt.Name = "Column_sdt";
            // 
            // Column_hoten
            // 
            this.Column_hoten.DataPropertyName = "hoTen";
            this.Column_hoten.HeaderText = "Họ Tên";
            this.Column_hoten.MinimumWidth = 8;
            this.Column_hoten.Name = "Column_hoten";
            // 
            // Column_manv
            // 
            this.Column_manv.DataPropertyName = "maNV";
            this.Column_manv.HeaderText = "Mã NV";
            this.Column_manv.MinimumWidth = 8;
            this.Column_manv.Name = "Column_manv";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_manv,
            this.Column_hoten,
            this.Column_sdt,
            this.Column_ngáyinh,
            this.Column_gioitinh,
            this.Column_maNQL});
            this.dataGridViewEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 62;
            this.dataGridViewEmployees.RowTemplate.Height = 28;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1400, 701);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellClick);
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            // 
            // panelEdit
            // 
            this.panelEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEdit.Controls.Add(this.textBoxMaNQL);
            this.panelEdit.Controls.Add(this.labelMaNQL);
            this.panelEdit.Controls.Add(this.textBoxGioiTinh);
            this.panelEdit.Controls.Add(this.labelGioiTinh);
            this.panelEdit.Controls.Add(this.textBoxNgaySinh);
            this.panelEdit.Controls.Add(this.labelngaySinh);
            this.panelEdit.Controls.Add(this.textBoxSDT);
            this.panelEdit.Controls.Add(this.labelsdt);
            this.panelEdit.Controls.Add(this.textBoxHoTen);
            this.panelEdit.Controls.Add(this.labelHoTen);
            this.panelEdit.Controls.Add(this.textBoxMaNV);
            this.panelEdit.Controls.Add(this.labelMaNV);
            this.panelEdit.Controls.Add(this.buttonThem);
            this.panelEdit.Controls.Add(this.buttonChinhsua);
            this.panelEdit.Controls.Add(this.buttonXoa);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEdit.Location = new System.Drawing.Point(0, 641);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1400, 60);
            this.panelEdit.TabIndex = 1;
            // 
            // textBoxMaNQL
            // 
            this.textBoxMaNQL.Location = new System.Drawing.Point(286, 34);
            this.textBoxMaNQL.Name = "textBoxMaNQL";
            this.textBoxMaNQL.Size = new System.Drawing.Size(140, 26);
            this.textBoxMaNQL.TabIndex = 14;
            this.textBoxMaNQL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMaNQL
            // 
            this.labelMaNQL.AutoSize = true;
            this.labelMaNQL.Location = new System.Drawing.Point(216, 37);
            this.labelMaNQL.Name = "labelMaNQL";
            this.labelMaNQL.Size = new System.Drawing.Size(72, 20);
            this.labelMaNQL.TabIndex = 13;
            this.labelMaNQL.Text = "Mã NQL";
            // 
            // textBoxGioiTinh
            // 
            this.textBoxGioiTinh.Location = new System.Drawing.Point(73, 36);
            this.textBoxGioiTinh.Name = "textBoxGioiTinh";
            this.textBoxGioiTinh.Size = new System.Drawing.Size(140, 26);
            this.textBoxGioiTinh.TabIndex = 12;
            this.textBoxGioiTinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Location = new System.Drawing.Point(3, 39);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(76, 20);
            this.labelGioiTinh.TabIndex = 11;
            this.labelGioiTinh.Text = "Giới Tính";
            // 
            // textBoxNgaySinh
            // 
            this.textBoxNgaySinh.Location = new System.Drawing.Point(678, 0);
            this.textBoxNgaySinh.Name = "textBoxNgaySinh";
            this.textBoxNgaySinh.Size = new System.Drawing.Size(140, 26);
            this.textBoxNgaySinh.TabIndex = 10;
            this.textBoxNgaySinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelngaySinh
            // 
            this.labelngaySinh.AutoSize = true;
            this.labelngaySinh.Location = new System.Drawing.Point(578, -1);
            this.labelngaySinh.Name = "labelngaySinh";
            this.labelngaySinh.Size = new System.Drawing.Size(85, 20);
            this.labelngaySinh.TabIndex = 9;
            this.labelngaySinh.Text = "Ngày Sinh";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(455, 1);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(107, 26);
            this.textBoxSDT.TabIndex = 8;
            this.textBoxSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelsdt
            // 
            this.labelsdt.AutoSize = true;
            this.labelsdt.Location = new System.Drawing.Point(408, -1);
            this.labelsdt.Name = "labelsdt";
            this.labelsdt.Size = new System.Drawing.Size(43, 20);
            this.labelsdt.TabIndex = 7;
            this.labelsdt.Text = "SDT";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(211, 1);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(191, 26);
            this.textBoxHoTen.TabIndex = 6;
            this.textBoxHoTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(137, 4);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(64, 20);
            this.labelHoTen.TabIndex = 5;
            this.labelHoTen.Text = "Họ Tên";
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(64, 0);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(67, 26);
            this.textBoxMaNV.TabIndex = 4;
            this.textBoxMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMaNV.Location = new System.Drawing.Point(0, 0);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(60, 20);
            this.labelMaNV.TabIndex = 3;
            this.labelMaNV.Text = "Mã NV";
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 701);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEmployees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.FormEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonChinhsua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_maNQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ngáyinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_manv;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Label labelngaySinh;
        private System.Windows.Forms.Label labelsdt;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Label labelMaNQL;
        private System.Windows.Forms.TextBox textBoxGioiTinh;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.TextBox textBoxMaNQL;
        private System.Windows.Forms.TextBox textBoxNgaySinh;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.TextBox textBoxMaNV;
    }
}