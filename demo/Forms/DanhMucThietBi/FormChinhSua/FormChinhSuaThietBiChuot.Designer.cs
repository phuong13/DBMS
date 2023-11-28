
namespace demo.Forms.DanhMucThietBi.FormChinhSua
{
    partial class FormChinhSuaThietBiChuot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinhSuaThietBiChuot));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_soLuong = new System.Windows.Forms.TextBox();
            this.lbl_soLuong = new System.Windows.Forms.Label();
            this.txt_trongLuong = new System.Windows.Forms.TextBox();
            this.lbl_trongLuong = new System.Windows.Forms.Label();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.lbl_donGia = new System.Windows.Forms.Label();
            this.txt_mauSac = new System.Windows.Forms.TextBox();
            this.lbl_mauSac = new System.Windows.Forms.Label();
            this.txt_kieuKetNoi = new System.Windows.Forms.TextBox();
            this.lbl_kieuKetNoi = new System.Windows.Forms.Label();
            this.txt_TenThietBi = new System.Windows.Forms.TextBox();
            this.lbl_tenThietBi = new System.Windows.Forms.Label();
            this.txt_maTB = new System.Windows.Forms.TextBox();
            this.lbl_maTB = new System.Windows.Forms.Label();
            this.txt_anhThietBi = new System.Windows.Forms.TextBox();
            this.btn_chonAnh = new System.Windows.Forms.Button();
            this.imageFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox_anhThietBi = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "CHỈNH SỬA THÔNG TIN THIẾT BỊ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_huy);
            this.groupBox1.Controls.Add(this.btn_luu);
            this.groupBox1.Controls.Add(this.txt_soLuong);
            this.groupBox1.Controls.Add(this.lbl_soLuong);
            this.groupBox1.Controls.Add(this.txt_trongLuong);
            this.groupBox1.Controls.Add(this.lbl_trongLuong);
            this.groupBox1.Controls.Add(this.txt_donGia);
            this.groupBox1.Controls.Add(this.lbl_donGia);
            this.groupBox1.Controls.Add(this.txt_mauSac);
            this.groupBox1.Controls.Add(this.lbl_mauSac);
            this.groupBox1.Controls.Add(this.txt_kieuKetNoi);
            this.groupBox1.Controls.Add(this.lbl_kieuKetNoi);
            this.groupBox1.Controls.Add(this.txt_TenThietBi);
            this.groupBox1.Controls.Add(this.lbl_tenThietBi);
            this.groupBox1.Controls.Add(this.txt_maTB);
            this.groupBox1.Controls.Add(this.lbl_maTB);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 401);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_huy
            // 
            this.btn_huy.AutoSize = true;
            this.btn_huy.Image = global::demo.Properties.Resources.cross32px;
            this.btn_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_huy.Location = new System.Drawing.Point(395, 335);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btn_huy.Size = new System.Drawing.Size(95, 51);
            this.btn_huy.TabIndex = 15;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_huy.UseVisualStyleBackColor = true;
            // 
            // btn_luu
            // 
            this.btn_luu.AutoSize = true;
            this.btn_luu.Image = global::demo.Properties.Resources.save32px_02;
            this.btn_luu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_luu.Location = new System.Drawing.Point(244, 335);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.btn_luu.Size = new System.Drawing.Size(101, 51);
            this.btn_luu.TabIndex = 14;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_soLuong
            // 
            this.txt_soLuong.Location = new System.Drawing.Point(117, 294);
            this.txt_soLuong.Name = "txt_soLuong";
            this.txt_soLuong.Size = new System.Drawing.Size(521, 22);
            this.txt_soLuong.TabIndex = 13;
            // 
            // lbl_soLuong
            // 
            this.lbl_soLuong.AutoSize = true;
            this.lbl_soLuong.Location = new System.Drawing.Point(15, 297);
            this.lbl_soLuong.Name = "lbl_soLuong";
            this.lbl_soLuong.Size = new System.Drawing.Size(64, 17);
            this.lbl_soLuong.TabIndex = 12;
            this.lbl_soLuong.Text = "Số lượng";
            // 
            // txt_trongLuong
            // 
            this.txt_trongLuong.Location = new System.Drawing.Point(117, 250);
            this.txt_trongLuong.Name = "txt_trongLuong";
            this.txt_trongLuong.Size = new System.Drawing.Size(521, 22);
            this.txt_trongLuong.TabIndex = 11;
            // 
            // lbl_trongLuong
            // 
            this.lbl_trongLuong.AutoSize = true;
            this.lbl_trongLuong.Location = new System.Drawing.Point(15, 253);
            this.lbl_trongLuong.Name = "lbl_trongLuong";
            this.lbl_trongLuong.Size = new System.Drawing.Size(85, 17);
            this.lbl_trongLuong.TabIndex = 10;
            this.lbl_trongLuong.Text = "Trọng lượng";
            // 
            // txt_donGia
            // 
            this.txt_donGia.Location = new System.Drawing.Point(117, 206);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(521, 22);
            this.txt_donGia.TabIndex = 9;
            // 
            // lbl_donGia
            // 
            this.lbl_donGia.AutoSize = true;
            this.lbl_donGia.Location = new System.Drawing.Point(15, 209);
            this.lbl_donGia.Name = "lbl_donGia";
            this.lbl_donGia.Size = new System.Drawing.Size(57, 17);
            this.lbl_donGia.TabIndex = 8;
            this.lbl_donGia.Text = "Đơn giá";
            // 
            // txt_mauSac
            // 
            this.txt_mauSac.Location = new System.Drawing.Point(117, 162);
            this.txt_mauSac.Name = "txt_mauSac";
            this.txt_mauSac.Size = new System.Drawing.Size(521, 22);
            this.txt_mauSac.TabIndex = 7;
            // 
            // lbl_mauSac
            // 
            this.lbl_mauSac.AutoSize = true;
            this.lbl_mauSac.Location = new System.Drawing.Point(15, 165);
            this.lbl_mauSac.Name = "lbl_mauSac";
            this.lbl_mauSac.Size = new System.Drawing.Size(61, 17);
            this.lbl_mauSac.TabIndex = 6;
            this.lbl_mauSac.Text = "Màu sắc";
            // 
            // txt_kieuKetNoi
            // 
            this.txt_kieuKetNoi.Location = new System.Drawing.Point(117, 118);
            this.txt_kieuKetNoi.Name = "txt_kieuKetNoi";
            this.txt_kieuKetNoi.Size = new System.Drawing.Size(521, 22);
            this.txt_kieuKetNoi.TabIndex = 5;
            // 
            // lbl_kieuKetNoi
            // 
            this.lbl_kieuKetNoi.AutoSize = true;
            this.lbl_kieuKetNoi.Location = new System.Drawing.Point(15, 121);
            this.lbl_kieuKetNoi.Name = "lbl_kieuKetNoi";
            this.lbl_kieuKetNoi.Size = new System.Drawing.Size(82, 17);
            this.lbl_kieuKetNoi.TabIndex = 4;
            this.lbl_kieuKetNoi.Text = "Kiểu kết nối";
            // 
            // txt_TenThietBi
            // 
            this.txt_TenThietBi.Location = new System.Drawing.Point(117, 74);
            this.txt_TenThietBi.Name = "txt_TenThietBi";
            this.txt_TenThietBi.Size = new System.Drawing.Size(521, 22);
            this.txt_TenThietBi.TabIndex = 3;
            // 
            // lbl_tenThietBi
            // 
            this.lbl_tenThietBi.AutoSize = true;
            this.lbl_tenThietBi.Location = new System.Drawing.Point(15, 77);
            this.lbl_tenThietBi.Name = "lbl_tenThietBi";
            this.lbl_tenThietBi.Size = new System.Drawing.Size(79, 17);
            this.lbl_tenThietBi.TabIndex = 2;
            this.lbl_tenThietBi.Text = "Tên thiết bị";
            // 
            // txt_maTB
            // 
            this.txt_maTB.Location = new System.Drawing.Point(117, 30);
            this.txt_maTB.Name = "txt_maTB";
            this.txt_maTB.Size = new System.Drawing.Size(521, 22);
            this.txt_maTB.TabIndex = 1;
            // 
            // lbl_maTB
            // 
            this.lbl_maTB.AutoSize = true;
            this.lbl_maTB.Location = new System.Drawing.Point(15, 33);
            this.lbl_maTB.Name = "lbl_maTB";
            this.lbl_maTB.Size = new System.Drawing.Size(73, 17);
            this.lbl_maTB.TabIndex = 0;
            this.lbl_maTB.Text = "Mã thiết bị";
            // 
            // txt_anhThietBi
            // 
            this.txt_anhThietBi.Location = new System.Drawing.Point(691, 90);
            this.txt_anhThietBi.Name = "txt_anhThietBi";
            this.txt_anhThietBi.Size = new System.Drawing.Size(299, 22);
            this.txt_anhThietBi.TabIndex = 13;
            // 
            // btn_chonAnh
            // 
            this.btn_chonAnh.AutoSize = true;
            this.btn_chonAnh.Location = new System.Drawing.Point(691, 48);
            this.btn_chonAnh.Name = "btn_chonAnh";
            this.btn_chonAnh.Size = new System.Drawing.Size(79, 27);
            this.btn_chonAnh.TabIndex = 12;
            this.btn_chonAnh.Text = "Chọn ảnh";
            this.btn_chonAnh.UseVisualStyleBackColor = true;
            this.btn_chonAnh.Click += new System.EventHandler(this.btn_chonAnh_Click);
            // 
            // imageFileDialog
            // 
            this.imageFileDialog.FileName = "openFileDialog1";
            // 
            // pictureBox_anhThietBi
            // 
            this.pictureBox_anhThietBi.Location = new System.Drawing.Point(691, 134);
            this.pictureBox_anhThietBi.Name = "pictureBox_anhThietBi";
            this.pictureBox_anhThietBi.Size = new System.Drawing.Size(300, 300);
            this.pictureBox_anhThietBi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_anhThietBi.TabIndex = 11;
            this.pictureBox_anhThietBi.TabStop = false;
            // 
            // FormChinhSuaThietBiChuot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 479);
            this.Controls.Add(this.txt_anhThietBi);
            this.Controls.Add(this.btn_chonAnh);
            this.Controls.Add(this.pictureBox_anhThietBi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChinhSuaThietBiChuot";
            this.Text = "FormChinhSuaThietBiChuot";
            this.Load += new System.EventHandler(this.FormChinhSuaThietBiChuot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anhThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox txt_soLuong;
        private System.Windows.Forms.Label lbl_soLuong;
        private System.Windows.Forms.TextBox txt_trongLuong;
        private System.Windows.Forms.Label lbl_trongLuong;
        private System.Windows.Forms.TextBox txt_donGia;
        private System.Windows.Forms.Label lbl_donGia;
        private System.Windows.Forms.TextBox txt_mauSac;
        private System.Windows.Forms.Label lbl_mauSac;
        private System.Windows.Forms.TextBox txt_kieuKetNoi;
        private System.Windows.Forms.Label lbl_kieuKetNoi;
        private System.Windows.Forms.TextBox txt_TenThietBi;
        private System.Windows.Forms.Label lbl_tenThietBi;
        private System.Windows.Forms.TextBox txt_maTB;
        private System.Windows.Forms.Label lbl_maTB;
        private System.Windows.Forms.TextBox txt_anhThietBi;
        private System.Windows.Forms.Button btn_chonAnh;
        private System.Windows.Forms.PictureBox pictureBox_anhThietBi;
        private System.Windows.Forms.OpenFileDialog imageFileDialog;
    }
}