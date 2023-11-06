namespace demo.Forms
{
    partial class FormChinhSuaNhanVien
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
            this.textBoxmaNQL = new System.Windows.Forms.TextBox();
            this.comboBox_gioitinh = new System.Windows.Forms.ComboBox();
            this.button_huy = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxmaNQL
            // 
            this.textBoxmaNQL.Location = new System.Drawing.Point(212, 315);
            this.textBoxmaNQL.Name = "textBoxmaNQL";
            this.textBoxmaNQL.Size = new System.Drawing.Size(232, 26);
            this.textBoxmaNQL.TabIndex = 46;
            // 
            // comboBox_gioitinh
            // 
            this.comboBox_gioitinh.FormattingEnabled = true;
            this.comboBox_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_gioitinh.Location = new System.Drawing.Point(212, 269);
            this.comboBox_gioitinh.Name = "comboBox_gioitinh";
            this.comboBox_gioitinh.Size = new System.Drawing.Size(162, 28);
            this.comboBox_gioitinh.TabIndex = 45;
            // 
            // button_huy
            // 
            this.button_huy.Location = new System.Drawing.Point(257, 381);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(137, 47);
            this.button_huy.TabIndex = 44;
            this.button_huy.Text = "Cancel";
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(116, 381);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(131, 47);
            this.button_save.TabIndex = 43;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dateTimePicker_ngaysinh
            // 
            this.dateTimePicker_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(212, 220);
            this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
            this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(232, 26);
            this.dateTimePicker_ngaysinh.TabIndex = 42;
            this.dateTimePicker_ngaysinh.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // labelMaNQL
            // 
            this.labelMaNQL.AutoSize = true;
            this.labelMaNQL.Location = new System.Drawing.Point(84, 321);
            this.labelMaNQL.Name = "labelMaNQL";
            this.labelMaNQL.Size = new System.Drawing.Size(67, 20);
            this.labelMaNQL.TabIndex = 41;
            this.labelMaNQL.Text = "Mã NQL";
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Location = new System.Drawing.Point(84, 277);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(71, 20);
            this.labelGioiTinh.TabIndex = 40;
            this.labelGioiTinh.Text = "Giới Tính";
            // 
            // labelngaySinh
            // 
            this.labelngaySinh.AutoSize = true;
            this.labelngaySinh.Location = new System.Drawing.Point(84, 225);
            this.labelngaySinh.Name = "labelngaySinh";
            this.labelngaySinh.Size = new System.Drawing.Size(81, 20);
            this.labelngaySinh.TabIndex = 39;
            this.labelngaySinh.Text = "Ngày Sinh";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(212, 171);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(232, 26);
            this.textBoxSDT.TabIndex = 38;
            // 
            // labelsdt
            // 
            this.labelsdt.AutoSize = true;
            this.labelsdt.Location = new System.Drawing.Point(84, 177);
            this.labelsdt.Name = "labelsdt";
            this.labelsdt.Size = new System.Drawing.Size(41, 20);
            this.labelsdt.TabIndex = 37;
            this.labelsdt.Text = "SDT";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(212, 126);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(232, 26);
            this.textBoxHoTen.TabIndex = 36;
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(84, 132);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(61, 20);
            this.labelHoTen.TabIndex = 35;
            this.labelHoTen.Text = "Họ Tên";
            // 
            // textBoxMaNV
            // 
            this.textBoxMaNV.Location = new System.Drawing.Point(212, 81);
            this.textBoxMaNV.Name = "textBoxMaNV";
            this.textBoxMaNV.Size = new System.Drawing.Size(232, 26);
            this.textBoxMaNV.TabIndex = 34;
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Location = new System.Drawing.Point(84, 87);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(57, 20);
            this.labelMaNV.TabIndex = 33;
            this.labelMaNV.Text = "Mã NV";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 39);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nhân Viên";
            // 
            // FormChinhSuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxmaNQL);
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
            this.Name = "FormChinhSuaNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chỉnh sửa thông tin";
            this.Load += new System.EventHandler(this.FormEdit_Employee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxmaNQL;
        private System.Windows.Forms.ComboBox comboBox_gioitinh;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.Button button_save;
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
        protected System.Windows.Forms.Label label1;
    }
}