﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQLDaoTao_1.Models;

namespace WebQLDaoTao_1
{
    public partial class QLSinhVien : CBDTPage
    {
        SinhVienDAO svDAO = new SinhVienDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender);
        }

        protected void btXuLy_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            string hosv = txtHoSV.Text;
            string tensv = txtTenSv.Text;
            Boolean gioitinh = rdNam.Checked ? true : false;
            DateTime ngaysinh = DateTime.Parse(txtNgaysinh.Text);
            string noisinh = txtNoiSinh.Text;
            string diachi = txtDiaChi.Text;
            string makh = ddlKhoa.SelectedValue;
            SinhVien sv = new SinhVien
            {
                MaSV = masv,
                HoSV = hosv,
                TenSV = tensv,
                GioiTinh = gioitinh,
                NgaySinh = ngaysinh,
                NoiSinh = noisinh,
                DiaChi = diachi,
                MaKH = makh
            };
            svDAO.Insert(sv);
            gvSinhVien.DataBind();
        }
    }
}