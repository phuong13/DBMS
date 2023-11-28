
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemThietBi));
            this.panel_textBoxContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_thietBi = new System.Windows.Forms.ComboBox();
            this.btn_chonAnh = new System.Windows.Forms.Button();
            this.imageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txt_anhThietBi = new System.Windows.Forms.TextBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.pictureBox_anhThietBi = new System.Windows.Forms.PictureBox();
            this.btn_luu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_textBoxContainer
            // 
            this.panel_textBoxContainer.Location = new System.Drawing.Point(16, 63);
            this.panel_textBoxContainer.Name = "panel_textBoxContainer";
            this.panel_textBoxContainer.Size = new System.Drawing.Size(508, 434);
            this.panel_textBoxContainer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn loại thiết bị:";
            // 
            // cbox_thietBi
            // 
            this.cbox_thietBi.FormattingEnabled = true;
            this.cbox_thietBi.Location = new System.Drawing.Point(207, 24);
            this.cbox_thietBi.Name = "cbox_thietBi";
            this.cbox_thietBi.Size = new System.Drawing.Size(122, 24);
            this.cbox_thietBi.TabIndex = 2;
            this.cbox_thietBi.SelectedIndexChanged += new System.EventHandler(this.cbox_thietBi_SelectedIndexChanged);
            // 
            // btn_chonAnh
            // 
            this.btn_chonAnh.AutoSize = true;
            this.btn_chonAnh.Location = new System.Drawing.Point(530, 24);
            this.btn_chonAnh.Name = "btn_chonAnh";
            this.btn_chonAnh.Size = new System.Drawing.Size(79, 27);
            this.btn_chonAnh.TabIndex = 1;
            this.btn_chonAnh.Text = "Chọn ảnh";
            this.btn_chonAnh.UseVisualStyleBackColor = true;
            this.btn_chonAnh.Click += new System.EventHandler(this.btn_chonAnh_Click);
            // 
            // imageFileDialog
            // 
            this.imageFileDialog.FileName = "openFileDialog1";
            // 
            // txt_anhThietBi
            // 
            this.txt_anhThietBi.Location = new System.Drawing.Point(531, 65);
            this.txt_anhThietBi.Name = "txt_anhThietBi";
            this.txt_anhThietBi.Size = new System.Drawing.Size(299, 22);
            this.txt_anhThietBi.TabIndex = 5;
            // 
            // btn_huy
            // 
            this.btn_huy.AutoSize = true;
            this.btn_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_huy.Image = global::demo.Properties.Resources.cross32px;
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(731, 405);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_huy.Size = new System.Drawing.Size(99, 59);
            this.btn_huy.TabIndex = 4;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // pictureBox_anhThietBi
            // 
            this.pictureBox_anhThietBi.Location = new System.Drawing.Point(530, 99);
            this.pictureBox_anhThietBi.Name = "pictureBox_anhThietBi";
            this.pictureBox_anhThietBi.Size = new System.Drawing.Size(300, 300);
            this.pictureBox_anhThietBi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_anhThietBi.TabIndex = 0;
            this.pictureBox_anhThietBi.TabStop = false;
            // 
            // btn_luu
            // 
            this.btn_luu.AutoSize = true;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Image = global::demo.Properties.Resources.save32px_02;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(626, 405);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_luu.Size = new System.Drawing.Size(99, 59);
            this.btn_luu.TabIndex = 3;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // FormThemThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 512);
            this.Controls.Add(this.txt_anhThietBi);
            this.Controls.Add(this.btn_chonAnh);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.pictureBox_anhThietBi);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.cbox_thietBi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_textBoxContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormThemThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThemThietBi";
            this.Load += new System.EventHandler(this.FormThemThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_textBoxContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_thietBi;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_chonAnh;
        private System.Windows.Forms.PictureBox pictureBox_anhThietBi;
        private System.Windows.Forms.OpenFileDialog imageFileDialog;
        private System.Windows.Forms.TextBox txt_anhThietBi;
    }
}