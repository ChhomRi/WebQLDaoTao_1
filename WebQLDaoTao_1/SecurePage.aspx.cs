using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebQLDaoTao_1
{
    public partial class SecurePage : System.Web.UI.Page
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Session["TaiKhoan"] == null)
            {
                string currentPage = Request.Url.AbsolutePath.ToLower();


                if (!currentPage.EndsWith("login.aspx"))
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }
    }
}