using Bai6._1_Retail_Sales_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bai6._1_Retail_Sales_System.DAL
{
    public class KhachHangDAL
    {
        public List<KhachHangDTO> GetAll()
        {
            var list = new List<KhachHangDTO>();
            string query = "SELECT MaKH, TenKH, DienThoai, DiemTichLuy FROM KhachHang";
            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhachHangDTO
                        {
                            MaKH = Convert.ToInt32(reader["MaKH"]),
                            TenKH = reader["TenKH"].ToString(),
                            DienThoai = reader["DienThoai"]?.ToString(),
                            DiemTichLuy = Convert.ToInt32(reader["DiemTichLuy"])
                        });
                    }
                }
            }
            return list;
        }

        public bool Insert(KhachHangDTO kh)
        {
            string query = "INSERT INTO KhachHang (TenKH, DienThoai, DiemTichLuy) VALUES (@TenKH, @DienThoai, @DiemTichLuy)";
            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 100).Value = kh.TenKH;
                cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 15).Value = (object)kh.DienThoai ?? DBNull.Value;
                cmd.Parameters.Add("@DiemTichLuy", SqlDbType.Int).Value = kh.DiemTichLuy;
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(KhachHangDTO kh)
        {
            string query = "UPDATE KhachHang SET TenKH = @TenKH, DienThoai = @DienThoai, DiemTichLuy = @DiemTichLuy WHERE MaKH = @MaKH";
            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = kh.MaKH;
                cmd.Parameters.Add("@TenKH", SqlDbType.NVarChar, 100).Value = kh.TenKH;
                cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar, 15).Value = (object)kh.DienThoai ?? DBNull.Value;
                cmd.Parameters.Add("@DiemTichLuy", SqlDbType.Int).Value = kh.DiemTichLuy;
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maKH)
        {
            string query = "DELETE FROM KhachHang WHERE MaKH = @MaKH";
            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = maKH;
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }

    public class NhanVienDAL
    {
        public List<NhanVienDTO> GetAll()
        {
            var list = new List<NhanVienDTO>();
            string query = "SELECT MaNV, TenNV, SoDienThoai, ChucVu FROM NhanVien";
            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new NhanVienDTO
                        {
                            MaNV = Convert.ToInt32(reader["MaNV"]),
                            TenNV = reader["TenNV"].ToString(),
                            SoDienThoai = reader["SoDienThoai"]?.ToString(),
                            ChucVu = reader["ChucVu"]?.ToString()
                        });
                    }
                }
            }
            return list;
        }

        public bool Insert(NhanVienDTO nv)
        {
            string query = "INSERT INTO NhanVien (TenNV, SoDienThoai, ChucVu) VALUES (@TenNV, @SoDienThoai, @ChucVu)";
            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar, 100).Value = nv.TenNV;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.VarChar, 15).Value = (object)nv.SoDienThoai ?? DBNull.Value;
                cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 50).Value = (object)nv.ChucVu ?? DBNull.Value;
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(NhanVienDTO nv)
        {
            string query = "UPDATE NhanVien SET TenNV = @TenNV, SoDienThoai = @SoDienThoai, ChucVu = @ChucVu WHERE MaNV = @MaNV";
            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = nv.MaNV;
                cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar, 100).Value = nv.TenNV;
                cmd.Parameters.Add("@SoDienThoai", SqlDbType.VarChar, 15).Value = (object)nv.SoDienThoai ?? DBNull.Value;
                cmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar, 50).Value = (object)nv.ChucVu ?? DBNull.Value;
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(int maNV)
        {
            string query = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@MaNV", SqlDbType.Int).Value = maNV;
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}