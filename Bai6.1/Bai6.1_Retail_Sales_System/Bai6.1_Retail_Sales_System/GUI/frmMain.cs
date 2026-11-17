using System;
using System.Windows.Forms;

namespace Bai6._1_Retail_Sales_System.GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            new frmBanHang().ShowDialog();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            new frmSanPham().ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            new frmThongKe().ShowDialog();
        }
    }
}