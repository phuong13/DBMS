namespace demo.Forms.HoaDon
{
    partial class FormThemThietBiVaoHoaDon
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
            this.comboBox_maTB = new System.Windows.Forms.ComboBox();
            this.textBox_maHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_dongia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_TenTB = new System.Windows.Forms.TextBox();
            this.textBox_soLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_maTB
            // 
            this.comboBox_maTB.FormattingEnabled = true;
            this.comboBox_maTB.Location = new System.Drawing.Point(226, 115);
            this.comboBox_maTB.Name = "comboBox_maTB";
            this.comboBox_maTB.Size = new System.Drawing.Size(138, 28);
            this.comboBox_maTB.TabIndex = 49;
            this.comboBox_maTB.SelectedIndexChanged += new System.EventHandler(this.comboBox_maTB_SelectedIndexChanged);
            // 
            // textBox_maHD
            // 
            this.textBox_maHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_maHD.Location = new System.Drawing.Point(226, 71);
            this.textBox_maHD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_maHD.Name = "textBox_maHD";
            this.textBox_maHD.ReadOnly = true;
            this.textBox_maHD.Size = new System.Drawing.Size(240, 26);
            this.textBox_maHD.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã Thiết Bị :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Mã Hóa Đơn :";
            // 
            // textBox_dongia
            // 
            this.textBox_dongia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_dongia.Location = new System.Drawing.Point(225, 216);
            this.textBox_dongia.Name = "textBox_dongia";
            this.textBox_dongia.ReadOnly = true;
            this.textBox_dongia.Size = new System.Drawing.Size(100, 26);
            this.textBox_dongia.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 62;
            this.label6.Text = "Đơn giá";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 167);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 61;
            this.label9.Text = "Tên TB:";
            // 
            // textBox_TenTB
            // 
            this.textBox_TenTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TenTB.Location = new System.Drawing.Point(226, 161);
            this.textBox_TenTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TenTB.Name = "textBox_TenTB";
            this.textBox_TenTB.ReadOnly = true;
            this.textBox_TenTB.Size = new System.Drawing.Size(498, 26);
            this.textBox_TenTB.TabIndex = 60;
            // 
            // textBox_soLuong
            // 
            this.textBox_soLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_soLuong.Location = new System.Drawing.Point(223, 266);
            this.textBox_soLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_soLuong.Name = "textBox_soLuong";
            this.textBox_soLuong.Size = new System.Drawing.Size(240, 26);
            this.textBox_soLuong.TabIndex = 59;
            this.textBox_soLuong.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 272);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 58;
            this.label7.Text = "Số Lượng :";
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(368, 359);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(112, 55);
            this.Cancel_button.TabIndex = 65;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(247, 359);
            this.Save_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(112, 55);
            this.Save_button.TabIndex = 64;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // FormThemThietBiVaoHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 490);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.textBox_dongia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_TenTB);
            this.Controls.Add(this.textBox_soLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_maTB);
            this.Controls.Add(this.textBox_maHD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormThemThietBiVaoHoaDon";
            this.Text = "FormThemThietBiVaoHoaDon";
            this.Load += new System.EventHandler(this.FormThemThietBiVaoHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_maTB;
        private System.Windows.Forms.TextBox textBox_maHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_dongia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_TenTB;
        private System.Windows.Forms.TextBox textBox_soLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Save_button;
    }
}