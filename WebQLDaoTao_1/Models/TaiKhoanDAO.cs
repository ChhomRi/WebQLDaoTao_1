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
        public bool DangNhap(string TenDangNhap,string MatKhau)
        {
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_1_ConStr"].ConnectionString);
            string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDangNhap AND MatKhau = @MatKhau";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
            cmd.Parameters.AddWithValue("@MatKhau", MatKhau);
            bool tk = false;
            conn.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
            {

                tk = true;

            }
            return tk;
        }
        public TaiKhoan findByUsername(string username)
        {
            TaiKhoan tk = null;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_1_ConStr"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from  taikhoan where tendangnhap=@tendangnhap", conn);
            cmd.Parameters.AddWithValue("@tendangnhap", username);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                tk = new TaiKhoan
                {
                    TenDangNhap = dr["tendangnhap"].ToString(),
                    MatKhau = dr["matkhau"].ToString(),
                    VaiTro = dr["vaitro"].ToString()
                };
            return tk;


        }

    }
}