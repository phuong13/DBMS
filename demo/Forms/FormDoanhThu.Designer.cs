namespace demo.Forms
{
    partial class FormDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoanhThu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XemDoanhThu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.textbox_doanhthu = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 562);
            this.panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.textbox_doanhthu);
            this.groupBox1.Controls.Add(this.dateTimePicker_end);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker_start);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_XemDoanhThu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(194, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(100, 3, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 412);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh Thu Cửa Hàng";
            // 
            // btn_XemDoanhThu
            // 
            this.btn_XemDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemDoanhThu.Location = new System.Drawing.Point(212, 223);
            this.btn_XemDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_XemDoanhThu.Name = "btn_XemDoanhThu";
            this.btn_XemDoanhThu.Size = new System.Drawing.Size(252, 51);
            this.btn_XemDoanhThu.TabIndex = 1;
            this.btn_XemDoanhThu.Text = "Xem Doanh Thu";
            this.btn_XemDoanhThu.UseVisualStyleBackColor = true;
            this.btn_XemDoanhThu.Click += new System.EventHandler(this.btn_XemDoanhThu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ ngày:";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_start.Location = new System.Drawing.Point(234, 105);
            this.dateTimePicker_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(318, 30);
            this.dateTimePicker_start.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đến ngày:";
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_end.Location = new System.Drawing.Point(234, 151);
            this.dateTimePicker_end.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(314, 30);
            this.dateTimePicker_end.TabIndex = 6;
            // 
            // textbox_doanhthu
            // 
            this.textbox_doanhthu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_doanhthu.Location = new System.Drawing.Point(212, 330);
            this.textbox_doanhthu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textbox_doanhthu.Name = "textbox_doanhthu";
            this.textbox_doanhthu.Size = new System.Drawing.Size(252, 34);
            this.textbox_doanhthu.TabIndex = 7;
            this.textbox_doanhthu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 562);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textbox_doanhthu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_XemDoanhThu;
        private System.Windows.Forms.Label label1;
    }
}