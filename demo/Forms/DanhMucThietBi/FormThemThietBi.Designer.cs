
namespace demo.Forms.DanhMucThietBi
{
    partial class FormThemThietBi
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
            this.panel_textBoxContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_thietBi = new System.Windows.Forms.ComboBox();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_huy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel_textBoxContainer
            // 
            this.panel_textBoxContainer.Location = new System.Drawing.Point(18, 79);
            this.panel_textBoxContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_textBoxContainer.Name = "panel_textBoxContainer";
            this.panel_textBoxContainer.Size = new System.Drawing.Size(506, 538);
            this.panel_textBoxContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn loại thiết bị:";
            // 
            // cbox_thietBi
            // 
            this.cbox_thietBi.FormattingEnabled = true;
            this.cbox_thietBi.Location = new System.Drawing.Point(233, 30);
            this.cbox_thietBi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbox_thietBi.Name = "cbox_thietBi";
            this.cbox_thietBi.Size = new System.Drawing.Size(137, 28);
            this.cbox_thietBi.TabIndex = 2;
            this.cbox_thietBi.SelectedIndexChanged += new System.EventHandler(this.cbox_thietBi_SelectedIndexChanged);
            // 
            // btn_luu
            // 
            this.btn_luu.AutoSize = true;
            this.btn_luu.Location = new System.Drawing.Point(336, 637);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(84, 34);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_huy
            // 
            this.btn_huy.AutoSize = true;
            this.btn_huy.Location = new System.Drawing.Point(440, 637);
            this.btn_huy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(84, 34);
            this.btn_huy.TabIndex = 4;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // FormThemThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 706);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.cbox_thietBi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_textBoxContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormThemThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemThietBi";
            this.Load += new System.EventHandler(this.FormThemThietBi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_textBoxContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_thietBi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
    }
}