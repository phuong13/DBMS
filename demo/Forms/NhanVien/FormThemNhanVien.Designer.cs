namespace demo.Forms
{
    partial class FormThemNhanVien
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
            this.dateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.labelMaNQL = new System.Windows.Forms.Label();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.labelngaySinh = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.labelsdt = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.textBoxMaNV = new System.Windows.Forms.TextBox();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_huy = new System.Windows.Forms.Button();
            this.comboBox_gioitinh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_maNQL = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePicker_ngaysinh
            // 
            this.dateTimePicker_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(172, 231);
            this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
            this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(246, 26);
            this.dateTimePicker_ngaysinh.TabIndex = 23;
            this.dateTimePicker_ngaysinh.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // labelMaNQL
            // 
            this.labelMaNQL.AutoSize = true;
            this.labelMaNQL.Location = new System.Drawing.Point(44, 332);
            this.labelMaNQL.Name = "labelMaNQL";
            this.labelMaNQL.Size = new System.Drawing.Size(67, 20);
            this.labelMaNQL.TabIndex = 26;
            this.labelMaNQL.Text = "Mã NQL";
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Location = new System.Drawing.Point(44, 288);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.labelGioiTinh.TabIndex = 24;
            this.labelGioiTinh.Text = "Giới Tính";
            // 
            // labelngaySinh
            // 
            this.labelngaySinh.AutoSize = true;
            this.labelngaySinh.Location = new System.Drawing.Point(44, 236);
            this.labelngaySinh.Name = "labelngaySinh";
            this.labelngaySinh.Size = new System.Drawing.Size(81, 20);
            this.labelngaySinh.TabIndex = 22;
            this.labelngaySinh.Text = "Ngày Sinh";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(172, 182);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(246, 26);
            this.textBoxSDT.TabIndex = 21;
            // 
            // labelsdt
            // 
            this.labelsdt.AutoSize = true;
            this.labelsdt.Location = new System.Drawing.Point(44, 188);
            this.labelsdt.Name = "labelsdt";
            this.labelsdt.Size = new System.Drawing.Size(41, 20);
            this.labelsdt.TabIndex = 20;
            this.labelsdt.Text = "SDT";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(172, 137);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(246, 26);
            this.textBoxHoTen.TabIndex = 19;
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(44, 143);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(61, 20);
            this.labelHoTen.TabIndex = 18;
            this.labelHoTen.Text = "Họ Tên";
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(172, 92);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(246, 26);
            this.textBoxMaNV.TabIndex = 17;
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Location = new System.Drawing.Point(44, 98);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(57, 20);
            this.labelMaNV.TabIndex = 16;
            this.labelMaNV.Text = "Mã NV";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(76, 403);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(145, 48);
            this.button_save.TabIndex = 28;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_huy
            // 
            this.button_huy.Location = new System.Drawing.Point(227, 403);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(146, 48);
            this.button_huy.TabIndex = 29;
            this.button_huy.Text = "Cancel";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // comboBox_gioitinh
            // 
            this.comboBox_gioitinh.FormattingEnabled = true;
            this.comboBox_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_gioitinh.Location = new System.Drawing.Point(172, 280);
            this.comboBox_gioitinh.Name = "comboBox_gioitinh";
            this.comboBox_gioitinh.Size = new System.Drawing.Size(176, 28);
            this.comboBox_gioitinh.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 30);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nhân Viên";
            // 
            // comboBox_maNQL
            // 
            this.comboBox_maNQL.FormattingEnabled = true;
            this.comboBox_maNQL.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_maNQL.Location = new System.Drawing.Point(172, 329);
            this.comboBox_maNQL.Name = "comboBox_maNQL";
            this.comboBox_maNQL.Size = new System.Drawing.Size(176, 28);
            this.comboBox_maNQL.TabIndex = 34;
            // 
            // FormThemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 505);
            this.Controls.Add(this.comboBox_maNQL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_gioitinh);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dateTimePicker_ngaysinh);
            this.Controls.Add(this.labelMaNQL);
            this.Controls.Add(this.labelGioiTinh);
            this.Controls.Add(this.labelngaySinh);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.labelsdt);
            this.Controls.Add(this.textBoxHoTen);
            this.Controls.Add(this.labelHoTen);
            this.Controls.Add(this.textBoxMaNV);
            this.Controls.Add(this.labelMaNV);
            this.Name = "FormThemNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhân viên";
            this.Load += new System.EventHandler(this.FormADD_Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh;
        private System.Windows.Forms.Label labelMaNQL;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.Label labelngaySinh;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.Label labelsdt;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.TextBox textBoxMaNV;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.ComboBox comboBox_gioitinh;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_maNQL;
    }
}