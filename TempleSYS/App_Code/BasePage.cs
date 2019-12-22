using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TempleSYS.App_Code
{
    public class BasePage : System.Web.UI.Page
    {
        protected override void OnPreLoad(EventArgs e)
        {

            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("Login.aspx");
            }

            base.OnPreLoad(e);  
        }


    }
}