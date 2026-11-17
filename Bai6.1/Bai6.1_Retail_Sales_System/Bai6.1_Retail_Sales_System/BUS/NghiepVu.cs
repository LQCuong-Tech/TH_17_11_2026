using Bai6._1_Retail_Sales_System.DAL;
using Bai6._1_Retail_Sales_System.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bai6._1_Retail_Sales_System.BUS
{
    public class SanPhamBUS
    {
        private readonly SanPhamDAL _dal = new SanPhamDAL();

        public List<SanPhamDTO> LayTatCa() => _dal.GetAll();
        public List<SanPhamDTO> TimKiem(string tuKhoa) =>
            string.IsNullOrWhiteSpace(tuKhoa) ? _dal.GetAll() : _dal.Search(tuKhoa);

        public bool ThemSanPham(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP) || string.IsNullOrWhiteSpace(sp.TenSP))
                throw new ArgumentException("Mã sản phẩm và Tên sản phẩm không được để trống.");
            if (sp.GiaBan <= 0)
                throw new ArgumentException("Giá bán phải lớn hơn 0.");
            if (sp.SoLuongTon < 0)
                throw new ArgumentException("Số lượng tồn không được âm.");

            return _dal.Insert(sp);
        }

        public bool CapNhatSanPham(SanPhamDTO sp)
        {
            if (sp.GiaBan <= 0 || sp.SoLuongTon < 0)
                throw new ArgumentException("Giá bán hoặc số lượng tồn không hợp lệ.");
            return _dal.Update(sp);
        }

        public bool XoaSanPham(string maSP) => _dal.Delete(maSP);
    }

    public class HoaDonBUS
    {
        private readonly HoaDonDAL _dal = new HoaDonDAL();

        public int LapHoaDon(HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> gioHang)
        {
            if (gioHang == null || gioHang.Count == 0)
                throw new InvalidOperationException("Giỏ hàng trống, không thể thanh toán.");

            if (hoaDon.MaNV <= 0)
                throw new ArgumentException("Vui lòng chọn nhân viên thu ngân.");

            // Tính lại tổng tiền chính xác từ chi tiết giỏ hàng
            hoaDon.TongTien = gioHang.Sum(x => x.ThanhTien);

            return _dal.ThanhToanHoaDon(hoaDon, gioHang);
        }

        public decimal ThongKeDoanhThuNgay(DateTime ngay) => _dal.GetDoanhThuTheoNgay(ngay);
        public decimal ThongKeDoanhThuThang(int thang, int nam) => _dal.GetDoanhThuTheoThang(thang, nam);
        public List<TopSanPhamDTO> LayTop5BanChay() => _dal.GetTop5SanPhamBanChay();
    }
}