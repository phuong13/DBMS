namespace demo.Forms
{
    partial class FormHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHoaDon));
            this.dataGridViewHoaDon = new System.Windows.Forms.DataGridView();
            this.button_them = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.button_xoaTB = new System.Windows.Forms.Button();
            this.button_ThemTB = new System.Windows.Forms.Button();
            this.button_Thanhtoan = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewHoaDon
            // 
            this.dataGridViewHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHoaDon.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewHoaDon.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridViewHoaDon.Name = "dataGridViewHoaDon";
            this.dataGridViewHoaDon.ReadOnly = true;
            this.dataGridViewHoaDon.RowHeadersWidth = 62;
            this.dataGridViewHoaDon.RowTemplate.Height = 28;
            this.dataGridViewHoaDon.Size = new System.Drawing.Size(1400, 621);
            this.dataGridViewHoaDon.TabIndex = 9;
            this.dataGridViewHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDon_CellClick);
            this.dataGridViewHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoaDon_CellDoubleClick);
            // 
            // button_them
            // 
            this.button_them.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Image = global::demo.Properties.Resources.plus32px_02;
            this.button_them.Location = new System.Drawing.Point(1183, 0);
            this.button_them.Margin = new System.Windows.Forms.Padding(2);
            this.button_them.Name = "button_them";
            this.button_them.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button_them.Size = new System.Drawing.Size(117, 78);
            this.button_them.TabIndex = 2;
            this.button_them.Text = "Thêm";
            this.button_them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Xoa.Enabled = false;
            this.button_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Xoa.Image = global::demo.Properties.Resources.cross32px;
            this.button_Xoa.Location = new System.Drawing.Point(1300, 0);
            this.button_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button_Xoa.Size = new System.Drawing.Size(98, 78);
            this.button_Xoa.TabIndex = 0;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEdit.Controls.Add(this.button_xoaTB);
            this.panelEdit.Controls.Add(this.button_ThemTB);
            this.panelEdit.Controls.Add(this.button_Thanhtoan);
            this.panelEdit.Controls.Add(this.button_back);
            this.panelEdit.Controls.Add(this.button_them);
            this.panelEdit.Controls.Add(this.button_Xoa);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEdit.Location = new System.Drawing.Point(0, 621);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(2);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1400, 80);
            this.panelEdit.TabIndex = 8;
            // 
            // button_xoaTB
            // 
            this.button_xoaTB.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_xoaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoaTB.Image = global::demo.Properties.Resources.cross32px;
            this.button_xoaTB.Location = new System.Drawing.Point(827, 0);
            this.button_xoaTB.Margin = new System.Windows.Forms.Padding(2);
            this.button_xoaTB.Name = "button_xoaTB";
            this.button_xoaTB.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button_xoaTB.Size = new System.Drawing.Size(166, 78);
            this.button_xoaTB.TabIndex = 7;
            this.button_xoaTB.Text = "Xóa thiết bị";
            this.button_xoaTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_xoaTB.UseVisualStyleBackColor = true;
            this.button_xoaTB.Visible = false;
            this.button_xoaTB.Click += new System.EventHandler(this.button_xoaTB_Click);
            // 
            // button_ThemTB
            // 
            this.button_ThemTB.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_ThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemTB.Image = global::demo.Properties.Resources.plus32px_02;
            this.button_ThemTB.Location = new System.Drawing.Point(993, 0);
            this.button_ThemTB.Margin = new System.Windows.Forms.Padding(2);
            this.button_ThemTB.Name = "button_ThemTB";
            this.button_ThemTB.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.button_ThemTB.Size = new System.Drawing.Size(190, 78);
            this.button_ThemTB.TabIndex = 6;
            this.button_ThemTB.Text = "Thêm Thiết Bị";
            this.button_ThemTB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ThemTB.UseVisualStyleBackColor = true;
            this.button_ThemTB.Visible = false;
            this.button_ThemTB.Click += new System.EventHandler(this.button_ThemTB_Click);
            // 
            // button_Thanhtoan
            // 
            this.button_Thanhtoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_Thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thanhtoan.Location = new System.Drawing.Point(94, 0);
            this.button_Thanhtoan.Margin = new System.Windows.Forms.Padding(2);
            this.button_Thanhtoan.Name = "button_Thanhtoan";
            this.button_Thanhtoan.Size = new System.Drawing.Size(150, 78);
            this.button_Thanhtoan.TabIndex = 5;
            this.button_Thanhtoan.Text = "Thanh Toán";
            this.button_Thanhtoan.UseVisualStyleBackColor = true;
            this.button_Thanhtoan.Click += new System.EventHandler(this.button_Thanhtoan_Click);
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::demo.Properties.Resources.left_arrow__1_;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_back.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.Location = new System.Drawing.Point(0, 0);
            this.button_back.Margin = new System.Windows.Forms.Padding(2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(94, 78);
            this.button_back.TabIndex = 4;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 701);
            this.Controls.Add(this.dataGridViewHoaDon);
            this.Controls.Add(this.panelEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoaDon)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewHoaDon;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_Xoa;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_Thanhtoan;
        private System.Windows.Forms.Button button_ThemTB;
        private System.Windows.Forms.Button button_xoaTB;
    }
}