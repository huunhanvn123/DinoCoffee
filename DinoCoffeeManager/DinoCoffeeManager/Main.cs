using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DinoCoffeeManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            pnSide.Height = btnPOS.Height;
            pnSide.Top = btnPOS.Top;
            lbTest.Text = "POS";
            btnPOS.BackColor = Color.FromArgb(242, 242, 242);
        }

        private void btnShowHideTab_Click(object sender, EventArgs e)
        {
            if(pnTab.Width == 250)
            {
                pnTab.Width = 91;
            }
            else
            {
                pnTab.Width = 250;
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            pnSide.Height = btnPOS.Height;
            pnSide.Top = btnPOS.Top;
            btnPOS.BackColor = Color.FromArgb(242, 242, 242);
            btnQuanLy.BackColor = Color.FromArgb(204, 255, 153);
            btnKhachHang.BackColor = Color.FromArgb(204, 255, 153);
            btnQuy.BackColor = Color.FromArgb(204, 255, 153);
            btnBaoCao.BackColor = Color.FromArgb(204, 255, 153);
            lbTest.Text = "POS";
        }

        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            pnSide.Height = btnQuanLy.Height;
            pnSide.Top = btnQuanLy.Top;
            btnQuanLy.BackColor = Color.FromArgb(242, 242, 242);
            btnPOS.BackColor = Color.FromArgb(204, 255, 153);
            btnKhachHang.BackColor = Color.FromArgb(204, 255, 153);
            btnQuy.BackColor = Color.FromArgb(204, 255, 153);
            btnBaoCao.BackColor = Color.FromArgb(204, 255, 153);
            lbTest.Text = "QuanLy";
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            pnSide.Height = btnKhachHang.Height;
            pnSide.Top = btnKhachHang.Top;
            btnKhachHang.BackColor = Color.FromArgb(242, 242, 242);
            btnPOS.BackColor = Color.FromArgb(204, 255, 153);
            btnQuanLy.BackColor = Color.FromArgb(204, 255, 153);
            btnQuy.BackColor = Color.FromArgb(204, 255, 153);
            btnBaoCao.BackColor = Color.FromArgb(204, 255, 153);
            lbTest.Text = "Khách hàng";
        }

        private void btnQuy_Click(object sender, EventArgs e)
        {
            pnSide.Height = btnQuy.Height;
            pnSide.Top = btnQuy.Top;
            btnQuy.BackColor = Color.FromArgb(242, 242, 242);
            btnPOS.BackColor = Color.FromArgb(204, 255, 153);
            btnKhachHang.BackColor = Color.FromArgb(204, 255, 153);
            btnQuanLy.BackColor = Color.FromArgb(204, 255, 153);
            btnBaoCao.BackColor = Color.FromArgb(204, 255, 153);
            lbTest.Text = "Qũy";
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            pnSide.Height = btnBaoCao.Height;
            pnSide.Top = btnBaoCao.Top;
            btnBaoCao.BackColor = Color.FromArgb(242, 242, 242);
            btnPOS.BackColor = Color.FromArgb(204, 255, 153);
            btnKhachHang.BackColor = Color.FromArgb(204, 255, 153);
            btnQuy.BackColor = Color.FromArgb(204, 255, 153);
            btnQuanLy.BackColor = Color.FromArgb(204, 255, 153);
            lbTest.Text = "Báo cáo";
        }
    }
}
