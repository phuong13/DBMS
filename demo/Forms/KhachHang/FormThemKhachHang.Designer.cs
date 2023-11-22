namespace demo.Forms.Customer
{
    partial class FormThemKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemKhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.button_huy = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.dateTimePicker_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.labelngaySinh = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.labelsdt = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 43);
            this.label1.TabIndex = 62;
            this.label1.Text = "Khách hàng";
            // 
            // button_huy
            // 
            this.button_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huy.Image = global::demo.Properties.Resources.cross32px;
            this.button_huy.Location = new System.Drawing.Point(239, 262);
            this.button_huy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_huy.Name = "button_huy";
            this.button_huy.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button_huy.Size = new System.Drawing.Size(116, 48);
            this.button_huy.TabIndex = 59;
            this.button_huy.Text = "Hủy";
            this.button_huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_huy.UseVisualStyleBackColor = true;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Image = global::demo.Properties.Resources.save32px_02;
            this.button_save.Location = new System.Drawing.Point(114, 262);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save.Name = "button_save";
            this.button_save.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button_save.Size = new System.Drawing.Size(116, 48);
            this.button_save.TabIndex = 58;
            this.button_save.Text = "Lưu";
            this.button_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // dateTimePicker_ngaysinh
            // 
            this.dateTimePicker_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_ngaysinh.Location = new System.Drawing.Point(198, 190);
            this.dateTimePicker_ngaysinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_ngaysinh.Name = "dateTimePicker_ngaysinh";
            this.dateTimePicker_ngaysinh.Size = new System.Drawing.Size(207, 22);
            this.dateTimePicker_ngaysinh.TabIndex = 57;
            this.dateTimePicker_ngaysinh.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // labelngaySinh
            // 
            this.labelngaySinh.AutoSize = true;
            this.labelngaySinh.Location = new System.Drawing.Point(84, 194);
            this.labelngaySinh.Name = "labelngaySinh";
            this.labelngaySinh.Size = new System.Drawing.Size(73, 17);
            this.labelngaySinh.TabIndex = 54;
            this.labelngaySinh.Text = "Ngày Sinh";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(198, 151);
            this.textBoxSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(207, 22);
            this.textBoxSDT.TabIndex = 53;
            // 
            // labelsdt
            // 
            this.labelsdt.AutoSize = true;
            this.labelsdt.Location = new System.Drawing.Point(84, 156);
            this.labelsdt.Name = "labelsdt";
            this.labelsdt.Size = new System.Drawing.Size(36, 17);
            this.labelsdt.TabIndex = 52;
            this.labelsdt.Text = "SDT";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Location = new System.Drawing.Point(198, 115);
            this.textBoxHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(207, 22);
            this.textBoxHoTen.TabIndex = 51;
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Location = new System.Drawing.Point(84, 120);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(55, 17);
            this.labelHoTen.TabIndex = 50;
            this.labelHoTen.Text = "Họ Tên";
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(198, 79);
            this.textBoxMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(207, 22);
            this.textBoxMaKH.TabIndex = 49;
            // 
            // labelMaKH
            // 
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Location = new System.Drawing.Point(84, 84);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(50, 17);
            this.labelMaKH.TabIndex = 48;
            this.labelMaKH.Text = "Mã KH";
            // 
            // FormThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dateTimePicker_ngaysinh);
            this.Controls.Add(this.labelngaySinh);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.labelsdt);
            this.Controls.Add(this.textBoxHoTen);
            this.Controls.Add(this.labelHoTen);
            this.Controls.Add(this.textBoxMaKH);
            this.Controls.Add(this.labelMaKH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThemKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Khách hàng";
            this.Load += new System.EventHandler(this.FormADD_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngaysinh;
        private System.Windows.Forms.Label labelngaySinh;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.Label labelsdt;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.Label labelMaKH;
    }
}