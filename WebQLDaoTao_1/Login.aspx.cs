using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQLDaoTao_1.Models;

namespace WebQLDaoTao_1
{
    public partial class Login : System.Web.UI.Page
    {
        TaiKhoanDAO taiKhoanDAO = new TaiKhoanDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtUsername.Text;
            string MatKhau = txtPassword.Text;
            if (taiKhoanDAO.DangNhap(TenDangNhap,MatKhau))
            {
                Session["TenDangNhap"] = TenDangNhap;
               // Session["VaiTro"] = tk.VaiTro;
                Response.Redirect("Default.aspx");
            }
            else
            {
                lblMessage.Text = " Tên đăng nhập hoặc mật khẩu không đúng!";
            }
        }
    }
}