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
            this.button_account = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.button_kho = new System.Windows.Forms.Button();
            this.button_receipt = new System.Windows.Forms.Button();
            this.button_danhmuc = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.labelLogo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTiltle = new System.Windows.Forms.Label();
            this.panel_content = new System.Windows.Forms.Panel();
            this.panel_menu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel_menu.Controls.Add(this.button_account);
            this.panel_menu.Controls.Add(this.btn_employees);
            this.panel_menu.Controls.Add(this.button_kho);
            this.panel_menu.Controls.Add(this.button_receipt);
            this.panel_menu.Controls.Add(this.button_danhmuc);
            this.panel_menu.Controls.Add(this.panel_logo);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(220, 562);
            this.panel_menu.TabIndex = 0;
            // 
            // button_account
            // 
            this.button_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_account.FlatAppearance.BorderSize = 0;
            this.button_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_account.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_account.Location = new System.Drawing.Point(0, 400);
            this.button_account.Name = "button_account";
            this.button_account.Size = new System.Drawing.Size(220, 80);
            this.button_account.TabIndex = 5;
            this.button_account.Text = "Account";
            this.button_account.UseVisualStyleBackColor = true;
            this.button_account.Click += new System.EventHandler(this.button_account_Click);
            // 
            // btn_employees
            // 
            this.btn_employees.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_employees.FlatAppearance.BorderSize = 0;
            this.btn_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employees.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_employees.Location = new System.Drawing.Point(0, 320);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(220, 80);
            this.btn_employees.TabIndex = 4;
            this.btn_employees.Text = "Nhân Viên";
            this.btn_employees.UseVisualStyleBackColor = true;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click);
            // 
            // button_kho
            // 
            this.button_kho.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_kho.FlatAppearance.BorderSize = 0;
            this.button_kho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_kho.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_kho.Location = new System.Drawing.Point(0, 240);
            this.button_kho.Name = "button_kho";
            this.button_kho.Size = new System.Drawing.Size(220, 80);
            this.button_kho.TabIndex = 3;
            this.button_kho.Text = "Kho";
            this.button_kho.UseVisualStyleBackColor = true;
            this.button_kho.Click += new System.EventHandler(this.button_kho_Click);
            // 
            // button_receipt
            // 
            this.button_receipt.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_receipt.FlatAppearance.BorderSize = 0;
            this.button_receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_receipt.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_receipt.Location = new System.Drawing.Point(0, 160);
            this.button_receipt.Name = "button_receipt";
            this.button_receipt.Size = new System.Drawing.Size(220, 80);
            this.button_receipt.TabIndex = 2;
            this.button_receipt.Text = "Hóa Đơn";
            this.button_receipt.UseVisualStyleBackColor = true;
            this.button_receipt.Click += new System.EventHandler(this.button_receipt_Click);
            // 
            // button_danhmuc
            // 
            this.button_danhmuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_danhmuc.FlatAppearance.BorderSize = 0;
            this.button_danhmuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_danhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_danhmuc.ForeColor = System.Drawing.Color.Gainsboro;
            this.button_danhmuc.Location = new System.Drawing.Point(0, 80);
            this.button_danhmuc.Name = "button_danhmuc";
            this.button_danhmuc.Size = new System.Drawing.Size(220, 80);
            this.button_danhmuc.TabIndex = 1;
            this.button_danhmuc.Text = "Danh Muc";
            this.button_danhmuc.UseVisualStyleBackColor = true;
            this.button_danhmuc.Click += new System.EventHandler(this.button_danhmuc_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel_logo.Controls.Add(this.labelLogo);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(220, 80);
            this.panel_logo.TabIndex = 0;
            // 
            // labelLogo
            // 
            this.labelLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogo.AutoSize = true;
            this.labelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo.ForeColor = System.Drawing.Color.White;
            this.labelLogo.Location = new System.Drawing.Point(35, 28);
            this.labelLogo.Name = "labelLogo";
            this.labelLogo.Size = new System.Drawing.Size(134, 36);
            this.labelLogo.TabIndex = 1;
            this.labelLogo.Text = "Nhom18";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitleBar.Controls.Add(this.lblTiltle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(919, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.TabStop = true;
            // 
            // lblTiltle
            // 
            this.lblTiltle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTiltle.AutoSize = true;
            this.lblTiltle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiltle.ForeColor = System.Drawing.Color.White;
            this.lblTiltle.Location = new System.Drawing.Point(391, 19);
            this.lblTiltle.Name = "lblTiltle";
            this.lblTiltle.Size = new System.Drawing.Size(96, 36);
            this.lblTiltle.TabIndex = 0;
            this.lblTiltle.Text = "Home";
            // 
            // panel_content
            // 
            this.panel_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_content.Location = new System.Drawing.Point(220, 80);
            this.panel_content.Name = "panel_content";
            this.panel_content.Size = new System.Drawing.Size(919, 482);
            this.panel_content.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 562);
            this.Controls.Add(this.panel_content);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel_menu);
            this.Name = "FormMainMenu";
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_menu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button_account;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button button_kho;
        private System.Windows.Forms.Button button_receipt;
        private System.Windows.Forms.Button button_danhmuc;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTiltle;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panel_content;
    }
}

