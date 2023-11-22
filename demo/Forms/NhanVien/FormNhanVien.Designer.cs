namespace demo.Forms
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonChinhsua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.Column_manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ngáyinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_maNQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEdit = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonXoa
            // 
            this.buttonXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonXoa.Enabled = false;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Image = global::demo.Properties.Resources.cross32px;
            this.buttonXoa.Location = new System.Drawing.Point(1061, 0);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonXoa.Size = new System.Drawing.Size(104, 82);
            this.buttonXoa.TabIndex = 0;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonChinhsua
            // 
            this.buttonChinhsua.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonChinhsua.Enabled = false;
            this.buttonChinhsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChinhsua.Image = global::demo.Properties.Resources.edit32px;
            this.buttonChinhsua.Location = new System.Drawing.Point(916, 0);
            this.buttonChinhsua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonChinhsua.Name = "buttonChinhsua";
            this.buttonChinhsua.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonChinhsua.Size = new System.Drawing.Size(145, 82);
            this.buttonChinhsua.TabIndex = 1;
            this.buttonChinhsua.Text = "Chỉnh sửa";
            this.buttonChinhsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChinhsua.UseVisualStyleBackColor = true;
            this.buttonChinhsua.Click += new System.EventHandler(this.buttonChinhsua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = global::demo.Properties.Resources.plus32px_02;
            this.buttonThem.Location = new System.Drawing.Point(801, 0);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonThem.Size = new System.Drawing.Size(115, 82);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
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
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 62;
            this.dataGridViewEmployees.RowTemplate.Height = 28;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1167, 584);
            this.dataGridViewEmployees.TabIndex = 0;
            this.dataGridViewEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellClick);
            this.dataGridViewEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployees_CellContentClick);
            // 
            // Column_manv
            // 
            this.Column_manv.DataPropertyName = "maNV";
            this.Column_manv.HeaderText = "Mã NV";
            this.Column_manv.MinimumWidth = 8;
            this.Column_manv.Name = "Column_manv";
            this.Column_manv.ReadOnly = true;
            // 
            // Column_hoten
            // 
            this.Column_hoten.DataPropertyName = "hoTen";
            this.Column_hoten.HeaderText = "Họ Tên";
            this.Column_hoten.MinimumWidth = 8;
            this.Column_hoten.Name = "Column_hoten";
            this.Column_hoten.ReadOnly = true;
            // 
            // Column_sdt
            // 
            this.Column_sdt.DataPropertyName = "sdt";
            this.Column_sdt.HeaderText = "SDT";
            this.Column_sdt.MinimumWidth = 8;
            this.Column_sdt.Name = "Column_sdt";
            this.Column_sdt.ReadOnly = true;
            // 
            // Column_ngáyinh
            // 
            this.Column_ngáyinh.DataPropertyName = "ngaySinh";
            this.Column_ngáyinh.HeaderText = "Ngày Sinh";
            this.Column_ngáyinh.MinimumWidth = 8;
            this.Column_ngáyinh.Name = "Column_ngáyinh";
            this.Column_ngáyinh.ReadOnly = true;
            // 
            // Column_gioitinh
            // 
            this.Column_gioitinh.DataPropertyName = "gioiTinh";
            this.Column_gioitinh.HeaderText = "Giới Tính";
            this.Column_gioitinh.MinimumWidth = 8;
            this.Column_gioitinh.Name = "Column_gioitinh";
            this.Column_gioitinh.ReadOnly = true;
            // 
            // Column_maNQL
            // 
            this.Column_maNQL.DataPropertyName = "maNQL";
            this.Column_maNQL.HeaderText = "Mã NQL";
            this.Column_maNQL.MinimumWidth = 8;
            this.Column_maNQL.Name = "Column_maNQL";
            this.Column_maNQL.ReadOnly = true;
            // 
            // panelEdit
            // 
            this.panelEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEdit.Controls.Add(this.buttonThem);
            this.panelEdit.Controls.Add(this.buttonChinhsua);
            this.panelEdit.Controls.Add(this.buttonXoa);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEdit.Location = new System.Drawing.Point(0, 500);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1167, 84);
            this.panelEdit.TabIndex = 1;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1167, 584);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormNhanVien";
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.FormEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonChinhsua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ngáyinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_maNQL;
    }
}