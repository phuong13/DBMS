﻿namespace demo.Forms
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
            this.txt_searchProduct = new System.Windows.Forms.TextBox();
            this.dg_DanhMucSanPham = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DanhMucSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDeskTop
            // 
            this.buttonDeskTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDeskTop.Location = new System.Drawing.Point(156, 0);
            this.buttonDeskTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeskTop.Name = "buttonDeskTop";
            this.buttonDeskTop.Size = new System.Drawing.Size(159, 64);
            this.buttonDeskTop.TabIndex = 2;
            this.buttonDeskTop.Text = "Máy tính bàn";
            this.buttonDeskTop.UseVisualStyleBackColor = true;
            this.buttonDeskTop.Click += new System.EventHandler(this.buttonDeskTop_Click);
            // 
            // buttonBanPhim
            // 
            this.buttonBanPhim.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBanPhim.Location = new System.Drawing.Point(315, 0);
            this.buttonBanPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBanPhim.Name = "buttonBanPhim";
            this.buttonBanPhim.Size = new System.Drawing.Size(156, 64);
            this.buttonBanPhim.TabIndex = 3;
            this.buttonBanPhim.Text = "Bàn Phím";
            this.buttonBanPhim.UseVisualStyleBackColor = true;
            this.buttonBanPhim.Click += new System.EventHandler(this.buttonBanPhim_Click);
            // 
            // buttonChuot
            // 
            this.buttonChuot.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonChuot.Location = new System.Drawing.Point(471, 0);
            this.buttonChuot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChuot.Name = "buttonChuot";
            this.buttonChuot.Size = new System.Drawing.Size(159, 64);
            this.buttonChuot.TabIndex = 4;
            this.buttonChuot.Text = "Chuột";
            this.buttonChuot.UseVisualStyleBackColor = true;
            this.buttonChuot.Click += new System.EventHandler(this.buttonChuot_Click);
            // 
            // buttonTaiNghe
            // 
            this.buttonTaiNghe.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTaiNghe.Location = new System.Drawing.Point(630, 0);
            this.buttonTaiNghe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTaiNghe.Name = "buttonTaiNghe";
            this.buttonTaiNghe.Size = new System.Drawing.Size(150, 64);
            this.buttonTaiNghe.TabIndex = 5;
            this.buttonTaiNghe.Text = "Tai Nghe";
            this.buttonTaiNghe.UseVisualStyleBackColor = true;
            this.buttonTaiNghe.Click += new System.EventHandler(this.buttonTaiNghe_Click);
            // 
            // buttonManHinh
            // 
            this.buttonManHinh.AutoSize = true;
            this.buttonManHinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonManHinh.Location = new System.Drawing.Point(780, 0);
            this.buttonManHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonManHinh.Name = "buttonManHinh";
            this.buttonManHinh.Size = new System.Drawing.Size(166, 64);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1167, 64);
            this.panel1.TabIndex = 0;
            // 
            // buttonLapTop
            // 
            this.buttonLapTop.BackColor = System.Drawing.Color.Transparent;
            this.buttonLapTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLapTop.Location = new System.Drawing.Point(0, 0);
            this.buttonLapTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLapTop.Name = "buttonLapTop";
            this.buttonLapTop.Size = new System.Drawing.Size(156, 64);
            this.buttonLapTop.TabIndex = 1;
            this.buttonLapTop.Text = "Laptop";
            this.buttonLapTop.UseVisualStyleBackColor = false;
            this.buttonLapTop.Click += new System.EventHandler(this.buttonLapTop_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txt_searchProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 32);
            this.panel2.TabIndex = 1;
            // 
            // txt_searchProduct
            // 
            this.txt_searchProduct.Location = new System.Drawing.Point(11, 5);
            this.txt_searchProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_searchProduct.Name = "txt_searchProduct";
            this.txt_searchProduct.Size = new System.Drawing.Size(89, 22);
            this.txt_searchProduct.TabIndex = 0;
            this.txt_searchProduct.Text = "Search";
            // 
            // dg_DanhMucSanPham
            // 
            this.dg_DanhMucSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_DanhMucSanPham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dg_DanhMucSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DanhMucSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_DanhMucSanPham.Location = new System.Drawing.Point(0, 96);
            this.dg_DanhMucSanPham.Name = "dg_DanhMucSanPham";
            this.dg_DanhMucSanPham.RowHeadersWidth = 51;
            this.dg_DanhMucSanPham.RowTemplate.Height = 24;
            this.dg_DanhMucSanPham.Size = new System.Drawing.Size(1167, 488);
            this.dg_DanhMucSanPham.TabIndex = 2;
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1167, 584);
            this.Controls.Add(this.dg_DanhMucSanPham);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDanhMuc";
            this.Text = "Danh Mục Sản Phẩm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DanhMucSanPham)).EndInit();
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
        private System.Windows.Forms.TextBox txt_searchProduct;
        private System.Windows.Forms.DataGridView dg_DanhMucSanPham;
    }
}