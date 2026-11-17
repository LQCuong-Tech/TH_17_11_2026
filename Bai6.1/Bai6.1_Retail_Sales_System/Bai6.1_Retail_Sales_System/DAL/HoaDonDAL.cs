using Bai6._1_Retail_Sales_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bai6._1_Retail_Sales_System.DAL
{
    public class HoaDonDAL
    {
        // 1. GIAO DỊCH THANH TOÁN (Đảm bảo tính toàn vẹn ACID với SqlTransaction)
        public int ThanhToanHoaDon(HoaDonDTO hoaDon, List<ChiTietHoaDonDTO> danhSachChiTiet)
        {
            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string sqlInsertHD = @"INSERT INTO HoaDon (NgayLap, MaNV, MaKH, TongTien)
                                           OUTPUT INSERTED.MaHD
                                           VALUES (GETDATE(), @MaNV, @MaKH, @TongTien)";

                    int maHDMoi;
                    using (SqlCommand cmdHD = new SqlCommand(sqlInsertHD, conn, trans))
                    {
                        cmdHD.Parameters.Add("@MaNV", SqlDbType.Int).Value = hoaDon.MaNV;
                        cmdHD.Parameters.Add("@MaKH", SqlDbType.Int).Value =
                            hoaDon.MaKH.HasValue ? (object)hoaDon.MaKH.Value : DBNull.Value;
                        cmdHD.Parameters.Add("@TongTien", SqlDbType.Decimal).Value = hoaDon.TongTien;

                        maHDMoi = (int)cmdHD.ExecuteScalar();
                    }

                    string sqlInsertCT = @"INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia)
                                           VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";

                    string sqlUpdateTonKho = @"UPDATE SanPham
                                               SET SoLuongTon = SoLuongTon - @SoLuongBan
                                               WHERE MaSP = @MaSP AND SoLuongTon >= @SoLuongBan";

                    foreach (var item in danhSachChiTiet)
                    {
                        using (SqlCommand cmdCT = new SqlCommand(sqlInsertCT, conn, trans))
                        {
                            cmdCT.Parameters.Add("@MaHD", SqlDbType.Int).Value = maHDMoi;
                            cmdCT.Parameters.Add("@MaSP", SqlDbType.VarChar, 20).Value = item.MaSP;
                            cmdCT.Parameters.Add("@SoLuong", SqlDbType.Int).Value = item.SoLuong;
                            cmdCT.Parameters.Add("@DonGia", SqlDbType.Decimal).Value = item.DonGia;
                            cmdCT.ExecuteNonQuery();
                        }

                        using (SqlCommand cmdTon = new SqlCommand(sqlUpdateTonKho, conn, trans))
                        {
                            cmdTon.Parameters.Add("@MaSP", SqlDbType.VarChar, 20).Value = item.MaSP;
                            cmdTon.Parameters.Add("@SoLuongBan", SqlDbType.Int).Value = item.SoLuong;

                            int rowsAffected = cmdTon.ExecuteNonQuery();
                            if (rowsAffected == 0)
                            {
                                throw new Exception($"Sản phẩm [{item.MaSP} - {item.TenSP}] không đủ số lượng tồn kho!");
                            }
                        }
                    }

                    if (hoaDon.MaKH.HasValue)
                    {
                        int diemCong = (int)(hoaDon.TongTien / 100000m);
                        if (diemCong > 0)
                        {
                            string sqlUpdateDiem = @"UPDATE KhachHang
                                                     SET DiemTichLuy = DiemTichLuy + @DiemCong
                                                     WHERE MaKH = @MaKH";

                            using (SqlCommand cmdDiem = new SqlCommand(sqlUpdateDiem, conn, trans))
                            {
                                cmdDiem.Parameters.Add("@DiemCong", SqlDbType.Int).Value = diemCong;
                                cmdDiem.Parameters.Add("@MaKH", SqlDbType.Int).Value = hoaDon.MaKH.Value;
                                cmdDiem.ExecuteNonQuery();
                            }
                        }
                    }

                    trans.Commit();
                    return maHDMoi;
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        // 2. BÁO CÁO: Tính doanh thu trong ngày bằng ExecuteScalar
        public decimal GetDoanhThuTheoNgay(DateTime ngay)
        {
            string query = @"SELECT ISNULL(SUM(TongTien), 0) 
                             FROM HoaDon 
                             WHERE CAST(NgayLap AS DATE) = CAST(@Ngay AS DATE)";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@Ngay", SqlDbType.Date).Value = ngay.Date;
                conn.Open();
                object result = cmd.ExecuteScalar();
                return Convert.ToDecimal(result);
            }
        }

        // Tính doanh thu trong tháng bằng ExecuteScalar
        public decimal GetDoanhThuTheoThang(int thang, int nam)
        {
            string query = @"SELECT ISNULL(SUM(TongTien), 0) 
                             FROM HoaDon 
                             WHERE MONTH(NgayLap) = @Thang AND YEAR(NgayLap) = @Nam";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;
                conn.Open();
                object result = cmd.ExecuteScalar();
                return Convert.ToDecimal(result);
            }
        }

        // 3. BÁO CÁO: Top 5 sản phẩm bán chạy nhất bằng SqlDataReader
        public List<TopSanPhamDTO> GetTop5SanPhamBanChay()
        {
            var list = new List<TopSanPhamDTO>();
            string query = @"SELECT TOP 5 
                                sp.MaSP, 
                                sp.TenSP, 
                                SUM(ct.SoLuong) AS TongBan,
                                SUM(ct.SoLuong * ct.DonGia) AS DoanhThu
                             FROM ChiTietHoaDon ct
                             INNER JOIN SanPham sp ON ct.MaSP = sp.MaSP
                             GROUP BY sp.MaSP, sp.TenSP
                             ORDER BY TongBan DESC";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new TopSanPhamDTO
                        {
                            MaSP = reader["MaSP"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                            TongSoLuongBan = Convert.ToInt32(reader["TongBan"]),
                            TongDoanhThu = Convert.ToDecimal(reader["DoanhThu"])
                        });
                    }
                }
            }
            return list;
        }
    }
}