﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebQLDaoTao_1.Models
{
    public class TaiKhoan
    {
        public string TenDangNhap { set; get; }
        public string MatKhau { set; get; }
        public string VaiTro { set; get; }
        public object TenDN { get; internal set; }
    }
}