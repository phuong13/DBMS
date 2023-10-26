namespace demo.Forms
{
    partial class FormDanhMuc
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
            this.buttonDeskTop = new System.Windows.Forms.Button();
            this.buttonBanPhim = new System.Windows.Forms.Button();
            this.buttonChuot = new System.Windows.Forms.Button();
            this.buttonTaiNghe = new System.Windows.Forms.Button();
            this.buttonManHinh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLapTop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDeskTop
            // 
            this.buttonDeskTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDeskTop.Location = new System.Drawing.Point(175, 0);
            this.buttonDeskTop.Name = "buttonDeskTop";
            this.buttonDeskTop.Size = new System.Drawing.Size(175, 80);
            this.buttonDeskTop.TabIndex = 2;
            this.buttonDeskTop.Text = "DeskTop";
            this.buttonDeskTop.UseVisualStyleBackColor = true;
            this.buttonDeskTop.Click += new System.EventHandler(this.buttonDeskTop_Click);
            // 
            // buttonBanPhim
            // 
            this.buttonBanPhim.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBanPhim.Location = new System.Drawing.Point(350, 0);
            this.buttonBanPhim.Name = "buttonBanPhim";
            this.buttonBanPhim.Size = new System.Drawing.Size(175, 80);
            this.buttonBanPhim.TabIndex = 3;
            this.buttonBanPhim.Text = "Bàn Phím";
            this.buttonBanPhim.UseVisualStyleBackColor = true;
            this.buttonBanPhim.Click += new System.EventHandler(this.buttonBanPhim_Click);
            // 
            // buttonChuot
            // 
            this.buttonChuot.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonChuot.Location = new System.Drawing.Point(525, 0);
            this.buttonChuot.Name = "buttonChuot";
            this.buttonChuot.Size = new System.Drawing.Size(175, 80);
            this.buttonChuot.TabIndex = 4;
            this.buttonChuot.Text = "Chuột";
            this.buttonChuot.UseVisualStyleBackColor = true;
            this.buttonChuot.Click += new System.EventHandler(this.buttonChuot_Click);
            // 
            // buttonTaiNghe
            // 
            this.buttonTaiNghe.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTaiNghe.Location = new System.Drawing.Point(700, 0);
            this.buttonTaiNghe.Name = "buttonTaiNghe";
            this.buttonTaiNghe.Size = new System.Drawing.Size(175, 80);
            this.buttonTaiNghe.TabIndex = 5;
            this.buttonTaiNghe.Text = "Tai Nghe";
            this.buttonTaiNghe.UseVisualStyleBackColor = true;
            this.buttonTaiNghe.Click += new System.EventHandler(this.buttonTaiNghe_Click);
            // 
            // buttonManHinh
            // 
            this.buttonManHinh.AutoSize = true;
            this.buttonManHinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonManHinh.Location = new System.Drawing.Point(875, 0);
            this.buttonManHinh.Name = "buttonManHinh";
            this.buttonManHinh.Size = new System.Drawing.Size(175, 80);
            this.buttonManHinh.TabIndex = 6;
            this.buttonManHinh.Text = "Màn Hình";
            this.buttonManHinh.UseVisualStyleBackColor = true;
            this.buttonManHinh.Click += new System.EventHandler(this.buttonManHinh_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.buttonManHinh);
            this.panel1.Controls.Add(this.buttonTaiNghe);
            this.panel1.Controls.Add(this.buttonChuot);
            this.panel1.Controls.Add(this.buttonBanPhim);
            this.panel1.Controls.Add(this.buttonDeskTop);
            this.panel1.Controls.Add(this.buttonLapTop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 80);
            this.panel1.TabIndex = 0;
            // 
            // buttonLapTop
            // 
            this.buttonLapTop.BackColor = System.Drawing.Color.Transparent;
            this.buttonLapTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLapTop.Location = new System.Drawing.Point(0, 0);
            this.buttonLapTop.Name = "buttonLapTop";
            this.buttonLapTop.Size = new System.Drawing.Size(175, 80);
            this.buttonLapTop.TabIndex = 1;
            this.buttonLapTop.Text = "LapTop";
            this.buttonLapTop.UseVisualStyleBackColor = false;
            this.buttonLapTop.Click += new System.EventHandler(this.buttonLapTop_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 40);
            this.panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "search";
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 543);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDanhMuc";
            this.Text = "DanhMuc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDeskTop;
        private System.Windows.Forms.Button buttonBanPhim;
        private System.Windows.Forms.Button buttonChuot;
        private System.Windows.Forms.Button buttonTaiNghe;
        private System.Windows.Forms.Button buttonManHinh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonLapTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
    }
}