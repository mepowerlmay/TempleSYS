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
      this.Title = "彰化天后三聖宮 寺廟管理系統"; ;

            if (!User.Identity.IsAuthenticated)
            {
                Response.Redirect("~/Login.aspx");
            }

            base.OnPreLoad(e);  
        }


    }
}