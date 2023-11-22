namespace demo.Forms.Customer
{
    partial class FormKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonChinhsua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.Column_makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hotenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThem
            // 
            this.buttonThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = global::demo.Properties.Resources.plus32px_02;
            this.buttonThem.Location = new System.Drawing.Point(797, 0);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonThem.Size = new System.Drawing.Size(117, 82);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonChinhsua
            // 
            this.buttonChinhsua.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonChinhsua.Enabled = false;
            this.buttonChinhsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChinhsua.Image = global::demo.Properties.Resources.edit32px;
            this.buttonChinhsua.Location = new System.Drawing.Point(914, 0);
            this.buttonChinhsua.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChinhsua.Name = "buttonChinhsua";
            this.buttonChinhsua.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonChinhsua.Size = new System.Drawing.Size(147, 82);
            this.buttonChinhsua.TabIndex = 1;
            this.buttonChinhsua.Text = "Chỉnh sửa";
            this.buttonChinhsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonChinhsua.UseVisualStyleBackColor = true;
            this.buttonChinhsua.Click += new System.EventHandler(this.buttonChinhsua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonXoa.Enabled = false;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Image = global::demo.Properties.Resources.cross32px;
            this.buttonXoa.Location = new System.Drawing.Point(1061, 0);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonXoa.Size = new System.Drawing.Size(104, 82);
            this.buttonXoa.TabIndex = 0;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEdit.Controls.Add(this.buttonThem);
            this.panelEdit.Controls.Add(this.buttonChinhsua);
            this.panelEdit.Controls.Add(this.buttonXoa);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEdit.Location = new System.Drawing.Point(0, 500);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(2);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1167, 84);
            this.panelEdit.TabIndex = 1;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_makh,
            this.Column_hotenKH,
            this.col_sdt,
            this.Column_ngaysinh});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCustomer.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.ReadOnly = true;
            this.dataGridViewCustomer.RowHeadersWidth = 62;
            this.dataGridViewCustomer.RowTemplate.Height = 28;
            this.dataGridViewCustomer.Size = new System.Drawing.Size(1167, 584);
            this.dataGridViewCustomer.TabIndex = 2;
            this.dataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellClick);
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentClick);
            // 
            // Column_makh
            // 
            this.Column_makh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column_makh.DataPropertyName = "maKH";
            this.Column_makh.HeaderText = "Mã KH";
            this.Column_makh.MinimumWidth = 10;
            this.Column_makh.Name = "Column_makh";
            this.Column_makh.ReadOnly = true;
            this.Column_makh.Width = 150;
            // 
            // Column_hotenKH
            // 
            this.Column_hotenKH.DataPropertyName = "tenKH";
            this.Column_hotenKH.HeaderText = "Họ tên khách hàng";
            this.Column_hotenKH.MinimumWidth = 10;
            this.Column_hotenKH.Name = "Column_hotenKH";
            this.Column_hotenKH.ReadOnly = true;
            // 
            // col_sdt
            // 
            this.col_sdt.DataPropertyName = "sdt";
            this.col_sdt.HeaderText = "SDT";
            this.col_sdt.MinimumWidth = 10;
            this.col_sdt.Name = "col_sdt";
            this.col_sdt.ReadOnly = true;
            // 
            // Column_ngaysinh
            // 
            this.Column_ngaysinh.DataPropertyName = "ngaySinh";
            this.Column_ngaysinh.HeaderText = "Ngày Sinh";
            this.Column_ngaysinh.MinimumWidth = 10;
            this.Column_ngaysinh.Name = "Column_ngaysinh";
            this.Column_ngaysinh.ReadOnly = true;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1167, 584);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.panelEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonChinhsua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_makh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hotenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ngaysinh;
    }
}