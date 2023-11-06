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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonChinhsua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(901, 1);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(674, 714);
            this.dataGridView1.TabIndex = 8;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonXoa.Location = new System.Drawing.Point(1474, 0);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(101, 75);
            this.buttonXoa.TabIndex = 3;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // buttonChinhsua
            // 
            this.buttonChinhsua.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonChinhsua.Location = new System.Drawing.Point(1348, 0);
            this.buttonChinhsua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChinhsua.Name = "buttonChinhsua";
            this.buttonChinhsua.Size = new System.Drawing.Size(126, 75);
            this.buttonChinhsua.TabIndex = 4;
            this.buttonChinhsua.Text = "Chỉnh sửa";
            this.buttonChinhsua.UseVisualStyleBackColor = true;
            // 
            // buttonThem
            // 
            this.buttonThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonThem.Location = new System.Drawing.Point(1247, 0);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(101, 75);
            this.buttonThem.TabIndex = 5;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonThem);
            this.panel1.Controls.Add(this.buttonChinhsua);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 801);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1575, 75);
            this.panel1.TabIndex = 7;
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1575, 876);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHoaDon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonChinhsua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Panel panel1;
    }
}