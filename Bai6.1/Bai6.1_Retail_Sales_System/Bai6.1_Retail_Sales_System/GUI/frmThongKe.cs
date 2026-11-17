using Bai6._1_Retail_Sales_System.BUS;
using System;
using System.Windows.Forms;

namespace Bai6._1_Retail_Sales_System.GUI
{
    public partial class frmThongKe : Form
    {
        private readonly HoaDonBUS _hdBUS = new HoaDonBUS();

        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            DateTime ngayChon = dtpNgayThongKe.Value;

            // 1. Gọi ExecuteScalar tính tổng doanh thu ngày & tháng
            decimal doanhThuNgay = _hdBUS.ThongKeDoanhThuNgay(ngayChon);
            decimal doanhThuThang = _hdBUS.ThongKeDoanhThuThang(ngayChon.Month, ngayChon.Year);

            lblDoanhThuNgay.Text = $"{doanhThuNgay:N0} VNĐ";
            lblDoanhThuThang.Text = $"{doanhThuThang:N0} VNĐ";

            // 2. Gọi SqlDataReader lấy Top 5 sản phẩm bán chạy nhất
            dgvTop5SanPham.DataSource = _hdBUS.LayTop5BanChay();
        }
    }
}