namespace demo.Forms
{
    partial class FormKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKho));
            this.dataGridViewKho = new System.Windows.Forms.DataGridView();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            this.col_maPhieuNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKho
            // 
            this.dataGridViewKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_maPhieuNhap,
            this.col_ngayNhap});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKho.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKho.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKho.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewKho.Name = "dataGridViewKho";
            this.dataGridViewKho.ReadOnly = true;
            this.dataGridViewKho.RowHeadersWidth = 62;
            this.dataGridViewKho.RowTemplate.Height = 28;
            this.dataGridViewKho.Size = new System.Drawing.Size(1023, 469);
            this.dataGridViewKho.TabIndex = 4;
            this.dataGridViewKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKho_CellClick);
            this.dataGridViewKho.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKho_CellDoubleClick);
            // 
            // buttonThem
            // 
            this.buttonThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Image = global::demo.Properties.Resources.plus32px_02;
            this.buttonThem.Location = new System.Drawing.Point(905, 0);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.buttonThem.Size = new System.Drawing.Size(116, 78);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEdit.Controls.Add(this.button_back);
            this.panelEdit.Controls.Add(this.buttonThem);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEdit.Location = new System.Drawing.Point(0, 469);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(2);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1023, 80);
            this.panelEdit.TabIndex = 3;
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
            this.button_back.TabIndex = 3;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // col_maPhieuNhap
            // 
            this.col_maPhieuNhap.DataPropertyName = "maPhieuNhap";
            this.col_maPhieuNhap.HeaderText = "Mã phiếu nhập";
            this.col_maPhieuNhap.MinimumWidth = 6;
            this.col_maPhieuNhap.Name = "col_maPhieuNhap";
            this.col_maPhieuNhap.ReadOnly = true;
            // 
            // col_ngayNhap
            // 
            this.col_ngayNhap.DataPropertyName = "ngayNhap";
            this.col_ngayNhap.HeaderText = "Ngày nhập";
            this.col_ngayNhap.MinimumWidth = 6;
            this.col_ngayNhap.Name = "col_ngayNhap";
            this.col_ngayNhap.ReadOnly = true;
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 549);
            this.Controls.Add(this.dataGridViewKho);
            this.Controls.Add(this.panelEdit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKho";
            this.Text = "Kho";
            this.Load += new System.EventHandler(this.FormStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).EndInit();
            this.panelEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKho;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_maPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ngayNhap;
    }
}