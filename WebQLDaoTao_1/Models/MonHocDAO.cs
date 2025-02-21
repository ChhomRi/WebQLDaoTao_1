using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebQLDaoTao_1.Models
{
    public class MonHocDAO
    {
        public List<MonHoc> getAll()
        {
            List<MonHoc> ds = new List<MonHoc>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_1_ConStr"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from monhoc", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                MonHoc mh = new MonHoc
                {
                    MaMH = rd["mamh"].ToString(),
                    TenMH = rd["tenmh"].ToString(),
                    SoTiet = int.Parse(rd["sotiet"].ToString())
                };
                ds.Add(mh);
            }
            return ds;
        }
        public int Update(MonHoc mh)
        {
            //1.Mo ket noi CSDL
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_1_ConStr"].ConnectionString);
            conn.Open();
            //2.tao truy van
            SqlCommand cmd = new SqlCommand("update monhoc set tenmh=@tenmh, sotiet=@sotiet where mamh=@mamh", conn);
            cmd.Parameters.AddWithValue("@tenmh", mh.TenMH);
            cmd.Parameters.AddWithValue("@sotiet", mh.SoTiet);
            cmd.Parameters.AddWithValue("@mamh", mh.MaMH);
            //3.thuc thi ket qua;
            return cmd.ExecuteNonQuery();
        }
        public int Delete(string mamh)
        {
            //1.Mo ket noi CSDL
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_1_ConStr"].ConnectionString);
            conn.Open();
            //2.tao truy van
            SqlCommand cmd = new SqlCommand("delete from monhoc where mamh=@mamh", conn);
            cmd.Parameters.AddWithValue("@mamh", mamh);
            //3.thuc thi ket qua;
            return cmd.ExecuteNonQuery();
        }

        public int Insert(string mamh, string tenmh, int sotiet)
        {
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_1_ConStr"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into monhoc (mamh, tenmh,sotiet) values (@mamh,@tenmh,@sotiet)", conn);
            cmd.Parameters.AddWithValue("@mamh", mamh);
            cmd.Parameters.AddWithValue("@tenmh", tenmh);
            cmd.Parameters.AddWithValue("@sotiet", sotiet);
            return cmd.ExecuteNonQuery();
        }

    }
}
