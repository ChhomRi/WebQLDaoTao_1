using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQLDaoTao_1.Models;

namespace WebQLDaoTao_1
{
    public partial class CBDTPage : System.Web.UI.Page
    {
        TaiKhoanDAO tkDAO = new TaiKhoanDAO();
        protected void Page_Load(object sender)
        {
            if(Session["TenDangNhap"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string username = (string)Session["TenDangNhap"];
                if (tkDAO.findByUsername(username).VaiTro != "CBDT")
                {
                    Response.Redirect("TuChoiTruyCap.aspx");
                }
            }
        }
    }
}