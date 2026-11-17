using Bai6._1_Retail_Sales_System.BUS;
using Bai6._1_Retail_Sales_System.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bai6._1_Retail_Sales_System.GUI
{
    public partial class frmBanHang : Form
    {
        private readonly SanPhamBUS _spBUS = new SanPhamBUS();
        private readonly HoaDonBUS _hdBUS = new HoaDonBUS();
        private List<ChiTietHoaDonDTO> _gioHang = new List<ChiTietHoaDonDTO>();

        public frmBanHang()
        {
            InitializeComponent();
        }

        // Thêm sản phẩm vào giỏ hàng
        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            var spChon = cboSanPham.SelectedItem as SanPhamDTO;
            int soLuongMua = (int)numSoLuong.Value;

            if (spChon == null || soLuongMua <= 0) return;

            var itemTonTai = _gioHang.FirstOrDefault(x => x.MaSP == spChon.MaSP);
            int tongSoLuongDuKien = soLuongMua + (itemTonTai?.SoLuong ?? 0);

            if (tongSoLuongDuKien > spChon.SoLuongTon)
            {
                MessageBox.Show($"Tồn kho chỉ còn {spChon.SoLuongTon} sản phẩm!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (itemTonTai != null)
            {
                itemTonTai.SoLuong += soLuongMua;
            }
            else
            {
                _gioHang.Add(new ChiTietHoaDonDTO
                {
                    MaSP = spChon.MaSP,
                    TenSP = spChon.TenSP,
                    SoLuong = soLuongMua,
                    DonGia = spChon.GiaBan
                });
            }

            CapNhatGiaoDienGioHang();
        }

        private void CapNhatGiaoDienGioHang()
        {
            dgvGioHang.DataSource = null;
            dgvGioHang.DataSource = _gioHang;

            decimal tongTien = _gioHang.Sum(x => x.ThanhTien);
            int diemTichLuyDuKien = (int)(tongTien / 100000m);

            lblTongTien.Text = $"{tongTien:N0} VNĐ";
            lblDiemTichLuy.Text = $"+{diemTichLuyDuKien} điểm";
        }

        // Xử lý Thanh toán (Gọi Transaction)
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                var hoaDon = new HoaDonDTO
                {
                    MaNV = (int)cboNhanVien.SelectedValue,
                    // Nếu chọn "Khách lẻ" (Value == 0 hoặc null) thì gán null
                    MaKH = (cboKhachHang.SelectedValue == null || (int)cboKhachHang.SelectedValue == 0)
                           ? (int?)null
                           : (int)cboKhachHang.SelectedValue
                };

                int maHD = _hdBUS.LapHoaDon(hoaDon, _gioHang);

                MessageBox.Show($"Thanh toán thành công! Mã hóa đơn: #{maHD}", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset giỏ hàng và tải lại tồn kho mới
                _gioHang.Clear();
                CapNhatGiaoDienGioHang();
                LoadDanhSachSanPham();
            }
            catch (Exception ex)
            {
                // Bắt thông báo Rollback (ví dụ: hết tồn kho) và hiển thị cho thu ngân
                MessageBox.Show("Giao dịch thất bại (Đã Rollback):\n" + ex.Message, "Lỗi thanh toán",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDanhSachSanPham()
        {
            cboSanPham.DataSource = _spBUS.LayTatCa();
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadDanhSachSanPham();

            var dsNV = new DAL.NhanVienDAL().GetAll();
            cboNhanVien.DataSource = dsNV;
            cboNhanVien.DisplayMember = "TenNV";
            cboNhanVien.ValueMember = "MaNV";

            var dsKH = new DAL.KhachHangDAL().GetAll();
            dsKH.Insert(0, new KhachHangDTO { MaKH = 0, TenKH = "-- Khách lẻ --" });
            cboKhachHang.DataSource = dsKH;
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }
    }
}