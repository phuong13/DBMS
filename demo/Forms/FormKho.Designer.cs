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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewKho = new System.Windows.Forms.DataGridView();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonChinhsua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKho)).BeginInit();
            this.panelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKho
            // 
            this.dataGridViewKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewKho.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKho.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewKho.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewKho.Name = "dataGridViewKho";
            this.dataGridViewKho.ReadOnly = true;
            this.dataGridViewKho.RowHeadersWidth = 62;
            this.dataGridViewKho.RowTemplate.Height = 28;
            this.dataGridViewKho.Size = new System.Drawing.Size(1151, 586);
            this.dataGridViewKho.TabIndex = 4;
            this.dataGridViewKho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKho_CellClick);
            this.dataGridViewKho.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKho_CellDoubleClick);
            // 
            // buttonThem
            // 
            this.buttonThem.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThem.Location = new System.Drawing.Point(729, 0);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(2);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(130, 98);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            // 
            // buttonChinhsua
            // 
            this.buttonChinhsua.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonChinhsua.Enabled = false;
            this.buttonChinhsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChinhsua.Location = new System.Drawing.Point(859, 0);
            this.buttonChinhsua.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChinhsua.Name = "buttonChinhsua";
            this.buttonChinhsua.Size = new System.Drawing.Size(160, 98);
            this.buttonChinhsua.TabIndex = 1;
            this.buttonChinhsua.Text = "Chỉnh sửa";
            this.buttonChinhsua.UseVisualStyleBackColor = true;
            // 
            // buttonXoa
            // 
            this.buttonXoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonXoa.Enabled = false;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(1019, 0);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(130, 98);
            this.buttonXoa.TabIndex = 0;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            // 
            // panelEdit
            // 
            this.panelEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEdit.Controls.Add(this.button_back);
            this.panelEdit.Controls.Add(this.buttonThem);
            this.panelEdit.Controls.Add(this.buttonChinhsua);
            this.panelEdit.Controls.Add(this.buttonXoa);
            this.panelEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEdit.Location = new System.Drawing.Point(0, 586);
            this.panelEdit.Margin = new System.Windows.Forms.Padding(2);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(1151, 100);
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
            this.button_back.Size = new System.Drawing.Size(106, 98);
            this.button_back.TabIndex = 3;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 686);
            this.Controls.Add(this.dataGridViewKho);
            this.Controls.Add(this.panelEdit);
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
        private System.Windows.Forms.Button buttonChinhsua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button button_back;
    }
}