﻿using demo.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{

    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        //Constructor
        public FormMainMenu()
        {
            InitializeComponent();
            random = new Random();
        }
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panel_logo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel_menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel_childForm.Controls.Add(childForm);
            this.panel_childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTiltle.Text = childForm.Text;

        }
        private void button_danhmuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DanhMucThietBi.FormDanhMuc(), sender);
        }

        private void button_hoadon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHoaDon(), sender);
        }

        private void button_kho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormKho(), sender);

        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNhanVien(), sender);
        }

        private void button_khachhang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Customer.FormKhachHang(), sender);
        }

        private void button_account_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAccount(), sender);
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            
        }

            private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

