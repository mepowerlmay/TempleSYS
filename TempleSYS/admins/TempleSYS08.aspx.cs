using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TempleSYS.App_Code;
using Alonso.Utility;

namespace TempleSYS
{
    public partial class TempleSYS08 : BasePage
    {
        DAL.TempleUserDAL dal = new DAL.TempleUserDAL();

     
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                anp.RecordCount = dal.CalcCount(GetCond());
                BindRep();
            }
        }
        private void BindRep()
        {
            rep.DataSource = dal.GetListArray("*", "Id desc", anp.PageSize, anp.CurrentPageIndex, GetCond());
            rep.DataBind();
        }
        private string GetCond()
        {
            string cond = " ";
            var whereClausesBuilder = new WhereClausesBuilder();
            whereClausesBuilder.appendCriteriaText(qtxtAccount.Text, " like '%{0}%' ", ref cond);           
            whereClausesBuilder.appendCriteriaText(qtxtUserName.Text, " like '%{0}%' ", ref cond);


            return cond;
        }
        protected void anpList_PageChanged(object sender, EventArgs e)
        {
            anp.RecordCount = dal.CalcCount(GetCond());
            BindRep();
        }
        protected void search(object sender, EventArgs e)
        {
            anp.RecordCount = dal.CalcCount(GetCond());
            BindRep();
        }

        protected void lbEdit_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            int Id = TypeChange.StringToInt(lb.CommandArgument);

        }

        protected void lbDelete_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            int Id = TypeChange.StringToInt(lb.CommandArgument);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected void bnQry_Click(object sender, EventArgs e)
        {
            anp.RecordCount = dal.CalcCount(GetCond());
            BindRep();
        }
    }
}