namespace demo
{
    partial class FormMainMenu
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
            this.panel_menu = new System.Windows.Forms.Panel();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.button_account = new System.Windows.Forms.Button();
            this.button_doanhthu = new System.Windows.Forms.Button();
            this.button_khachhang = new System.Windows.Forms.Button();
            this.button_nhanvien = new System.Windows.Forms.Button();
            this.button_kho = new System.Windows.Forms.Button();
            this.button_hoadon = new System.Windows.Forms.Button();
            this.button_danhmuc = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTiltle = new System.Windows.Forms.Label();
            this.panel_childForm = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_menu.Controls.Add(this.btn_dangxuat);
            this.panel_menu.Controls.Add(this.button_account);
            this.panel_menu.Controls.Add(this.button_doanhthu);
            this.panel_menu.Controls.Add(this.button_khachhang);
            this.panel_menu.Controls.Add(this.button_nhanvien);
            this.panel_menu.Controls.Add(this.button_kho);
            this.panel_menu.Controls.Add(this.button_hoadon);
            this.panel_menu.Controls.Add(this.button_danhmuc);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(2);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(183, 839);
            this.panel_menu.TabIndex = 0;
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_dangxuat.FlatAppearance.BorderSize = 0;
            this.btn_dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangxuat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_dangxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangxuat.Location = new System.Drawing.Point(0, 773);
            this.btn_dangxuat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(183, 66);
            this.btn_dangxuat.TabIndex = 8;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dangxuat.UseVisualStyleBackColor = true;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // button_account
            // 
            this.button_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_account.FlatAppearance.BorderSize = 0;
            this.button_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_account.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_account.Image = global::demo.Properties.Resources.profile;
            this.button_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_account.Location = new System.Drawing.Point(0, 644);
            this.button_account.Margin = new System.Windows.Forms.Padding(2);
            this.button_account.Name = "button_account";
            this.button_account.Size = new System.Drawing.Size(183, 92);
            this.button_account.TabIndex = 7;
            this.button_account.Text = "Quản lý tài khoản";
            this.button_account.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_account.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_account.UseVisualStyleBackColor = true;
            this.button_account.Click += new System.EventHandler(this.button_account_Click);
            // 
            // button_doanhthu
            // 
            this.button_doanhthu.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_doanhthu.FlatAppearance.BorderSize = 0;
            this.button_doanhthu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_doanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_doanhthu.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_doanhthu.Image = global::demo.Properties.Resources.thongke32px_white_2;
            this.button_doanhthu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_doanhthu.Location = new System.Drawing.Point(0, 552);
            this.button_doanhthu.Margin = new System.Windows.Forms.Padding(2);
            this.button_doanhthu.Name = "button_doanhthu";
            this.button_doanhthu.Size = new System.Drawing.Size(183, 92);
            this.button_doanhthu.TabIndex = 6;
            this.button_doanhthu.Text = "Doanh thu";
            this.button_doanhthu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_doanhthu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_doanhthu.UseVisualStyleBackColor = true;
            this.button_doanhthu.Click += new System.EventHandler(this.button_doanhthu_Click);
            // 
            // button_khachhang
            // 
            this.button_khachhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_khachhang.FlatAppearance.BorderSize = 0;
            this.button_khachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_khachhang.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_khachhang.Image = global::demo.Properties.Resources.customer;
            this.button_khachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_khachhang.Location = new System.Drawing.Point(0, 460);
            this.button_khachhang.Margin = new System.Windows.Forms.Padding(2);
            this.button_khachhang.Name = "button_khachhang";
            this.button_khachhang.Size = new System.Drawing.Size(183, 92);
            this.button_khachhang.TabIndex = 5;
            this.button_khachhang.Text = "Khách hàng";
            this.button_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_khachhang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_khachhang.UseVisualStyleBackColor = true;
            this.button_khachhang.Click += new System.EventHandler(this.button_khachhang_Click);
            // 
            // button_nhanvien
            // 
            this.button_nhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_nhanvien.FlatAppearance.BorderSize = 0;
            this.button_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nhanvien.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_nhanvien.Image = global::demo.Properties.Resources.badge;
            this.button_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nhanvien.Location = new System.Drawing.Point(0, 368);
            this.button_nhanvien.Margin = new System.Windows.Forms.Padding(2);
            this.button_nhanvien.Name = "button_nhanvien";
            this.button_nhanvien.Size = new System.Drawing.Size(183, 92);
            this.button_nhanvien.TabIndex = 4;
            this.button_nhanvien.Text = "Nhân Viên";
            this.button_nhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_nhanvien.UseVisualStyleBackColor = true;
            this.button_nhanvien.Click += new System.EventHandler(this.btn_nhanvien_Click);
            // 
            // button_kho
            // 
            this.button_kho.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_kho.FlatAppearance.BorderSize = 0;
            this.button_kho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kho.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_kho.Image = global::demo.Properties.Resources.ready_stock__1_;
            this.button_kho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kho.Location = new System.Drawing.Point(0, 276);
            this.button_kho.Margin = new System.Windows.Forms.Padding(2);
            this.button_kho.Name = "button_kho";
            this.button_kho.Size = new System.Drawing.Size(183, 92);
            this.button_kho.TabIndex = 3;
            this.button_kho.Text = "Nhập";
            this.button_kho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_kho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_kho.UseVisualStyleBackColor = true;
            this.button_kho.Click += new System.EventHandler(this.button_kho_Click);
            // 
            // button_hoadon
            // 
            this.button_hoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_hoadon.FlatAppearance.BorderSize = 0;
            this.button_hoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_hoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_hoadon.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_hoadon.Image = global::demo.Properties.Resources.bill__1_;
            this.button_hoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hoadon.Location = new System.Drawing.Point(0, 184);
            this.button_hoadon.Margin = new System.Windows.Forms.Padding(2);
            this.button_hoadon.Name = "button_hoadon";
            this.button_hoadon.Size = new System.Drawing.Size(183, 92);
            this.button_hoadon.TabIndex = 2;
            this.button_hoadon.Text = "Hóa Đơn";
            this.button_hoadon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_hoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_hoadon.UseVisualStyleBackColor = true;
            this.button_hoadon.Click += new System.EventHandler(this.button_hoadon_Click);
            // 
            // button_danhmuc
            // 
            this.button_danhmuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_danhmuc.FlatAppearance.BorderSize = 0;
            this.button_danhmuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_danhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_danhmuc.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_danhmuc.Image = global::demo.Properties.Resources.list;
            this.button_danhmuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_danhmuc.Location = new System.Drawing.Point(0, 92);
            this.button_danhmuc.Margin = new System.Windows.Forms.Padding(2);
            this.button_danhmuc.Name = "button_danhmuc";
            this.button_danhmuc.Size = new System.Drawing.Size(183, 92);
            this.button_danhmuc.TabIndex = 1;
            this.button_danhmuc.Text = "Danh Mục";
            this.button_danhmuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_danhmuc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_danhmuc.UseVisualStyleBackColor = true;
            this.button_danhmuc.Click += new System.EventHandler(this.button_danhmuc_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Margin = new System.Windows.Forms.Padding(2);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(183, 92);
            this.panel_logo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhóm 18";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitleBar.Controls.Add(this.lblTiltle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitleBar.Location = new System.Drawing.Point(183, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(816, 92);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.TabStop = true;
            // 
            // lblTiltle
            // 
            this.lblTiltle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiltle.ForeColor = System.Drawing.Color.White;
            this.lblTiltle.Location = new System.Drawing.Point(344, 16);
            this.lblTiltle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiltle.Name = "lblTiltle";
            this.lblTiltle.Size = new System.Drawing.Size(109, 55);
            this.lblTiltle.TabIndex = 0;
            this.lblTiltle.Text = "Home";
            this.lblTiltle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_childForm
            // 
            this.panel_childForm.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel_childForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_childForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_childForm.Location = new System.Drawing.Point(183, 92);
            this.panel_childForm.Margin = new System.Windows.Forms.Padding(2);
            this.panel_childForm.Name = "panel_childForm";
            this.panel_childForm.Size = new System.Drawing.Size(816, 747);
            this.panel_childForm.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(999, 839);
            this.Controls.Add(this.panel_childForm);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel_menu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMainMenu";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainMenu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMainMenu_FormClosed);
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_khachhang;
        private System.Windows.Forms.Button button_nhanvien;
        private System.Windows.Forms.Button button_kho;
        private System.Windows.Forms.Button button_hoadon;
        private System.Windows.Forms.Button button_danhmuc;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTiltle;
        private System.Windows.Forms.Panel panel_childForm;
        private System.Windows.Forms.Button button_doanhthu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_account;
        private System.Windows.Forms.Button btn_dangxuat;
    }
}

