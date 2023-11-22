namespace demo.Forms.HoaDon
{
    partial class FormThemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemHoaDon));
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_TenTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_maTB = new System.Windows.Forms.ComboBox();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.textBox_soLuong = new System.Windows.Forms.TextBox();
            this.textBox_maHD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_makh = new System.Windows.Forms.TextBox();
            this.textBox_dongia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_tenKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_nguoiLapHD = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 17);
            this.label9.TabIndex = 52;
            this.label9.Text = "Tên TB:";
            // 
            // textBox_TenTB
            // 
            this.textBox_TenTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TenTB.Location = new System.Drawing.Point(140, 146);
            this.textBox_TenTB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_TenTB.Name = "textBox_TenTB";
            this.textBox_TenTB.Size = new System.Drawing.Size(393, 22);
            this.textBox_TenTB.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(595, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 49;
            this.label5.Text = "Tên KH :";
            // 
            // comboBox_maTB
            // 
            this.comboBox_maTB.FormattingEnabled = true;
            this.comboBox_maTB.Location = new System.Drawing.Point(140, 106);
            this.comboBox_maTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_maTB.Name = "comboBox_maTB";
            this.comboBox_maTB.Size = new System.Drawing.Size(123, 24);
            this.comboBox_maTB.TabIndex = 45;
            this.comboBox_maTB.SelectedIndexChanged += new System.EventHandler(this.comboBox_maTB_SelectedIndexChanged);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_button.Image = global::demo.Properties.Resources.cross32px;
            this.Cancel_button.Location = new System.Drawing.Point(492, 338);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Cancel_button.Size = new System.Drawing.Size(100, 44);
            this.Cancel_button.TabIndex = 44;
            this.Cancel_button.Text = "Hủy";
            this.Cancel_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancel_button.UseVisualStyleBackColor = true;
            // 
            // Save_button
            // 
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.Image = global::demo.Properties.Resources.save32px_02;
            this.Save_button.Location = new System.Drawing.Point(385, 338);
            this.Save_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Save_button.Name = "Save_button";
            this.Save_button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Save_button.Size = new System.Drawing.Size(100, 44);
            this.Save_button.TabIndex = 43;
            this.Save_button.Text = "Lưu";
            this.Save_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // textBox_soLuong
            // 
            this.textBox_soLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_soLuong.Location = new System.Drawing.Point(137, 230);
            this.textBox_soLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_soLuong.Name = "textBox_soLuong";
            this.textBox_soLuong.Size = new System.Drawing.Size(214, 22);
            this.textBox_soLuong.TabIndex = 42;
            this.textBox_soLuong.Text = "1";
            // 
            // textBox_maHD
            // 
            this.textBox_maHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_maHD.Location = new System.Drawing.Point(140, 66);
            this.textBox_maHD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_maHD.Name = "textBox_maHD";
            this.textBox_maHD.Size = new System.Drawing.Size(214, 22);
            this.textBox_maHD.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 40;
            this.label7.Text = "Số Lượng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Mã Thiết Bị :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mã Hóa Đơn :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Thêm Hóa Đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(596, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 54;
            this.label4.Text = "Mã KH :";
            // 
            // textBox_makh
            // 
            this.textBox_makh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_makh.Location = new System.Drawing.Point(732, 121);
            this.textBox_makh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_makh.Name = "textBox_makh";
            this.textBox_makh.Size = new System.Drawing.Size(89, 22);
            this.textBox_makh.TabIndex = 55;
            // 
            // textBox_dongia
            // 
            this.textBox_dongia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_dongia.Location = new System.Drawing.Point(139, 190);
            this.textBox_dongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_dongia.Name = "textBox_dongia";
            this.textBox_dongia.Size = new System.Drawing.Size(89, 22);
            this.textBox_dongia.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 56;
            this.label6.Text = "Đơn giá";
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_sdt.Location = new System.Drawing.Point(732, 162);
            this.textBox_sdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(221, 22);
            this.textBox_sdt.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 162);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Số điện thoại";
            // 
            // textBox_tenKH
            // 
            this.textBox_tenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_tenKH.Location = new System.Drawing.Point(732, 205);
            this.textBox_tenKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_tenKH.Name = "textBox_tenKH";
            this.textBox_tenKH.Size = new System.Drawing.Size(222, 22);
            this.textBox_tenKH.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-3, 1);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 61;
            this.label10.Text = "Mã Nhân Viên";
            // 
            // comboBox_nguoiLapHD
            // 
            this.comboBox_nguoiLapHD.FormattingEnabled = true;
            this.comboBox_nguoiLapHD.Location = new System.Drawing.Point(124, -2);
            this.comboBox_nguoiLapHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_nguoiLapHD.Name = "comboBox_nguoiLapHD";
            this.comboBox_nguoiLapHD.Size = new System.Drawing.Size(123, 24);
            this.comboBox_nguoiLapHD.TabIndex = 62;
            // 
            // FormThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 434);
            this.Controls.Add(this.comboBox_nguoiLapHD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_tenKH);
            this.Controls.Add(this.textBox_sdt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_dongia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_makh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_TenTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_maTB);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.textBox_soLuong);
            this.Controls.Add(this.textBox_maHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormThemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemHoaDon";
            this.Load += new System.EventHandler(this.FormThemHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_TenTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_maTB;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox textBox_soLuong;
        private System.Windows.Forms.TextBox textBox_maHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_makh;
        private System.Windows.Forms.TextBox textBox_dongia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_tenKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_nguoiLapHD;
    }
}