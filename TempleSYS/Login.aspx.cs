using Alonso.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

using TempleSYS.DAL;
using TempleSYS.Model;

namespace TempleSYS
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Title = "彰化天后三聖宮-寺廟管理系統";

            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["TempleSYSCookieData"];

                if (cookie != null)
                {
                    // 載入預設帳號

                    txtAccount.Text = cookie["Account"];

                }

                HttpCookie cookie1 = new HttpCookie(FormsAuthentication.FormsCookieName, "");
                if (cookie1 != null)
                {
                    cookie1.Expires = DateTime.Now.AddYears(-1);
                    Response.Cookies.Add(cookie1);
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtAccount.Text.Trim()))
            {
                Tool.Alert("請輸入帳號!!", this);
                txtAccount.Focus();
                return;
            }

            if (string.IsNullOrEmpty(  txtPassword  .Text.Trim()))
            {
                Tool.Alert("請輸入密碼!!", this);
                txtPassword.Focus();
                return;
            }
            TempleUserDAL dal = new TempleUserDAL();
            TempleUser m = null;
            string Account = txtAccount.Text.Trim();
            string Password = txtPassword.Text.Trim();

            //產生一個Cookie
            HttpCookie cookie = new HttpCookie("TempleSYSCookieData");
            //設定單值
            cookie["Account"] = txtAccount.Text;
            //設定過期日
            cookie.Expires = DateTime.Now.AddDays(120);
            //寫到用戶端
            Response.Cookies.Add(cookie);

            string cond = $" UPPER(Account)='{Account.ToUpper()}'";

            if (dal.CalcCount(cond) < 1)
            {
                Tool.Alert("帳號不存在請重新輸入!!", this);
                txtAccount.Focus();
                return;
            }
            m = dal.GetModelByCond(cond);
            
            if (m.IsDelete  == 1)
            {
                Tool.Alert("帳號已停用!!!!", this);
                txtAccount.Focus();
                return;
            }

            //帳號密碼核對
            cond = $" UPPER(Account)='{Account.ToUpper()}' and Password ='{Password}'";
             m = dal.GetModelByCond(cond);

            if (m == null)
            {
                Tool.Alert("密碼輸入錯誤!!", this);
                txtPassword.Focus();
                return;
            }

            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,
            m.Account,
              DateTime.Now,
              DateTime.Now.AddMinutes(120),
             false,
              m.RoleId.ToString() ,             
              FormsAuthentication.FormsCookiePath);

            // Encrypt the ticket.
            string encTicket = FormsAuthentication.Encrypt(ticket);

            Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));

            Response.Redirect("~/Menus/TempleSYS11.aspx");
        }
    }
}