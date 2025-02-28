using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebQLDaoTao_1.Models
{
    public class TaiKhoanDAO
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["WebQLDaoTao_1_ConStr"].ConnectionString;
        public TaiKhoan DangNhap(string TenDangNhap,string MatKhau)
        {
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_1_ConStr"].ConnectionString);
            string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);

            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {
                TaiKhoan tk = new TaiKhoan
                {
                    TenDangNhap = rd["TenDangNhap"].ToString(),
                    MatKhau = rd["MatKhau"].ToString(),
                    VaiTro = rd["VaiTro"].ToString()
                };
                return tk;

            }
            return null;
        }
    }
}