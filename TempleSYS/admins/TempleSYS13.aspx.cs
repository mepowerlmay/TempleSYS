using Alonso.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TempleSYS.App_Code;
using TempleSYS.DAL;
using TempleSYS.Model;

namespace TempleSYS.admins
{
    public partial class TempleSYS13 : BasePage
    {
        private TempleBoardDAL templeBoardDAL;


        public TempleSYS13() {

            templeBoardDAL = new TempleBoardDAL();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {              
                BindRep();
                ShowCRUD(emCRUD.View);
            }
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
            anp .RecordCount = templeBoardDAL.CalcCount(GetCond());

       
            GridView1.DataSource = templeBoardDAL.GetListArray("*", "id desc", anp.PageSize, anp.CurrentPageIndex, GetCond());
            GridView1.DataBind();
        }

        private string GetCond()
        {
            string cond = " 1=1 ";
            return cond;
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {

            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //GridView customersGridView = (GridView)e.CommandSource;

            //這樣就可以讀到RowIndex
            

            GridViewRow gvr = (GridViewRow)(((Button)e.CommandSource).NamingContainer);

            

            int rowIndex = int.Parse(e.CommandArgument.ToString());
            string Id = (string)this.GridView1.DataKeys[rowIndex]["Id"]; 


            //這樣就可以取得Keys值了
            //string keyId = GridView1.DataMember

        }

        protected void btnQry_Click(object sender, EventArgs e)
        {
            BindRep();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            hfId.Value = "0";
            ClearData();

            ShowCRUD(emCRUD.Edit);
        }

        /// <summary>
        /// 清空資訊
        /// </summary>
        private void ClearData()
        {
            txtBoDate.Text = "";
            txtBoContent.Text = "";
            txtBoEndDate.Text = "";
            txtBoPeo.Text = "";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string stxtBoDate = txtBoDate.Text.Trim(); //公告日期
            string stxtBoContent = txtBoContent.Text.Trim(); //公告內容
            string stxtBoEndDate = txtBoEndDate.Text.Trim(); //截止日期
            string stxtBoPeo = txtBoPeo.Text.Trim(); //公告人

            if (string.IsNullOrEmpty(stxtBoDate))
            {
                Tool.Alert("請輸入公告日期!!", this);
                return;
            }

            if (string.IsNullOrEmpty(stxtBoContent))
            {
                Tool.Alert("請輸入公告內容!!", this);
                return;
            }

            if (string.IsNullOrEmpty(stxtBoEndDate))
            {
                Tool.Alert("請輸入截止日期!!", this);
                return;
            }

            if (string.IsNullOrEmpty(stxtBoPeo))
            {
                Tool.Alert("請輸入公告人!!", this);
                return;
            }

            TempleBoard m = null;

            if (hfId.Value =="0")
            {
                //新增
                m = new TempleBoard();
                m.BoDate = DateTime.Parse(stxtBoDate);
                m.BoContent = stxtBoContent;
                if (!string.IsNullOrEmpty(stxtBoEndDate))
                {
                    m.BoEndDate = DateTime.Parse(stxtBoEndDate);
                }

                m.BoPeo = stxtBoPeo;
                m.CreateDate = DateTime.Now;
                m.CreateName = User.Identity.Name;
                m.UpdateDate = DateTime.Now;
                m.UpdateName = User.Identity.Name;
                templeBoardDAL.Add(m);

            }
            else
            {
                //編輯
                m = templeBoardDAL.GetModel(Convert.ToInt32(hfId.Value));

                m.BoDate = DateTime.Parse(stxtBoDate);
                m.BoContent = stxtBoContent;
                if (!string.IsNullOrEmpty(stxtBoEndDate))
                {
                    m.BoEndDate = DateTime.Parse(stxtBoEndDate);
                }

                m.BoPeo = stxtBoPeo;                
                m.UpdateDate = DateTime.Now;
                m.UpdateName = User.Identity.Name;
                templeBoardDAL.Update(m);
            }
            Tool.Alert("儲存成功!!!", this);

            BindRep();
            ShowCRUD(emCRUD.View);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            BindRep();
            ShowCRUD(emCRUD.View);
        }
        protected void anpList_PageChanged(object sender, EventArgs e)
        {
            BindRep();
            ShowCRUD(emCRUD.View);
        }
    }
}