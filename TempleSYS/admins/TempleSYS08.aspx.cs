using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TempleSYS.App_Code;
using Alonso.Utility;
using TempleSYS.Model;
using TempleSYS.DAL;

namespace TempleSYS
{
    public partial class TempleSYS08 : BasePage
    {
        DAL.TempleUserDAL templeUserDAL = new DAL.TempleUserDAL();

        Temple_t_roleDAL temple_t_roleDAL = new Temple_t_roleDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                BindRep();
                ShowCRUD(emCRUD.View);

                GetDDLRole();
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            ShowCRUD(emCRUD.View);
            BindRep();
        }

       
        protected void anpList_PageChanged(object sender, EventArgs e)
        {

            BindRep();
        }
        protected void search(object sender, EventArgs e)
        {

            BindRep();
        }

        protected void lbEdit_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            int Id = TypeChange.StringToInt(lb.CommandArgument);
            hfId.Value = Id.ToString();
            TempleUser m = templeUserDAL.GetModel(Id);
            ShowCRUD(emCRUD.Edit);
            EnableCo(emCRUD.Edit);
            SetData(m);
        }

        protected void lbDelete_Click(object sender, EventArgs e)
        {
            LinkButton lb = (LinkButton)sender;
            int Id = TypeChange.StringToInt(lb.CommandArgument);
            templeUserDAL.Delete(Id);
            BindRep();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ShowCRUD(emCRUD.Edit);
            ClearData();
            EnableCo(emCRUD.Add);
        }



        protected void bnQry_Click(object sender, EventArgs e)
        {
            BindRep();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {   
            string stxtAccount = txtAccount.Text;//帳號
            string stxtPassword = txtPassword.Text; //密碼
            string stxtUserName = txtUserName.Text ; //姓名
            string sRole = ddlRole.SelectedValue;//腳色
            string stxtURoleName = txtURoleName.Text; //職稱
            int sIsDelete = chkIsDelete.Checked ? 1 : 0; //是否停用

            WhereClausesBuilder WhereClausesBuilder = new WhereClausesBuilder();
            string cond = " 1=1 ";

            if (string.IsNullOrEmpty(stxtAccount))
            {
                Tool.Alert("請輸入帳號!!", this);
                return;
            }

            if (string.IsNullOrEmpty(stxtPassword))
            {
                Tool.Alert("請輸入密碼!!", this);
                return;
            }


            if (string.IsNullOrEmpty(stxtUserName))
            {
                Tool.Alert("請輸入姓名!!", this);
                return;
            }


            if (string.IsNullOrEmpty(sRole))
            {
                Tool.Alert("請選擇角色!!", this);
                return;
            }
            if (string.IsNullOrEmpty(stxtURoleName))
            {
                Tool.Alert("請輸入職稱!!", this);
                return;
            }


            TempleUser m = new TempleUser();
        
            if (hfId.Value == "0")
            {
                //新增
                //1.檢查帳號有無重複...

                cond = " 1 =1 ";
                     
                WhereClausesBuilder.appendCriteriaText(txtAccount.Text.Trim().ToUpper(), " upper(Account)  = '{0}' ",ref cond);
                if (templeUserDAL.CalcCount(cond) > 0) {
                    Tool.Alert("帳號重複!!請輸入其他帳號", this);
                    ShowCRUD(emCRUD.Edit);
                    return;
                }

                m.Account = txtAccount.Text;
                m.Password = txtPassword.Text;
                m.UserName = txtUserName.Text;
                m.URole = ddlRole.SelectedValue;
                m.URoleName = txtURoleName.Text;
                m.IsDelete = sIsDelete;
                m.UpdateDate = DateTime.Now;
                m.CreateDate = DateTime.Now;
                m.CreateName = "Alonso";
                m.UpdateName = "Alonso";

                templeUserDAL.Add(m);

            }
            else
            {
                //編輯
                int Id = Convert.ToInt32(hfId.Value);
                m = templeUserDAL.GetModel(Id);

             

                m.Account = txtAccount.Text;
                m.Password = txtPassword.Text;
                m.UserName = txtUserName.Text;
                m.URole = ddlRole.SelectedValue;
                m.URoleName = txtURoleName.Text;
                m.IsDelete = sIsDelete;
                m.UpdateDate = DateTime.Now;                
                m.UpdateName = "Alonso";
                templeUserDAL.Update(m);

            }
            Tool.Alert("儲存成功",this);
            ShowCRUD(emCRUD.View);
            BindRep();
        }

        #region method

        /// <summary>
        /// 取腳色 選單
        /// </summary>
        private void GetDDLRole()
        {
            ddlRole.Items.Clear();

         var result =   temple_t_roleDAL.GetListArray("");

            foreach (var item in result)
            {
                ddlRole.Items.Add(new ListItem { Text= item.Rolename , Value = item.Id.ToString() });
            }

            ddlRole.Items.Insert(0, new ListItem { Text = "請選擇", Value = "" });

        }

        private void ShowCRUD(emCRUD em)
        {
            PanelQ.Visible = PanelCRUD.Visible = false;
            if (em == emCRUD.View)
            {
                PanelQ.Visible = true;
            }

            if (em == emCRUD.Edit)
            {
                PanelCRUD.Visible = true;
            }
        }

        private void BindRep()
        {
            anp.RecordCount = templeUserDAL.CalcCount(GetCond());
            rep.DataSource = templeUserDAL.GetListArray("*", "Id desc", anp.PageSize, anp.CurrentPageIndex, GetCond());
            rep.DataBind();
        }
        private string GetCond()
        {
            string cond = "1=1";
            var whereClausesBuilder = new WhereClausesBuilder();
            whereClausesBuilder.appendCriteriaText(qtxtAccount.Text, " Account like '%{0}%' ", ref cond);
            whereClausesBuilder.appendCriteriaText(qtxtUserName.Text, " UserName like '%{0}%' ", ref cond);


            return cond;
        }

        private void SetData(TempleUser m)
        {
            hfId.Value = "0";  //主KEY
            txtAccount.Text = m.Account; //帳號
            txtUserName.Text = m.UserName; //姓名
            txtURoleName.Text = m.URoleName; //職稱
                                             //txtPassword.Text = "; 
//chkIsDelete .Checked = m.IsDelete  =
            txtPassword.Attributes.Add("value", m.Password);  //密碼

            //txtURole.Text = ""; //腳色ID
            ltCreateName.Text = m.CreateName;  //建立者姓名
            ltCreateDate.Text = m.CreateDate.HasValue ? m.CreateDate.Value.ToString("yyyy/MM/dd") : ""; //建立日期

            ltUpdateName.Text = "";  //更新人
            ltUpdateDate.Text = m.UpdateDate.HasValue ? m.UpdateDate.Value.ToString("yyyy/MM/dd") : ""; ;  //更新日期
        }

        private void EnableCo(emCRUD e)
        {

            ///編輯時 不可修改帳號
            txtAccount.Enabled = false;

            if (e == emCRUD.Add)
            {
                txtAccount.Enabled = true;
            }

            if (e == emCRUD.Edit)
            {
                txtAccount.Enabled = false;
            }
        }

        /// <summary>
        /// 清楚資料
        /// </summary>
        private void ClearData()
        {
            hfId.Value = "0";  //主KEY
            txtAccount.Text = ""; //帳號
            txtUserName.Text = ""; //姓名
            txtURoleName.Text = ""; //職稱
            txtPassword.Text = ""; //密碼
            txtPassword.Attributes.Remove("value");

            //txtURole.Text = ""; //腳色ID

            ddlRole.SelectedIndex = -1;
            ltCreateName.Text = "";  //建立者姓名
            ltCreateDate.Text = ""; //建立日期
            ltUpdateDate.Text = "";  //更新日期
            ltUpdateName.Text = "";  //更新人
        }


        #endregion

   
    }
}