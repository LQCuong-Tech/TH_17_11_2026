using Bai6._1_Retail_Sales_System.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bai6._1_Retail_Sales_System.DAL
{
    public class SanPhamDAL
    {
        public List<SanPhamDTO> GetAll()
        {
            var list = new List<SanPhamDTO>();
            string query = "SELECT MaSP, TenSP, GiaBan, SoLuongTon FROM SanPham";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SanPhamDTO
                        {
                            MaSP = reader["MaSP"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                            GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                            SoLuongTon = Convert.ToInt32(reader["SoLuongTon"])
                        });
                    }
                }
            }
            return list;
        }

        // Tìm kiếm theo Tên hoặc Mã vạch bằng SqlParameter với ký tự đại diện %
        public List<SanPhamDTO> Search(string keyword)
        {
            var list = new List<SanPhamDTO>();
            string query = @"SELECT MaSP, TenSP, GiaBan, SoLuongTon 
                             FROM SanPham 
                             WHERE TenSP LIKE @Keyword OR MaSP LIKE @Keyword";

            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // Truyền ký tự đại diện % thông qua giá trị tham số để chống 100% SQL Injection
                cmd.Parameters.Add("@Keyword", SqlDbType.NVarChar, 150).Value = "%" + keyword.Trim() + "%";
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SanPhamDTO
                        {
                            MaSP = reader["MaSP"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                            GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                            SoLuongTon = Convert.ToInt32(reader["SoLuongTon"])
                        });
                    }
                }
            }
            return list;
        }

        public bool Insert(SanPhamDTO sp)
        {
            string query = "INSERT INTO SanPham (MaSP, TenSP, GiaBan, SoLuongTon) VALUES (@MaSP, @TenSP, @GiaBan, @SoLuongTon)";
            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@MaSP", SqlDbType.VarChar, 20).Value = sp.MaSP;
                cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar, 150).Value = sp.TenSP;
                cmd.Parameters.Add("@GiaBan", SqlDbType.Decimal).Value = sp.GiaBan;
                cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = sp.SoLuongTon;

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Update(SanPhamDTO sp)
        {
            string query = "UPDATE SanPham SET TenSP = @TenSP, GiaBan = @GiaBan, SoLuongTon = @SoLuongTon WHERE MaSP = @MaSP";
            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@MaSP", SqlDbType.VarChar, 20).Value = sp.MaSP;
                cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar, 150).Value = sp.TenSP;
                cmd.Parameters.Add("@GiaBan", SqlDbType.Decimal).Value = sp.GiaBan;
                cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int).Value = sp.SoLuongTon;

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool Delete(string maSP)
        {
            string query = "DELETE FROM SanPham WHERE MaSP = @MaSP";
            using (SqlConnection conn = DBConnection.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@MaSP", SqlDbType.VarChar, 20).Value = maSP;
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}