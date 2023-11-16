namespace demo.Forms.Kho
{
    partial class FormThemPhieuNhap
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
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.textBox_maPN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_maTB = new System.Windows.Forms.ComboBox();
            this.comboBox_maNCC = new System.Windows.Forms.ComboBox();
            this.textBox_soLuong = new System.Windows.Forms.TextBox();
            this.textBox_TenNCC = new System.Windows.Forms.TextBox();
            this.textBox_Xuatxu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_TenTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(405, 526);
            this.Cancel_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(112, 55);
            this.Cancel_button.TabIndex = 26;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(284, 526);
            this.Save_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(112, 55);
            this.Save_button.TabIndex = 25;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // textBox_maPN
            // 
            this.textBox_maPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_maPN.Location = new System.Drawing.Point(357, 126);
            this.textBox_maPN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_maPN.Name = "textBox_maPN";
            this.textBox_maPN.Size = new System.Drawing.Size(240, 26);
            this.textBox_maPN.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 445);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Số Lượng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 292);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã NCC :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Mã Thiết Bị :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã Phiếu Nhập :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thêm Vào Kho";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_maTB
            // 
            this.comboBox_maTB.FormattingEnabled = true;
            this.comboBox_maTB.Location = new System.Drawing.Point(357, 181);
            this.comboBox_maTB.Name = "comboBox_maTB";
            this.comboBox_maTB.Size = new System.Drawing.Size(138, 28);
            this.comboBox_maTB.TabIndex = 27;
            this.comboBox_maTB.SelectedIndexChanged += new System.EventHandler(this.comboBox_maTB_SelectedIndexChanged);
            // 
            // comboBox_maNCC
            // 
            this.comboBox_maNCC.FormattingEnabled = true;
            this.comboBox_maNCC.Location = new System.Drawing.Point(357, 284);
            this.comboBox_maNCC.Name = "comboBox_maNCC";
            this.comboBox_maNCC.Size = new System.Drawing.Size(138, 28);
            this.comboBox_maNCC.TabIndex = 28;
            this.comboBox_maNCC.SelectedIndexChanged += new System.EventHandler(this.comboBox_maNCC_SelectedIndexChanged);
            // 
            // textBox_soLuong
            // 
            this.textBox_soLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_soLuong.Location = new System.Drawing.Point(357, 439);
            this.textBox_soLuong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_soLuong.Name = "textBox_soLuong";
            this.textBox_soLuong.Size = new System.Drawing.Size(240, 26);
            this.textBox_soLuong.TabIndex = 24;
            this.textBox_soLuong.Text = "1";
            // 
            // textBox_TenNCC
            // 
            this.textBox_TenNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TenNCC.Location = new System.Drawing.Point(357, 338);
            this.textBox_TenNCC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TenNCC.Name = "textBox_TenNCC";
            this.textBox_TenNCC.Size = new System.Drawing.Size(240, 26);
            this.textBox_TenNCC.TabIndex = 29;
            // 
            // textBox_Xuatxu
            // 
            this.textBox_Xuatxu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Xuatxu.Location = new System.Drawing.Point(357, 391);
            this.textBox_Xuatxu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Xuatxu.Name = "textBox_Xuatxu";
            this.textBox_Xuatxu.Size = new System.Drawing.Size(240, 26);
            this.textBox_Xuatxu.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 344);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tên NCC :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 397);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Xuất xứ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 238);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Tên TB:";
            // 
            // textBox_TenTB
            // 
            this.textBox_TenTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_TenTB.Location = new System.Drawing.Point(357, 232);
            this.textBox_TenTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TenTB.Name = "textBox_TenTB";
            this.textBox_TenTB.Size = new System.Drawing.Size(442, 26);
            this.textBox_TenTB.TabIndex = 33;
            // 
            // FormThemPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 595);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_TenTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Xuatxu);
            this.Controls.Add(this.textBox_TenNCC);
            this.Controls.Add(this.comboBox_maNCC);
            this.Controls.Add(this.comboBox_maTB);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.textBox_soLuong);
            this.Controls.Add(this.textBox_maPN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormThemPhieuNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemPhieuNhap";
            this.Load += new System.EventHandler(this.FormThemPhieuNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.TextBox textBox_maPN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_maTB;
        private System.Windows.Forms.ComboBox comboBox_maNCC;
        private System.Windows.Forms.TextBox textBox_soLuong;
        private System.Windows.Forms.TextBox textBox_TenNCC;
        private System.Windows.Forms.TextBox textBox_Xuatxu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_TenTB;
    }
}