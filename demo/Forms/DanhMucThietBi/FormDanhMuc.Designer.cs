namespace demo.Forms.DanhMucThietBi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhMuc));
            this.panel_DanhMuc = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_searchProduct = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_thongTinThietBi = new System.Windows.Forms.Panel();
            this.dg_DanhMucSanPham = new System.Windows.Forms.DataGridView();
            this.pictureBox_thietBi = new System.Windows.Forms.PictureBox();
            this.btn_suaThietBi = new System.Windows.Forms.Button();
            this.btn_xoaThietBi = new System.Windows.Forms.Button();
            this.btn_themThietBi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonManHinh = new System.Windows.Forms.Button();
            this.buttonTaiNghe = new System.Windows.Forms.Button();
            this.buttonChuot = new System.Windows.Forms.Button();
            this.buttonBanPhim = new System.Windows.Forms.Button();
            this.buttonDeskTop = new System.Windows.Forms.Button();
            this.buttonLapTop = new System.Windows.Forms.Button();
            this.saveFileExcel = new System.Windows.Forms.SaveFileDialog();
            this.panel_DanhMuc.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_thongTinThietBi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_DanhMucSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_thietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_DanhMuc
            // 
            this.panel_DanhMuc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_DanhMuc.Controls.Add(this.button2);
            this.panel_DanhMuc.Controls.Add(this.buttonManHinh);
            this.panel_DanhMuc.Controls.Add(this.buttonTaiNghe);
            this.panel_DanhMuc.Controls.Add(this.buttonChuot);
            this.panel_DanhMuc.Controls.Add(this.buttonBanPhim);
            this.panel_DanhMuc.Controls.Add(this.buttonDeskTop);
            this.panel_DanhMuc.Controls.Add(this.buttonLapTop);
            this.panel_DanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_DanhMuc.Location = new System.Drawing.Point(0, 0);
            this.panel_DanhMuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_DanhMuc.Name = "panel_DanhMuc";
            this.panel_DanhMuc.Size = new System.Drawing.Size(1167, 64);
            this.panel_DanhMuc.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button1);
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
            this.txt_searchProduct.Location = new System.Drawing.Point(12, 4);
            this.txt_searchProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_searchProduct.Name = "txt_searchProduct";
            this.txt_searchProduct.Size = new System.Drawing.Size(247, 22);
            this.txt_searchProduct.TabIndex = 0;
            this.txt_searchProduct.TextChanged += new System.EventHandler(this.txt_searchProduct_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_suaThietBi);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.btn_xoaThietBi);
            this.panel3.Controls.Add(this.btn_themThietBi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 504);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1167, 80);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tổng thiết bị";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(69, 42);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel_thongTinThietBi
            // 
            this.panel_thongTinThietBi.Controls.Add(this.pictureBox_thietBi);
            this.panel_thongTinThietBi.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_thongTinThietBi.Location = new System.Drawing.Point(0, 96);
            this.panel_thongTinThietBi.Name = "panel_thongTinThietBi";
            this.panel_thongTinThietBi.Size = new System.Drawing.Size(329, 408);
            this.panel_thongTinThietBi.TabIndex = 5;
            // 
            // dg_DanhMucSanPham
            // 
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_DanhMucSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dg_DanhMucSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_DanhMucSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_DanhMucSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_DanhMucSanPham.Location = new System.Drawing.Point(329, 96);
            this.dg_DanhMucSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dg_DanhMucSanPham.Name = "dg_DanhMucSanPham";
            this.dg_DanhMucSanPham.ReadOnly = true;
            this.dg_DanhMucSanPham.RowHeadersWidth = 51;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dg_DanhMucSanPham.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dg_DanhMucSanPham.RowTemplate.Height = 24;
            this.dg_DanhMucSanPham.Size = new System.Drawing.Size(838, 408);
            this.dg_DanhMucSanPham.TabIndex = 2;
            this.dg_DanhMucSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_DanhMucSanPham_CellClick);
            // 
            // pictureBox_thietBi
            // 
            this.pictureBox_thietBi.Location = new System.Drawing.Point(12, 51);
            this.pictureBox_thietBi.Name = "pictureBox_thietBi";
            this.pictureBox_thietBi.Size = new System.Drawing.Size(300, 300);
            this.pictureBox_thietBi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_thietBi.TabIndex = 0;
            this.pictureBox_thietBi.TabStop = false;
            // 
            // btn_suaThietBi
            // 
            this.btn_suaThietBi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_suaThietBi.Enabled = false;
            this.btn_suaThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suaThietBi.Image = global::demo.Properties.Resources.edit32px;
            this.btn_suaThietBi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suaThietBi.Location = new System.Drawing.Point(790, 0);
            this.btn_suaThietBi.Name = "btn_suaThietBi";
            this.btn_suaThietBi.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_suaThietBi.Size = new System.Drawing.Size(145, 80);
            this.btn_suaThietBi.TabIndex = 6;
            this.btn_suaThietBi.Text = "Chỉnh sửa";
            this.btn_suaThietBi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suaThietBi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_suaThietBi.UseVisualStyleBackColor = true;
            this.btn_suaThietBi.Click += new System.EventHandler(this.btn_suaThietBi_Click_1);
            // 
            // btn_xoaThietBi
            // 
            this.btn_xoaThietBi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_xoaThietBi.Enabled = false;
            this.btn_xoaThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaThietBi.Image = global::demo.Properties.Resources.cross32px;
            this.btn_xoaThietBi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoaThietBi.Location = new System.Drawing.Point(935, 0);
            this.btn_xoaThietBi.Name = "btn_xoaThietBi";
            this.btn_xoaThietBi.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_xoaThietBi.Size = new System.Drawing.Size(113, 80);
            this.btn_xoaThietBi.TabIndex = 2;
            this.btn_xoaThietBi.Text = "Xóa";
            this.btn_xoaThietBi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoaThietBi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_xoaThietBi.UseVisualStyleBackColor = true;
            this.btn_xoaThietBi.Click += new System.EventHandler(this.btn_xoaThietBi_Click);
            // 
            // btn_themThietBi
            // 
            this.btn_themThietBi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_themThietBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themThietBi.Image = global::demo.Properties.Resources.plus32px_02;
            this.btn_themThietBi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themThietBi.Location = new System.Drawing.Point(1048, 0);
            this.btn_themThietBi.Name = "btn_themThietBi";
            this.btn_themThietBi.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_themThietBi.Size = new System.Drawing.Size(119, 80);
            this.btn_themThietBi.TabIndex = 0;
            this.btn_themThietBi.Text = "Thêm";
            this.btn_themThietBi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themThietBi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_themThietBi.UseVisualStyleBackColor = true;
            this.btn_themThietBi.Click += new System.EventHandler(this.btn_themThietBi_Click);
            // 
            // button1
            // 
            this.button1.Image = global::demo.Properties.Resources.magnifying_glass_16px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(184, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Tìm kiếm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::demo.Properties.Resources.filedownload32px;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1028, 0);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button2.Size = new System.Drawing.Size(139, 64);
            this.button2.TabIndex = 8;
            this.button2.Text = "Xuất file";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonManHinh
            // 
            this.buttonManHinh.AutoSize = true;
            this.buttonManHinh.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonManHinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonManHinh.Image = global::demo.Properties.Resources.monitor32px;
            this.buttonManHinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManHinh.Location = new System.Drawing.Point(702, 0);
            this.buttonManHinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonManHinh.Name = "buttonManHinh";
            this.buttonManHinh.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonManHinh.Size = new System.Drawing.Size(151, 64);
            this.buttonManHinh.TabIndex = 6;
            this.buttonManHinh.Text = "Màn Hình";
            this.buttonManHinh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonManHinh.UseVisualStyleBackColor = true;
            this.buttonManHinh.Click += new System.EventHandler(this.buttonManHinh_Click);
            // 
            // buttonTaiNghe
            // 
            this.buttonTaiNghe.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTaiNghe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTaiNghe.Image = global::demo.Properties.Resources.headphone32px;
            this.buttonTaiNghe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTaiNghe.Location = new System.Drawing.Point(556, 0);
            this.buttonTaiNghe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTaiNghe.Name = "buttonTaiNghe";
            this.buttonTaiNghe.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonTaiNghe.Size = new System.Drawing.Size(146, 64);
            this.buttonTaiNghe.TabIndex = 5;
            this.buttonTaiNghe.Text = "Tai Nghe";
            this.buttonTaiNghe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTaiNghe.UseVisualStyleBackColor = true;
            this.buttonTaiNghe.Click += new System.EventHandler(this.buttonTaiNghe_Click);
            // 
            // buttonChuot
            // 
            this.buttonChuot.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonChuot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChuot.Image = global::demo.Properties.Resources.mouse32px_02;
            this.buttonChuot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonChuot.Location = new System.Drawing.Point(448, 0);
            this.buttonChuot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChuot.Name = "buttonChuot";
            this.buttonChuot.Size = new System.Drawing.Size(108, 64);
            this.buttonChuot.TabIndex = 4;
            this.buttonChuot.Text = "Chuột";
            this.buttonChuot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonChuot.UseVisualStyleBackColor = true;
            this.buttonChuot.Click += new System.EventHandler(this.buttonChuot_Click);
            // 
            // buttonBanPhim
            // 
            this.buttonBanPhim.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBanPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBanPhim.Image = global::demo.Properties.Resources.keyboard32px_02;
            this.buttonBanPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBanPhim.Location = new System.Drawing.Point(298, 0);
            this.buttonBanPhim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBanPhim.Name = "buttonBanPhim";
            this.buttonBanPhim.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonBanPhim.Size = new System.Drawing.Size(150, 64);
            this.buttonBanPhim.TabIndex = 3;
            this.buttonBanPhim.Text = "Bàn Phím";
            this.buttonBanPhim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBanPhim.UseVisualStyleBackColor = true;
            this.buttonBanPhim.Click += new System.EventHandler(this.buttonBanPhim_Click);
            // 
            // buttonDeskTop
            // 
            this.buttonDeskTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDeskTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeskTop.Image = global::demo.Properties.Resources.computer32px_03;
            this.buttonDeskTop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeskTop.Location = new System.Drawing.Point(120, 0);
            this.buttonDeskTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeskTop.Name = "buttonDeskTop";
            this.buttonDeskTop.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonDeskTop.Size = new System.Drawing.Size(178, 64);
            this.buttonDeskTop.TabIndex = 2;
            this.buttonDeskTop.Text = "Máy tính bàn";
            this.buttonDeskTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDeskTop.UseVisualStyleBackColor = true;
            this.buttonDeskTop.Click += new System.EventHandler(this.buttonDeskTop_Click);
            // 
            // buttonLapTop
            // 
            this.buttonLapTop.BackColor = System.Drawing.Color.Transparent;
            this.buttonLapTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonLapTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLapTop.Image = ((System.Drawing.Image)(resources.GetObject("buttonLapTop.Image")));
            this.buttonLapTop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLapTop.Location = new System.Drawing.Point(0, 0);
            this.buttonLapTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLapTop.Name = "buttonLapTop";
            this.buttonLapTop.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.buttonLapTop.Size = new System.Drawing.Size(120, 64);
            this.buttonLapTop.TabIndex = 1;
            this.buttonLapTop.Text = "Laptop";
            this.buttonLapTop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonLapTop.UseVisualStyleBackColor = false;
            this.buttonLapTop.Click += new System.EventHandler(this.buttonLapTop_Click);
            // 
            // FormDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1167, 584);
            this.Controls.Add(this.dg_DanhMucSanPham);
            this.Controls.Add(this.panel_thongTinThietBi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_DanhMuc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDanhMuc";
            this.Text = "Danh Mục Sản Phẩm";
            this.Load += new System.EventHandler(this.FormDanhMuc_Load);
            this.panel_DanhMuc.ResumeLayout(false);
            this.panel_DanhMuc.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_thongTinThietBi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_DanhMucSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_thietBi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDeskTop;
        private System.Windows.Forms.Button buttonBanPhim;
        private System.Windows.Forms.Button buttonChuot;
        private System.Windows.Forms.Button buttonTaiNghe;
        private System.Windows.Forms.Button buttonManHinh;
        private System.Windows.Forms.Panel panel_DanhMuc;
        private System.Windows.Forms.Button buttonLapTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_searchProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_xoaThietBi;
        private System.Windows.Forms.Button btn_themThietBi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_suaThietBi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_thongTinThietBi;
        private System.Windows.Forms.PictureBox pictureBox_thietBi;
        private System.Windows.Forms.DataGridView dg_DanhMucSanPham;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileExcel;
    }
}