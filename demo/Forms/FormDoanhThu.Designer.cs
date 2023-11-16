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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XemDoanhThu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.textbox_doanhthu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doanh Thu Cửa Hàng";
            // 
            // btn_XemDoanhThu
            // 
            this.btn_XemDoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XemDoanhThu.Location = new System.Drawing.Point(408, 265);
            this.btn_XemDoanhThu.Name = "btn_XemDoanhThu";
            this.btn_XemDoanhThu.Size = new System.Drawing.Size(258, 54);
            this.btn_XemDoanhThu.TabIndex = 1;
            this.btn_XemDoanhThu.Text = "Xem Doanh Thu";
            this.btn_XemDoanhThu.UseVisualStyleBackColor = true;
            this.btn_XemDoanhThu.Click += new System.EventHandler(this.btn_XemDoanhThu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "Từ ngày:";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_start.Location = new System.Drawing.Point(292, 156);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(240, 34);
            this.dateTimePicker_start.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Từ ngày:";
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_end.Location = new System.Drawing.Point(689, 158);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(242, 34);
            this.dateTimePicker_end.TabIndex = 6;
            // 
            // textbox_doanhthu
            // 
            this.textbox_doanhthu.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_doanhthu.Location = new System.Drawing.Point(408, 409);
            this.textbox_doanhthu.Name = "textbox_doanhthu";
            this.textbox_doanhthu.Size = new System.Drawing.Size(258, 45);
            this.textbox_doanhthu.TabIndex = 7;
            // 
            // FormDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 575);
            this.Controls.Add(this.textbox_doanhthu);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_XemDoanhThu);
            this.Controls.Add(this.label1);
            this.Name = "FormDoanhThu";
            this.Text = "Doanh Thu";
            this.Load += new System.EventHandler(this.FormAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_XemDoanhThu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.TextBox textbox_doanhthu;
    }
}