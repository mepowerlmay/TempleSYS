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

namespace TempleSYS
{
    public partial class TempleSYS09 : BasePage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lsbrole.DataSource = new DAL.Temple_t_roleDAL().GetListArray("");
                lsbrole.DataBind();

                rep.DataSource = new DAL.Temple_t_qxDAL().QueryWithJoin(" select distinct ModuleName from  Temple_t_qx ", "");
                rep.DataBind();
            }
        }
        //选择角色
        protected void lsbrole_SelectedIndexChanged(object sender, EventArgs e)
        {
            hfroleid.Value = lsbrole.SelectedValue;
            litrole.Text = lsbrole.SelectedItem.Text;

            rep.DataSource = new DAL.Temple_t_qxDAL().QueryWithJoin("  select distinct ModuleName from  Temple_t_qx", "");
            rep.DataBind();
        }
        //新增角色
        protected void Button1_Click(object sender, EventArgs e)
        {
            hfoperate.Value = "add";
            txtrolename.Text = "";
            Tool.ExecJS("$.popup.open('#pop')", this.Page);
        }
        //编辑角色
        protected void Button2_Click(object sender, EventArgs e)
        {
            int x;
            if (!int.TryParse(hfroleid.Value, out x))
            {
                Tool.Alert("请先选择要编辑的角色。", this.Page);
                return;
            }
            hfoperate.Value = "edit";
            txtrolename.Text = litrole.Text;
            Tool.ExecJS("$.popup.open('#pop')", this.Page);
        }
        //确定
        protected void OK(object sender, EventArgs e)
        {
            string name = txtrolename.Text.Trim();
            if (name.Length == 0)
            {
                Tool.Alert("请输入角色名称。", this.Page);


                return;
            }
            DAL.Temple_t_roleDAL dal = new Temple_t_roleDAL();
            if (hfoperate.Value == "add")
            {
                name = Tool.GetSafeSQL(name);
                if (dal.CalcCount("rolename='" + name + "'") > 0)
                {
                    Tool.Alert("角色名称重复，请重新输入。", this.Page);


                    return;
                }
                dal.Add(new Temple_t_role()
                {
                     Rolename = name
                });
            }
            else if (hfoperate.Value == "edit")
            {
                Temple_t_role r = dal.GetModel(int.Parse(hfroleid.Value));
                if (r != null)
                {
                    r.Rolename = name;
                    dal.Update(r);
                }
            }
            Response.Redirect(Request.Url.ToString());
        }
        //删除角色
        protected void Button3_Click(object sender, EventArgs e)
        {
            int x;
            if (!int.TryParse(hfroleid.Value, out x))
            {
                Tool.Alert("请先选择要编辑的角色。", this.Page);
                return;
            }
            new DAL.Temple_t_roleDAL().Delete(x);
            Response.Redirect(Request.Url.ToString());
        }
        //外层循环
        protected void rep_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                Repeater rep2 = e.Item.FindControl("rep2") as Repeater;
                string name = (e.Item.FindControl("litname") as Literal).Text;
                rep2.DataSource = new DAL.Temple_t_qxDAL().GetListArray("ModuleName='" + name + "'");
                rep2.DataBind();
            }
        }
        //内层循环
        protected void rep2_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem || e.Item.ItemType == ListItemType.Item)
            {
                CheckBox chk = e.Item.FindControl("chk") as CheckBox;
                int qxid = int.Parse(chk.ToolTip);
                int roleid;
                if (int.TryParse(hfroleid.Value, out roleid))
                {
                    if (new DAL.Temple_t_role_qxDAL().CalcCount("roleid=" + roleid + " and qxid=" + qxid) > 0)
                    {
                        //有权限 
                        chk.Checked = true;
                    }
                    else
                    {
                        chk.Checked = false;
                    }
                }
            }
        }
        //授权
        protected void Button4_Click(object sender, EventArgs e)
        {
            int roleid;
            if (!int.TryParse(hfroleid.Value, out roleid))
            {
                Tool.Alert("请先选择要授权的角色。", this.Page);
                return;
            }

            foreach (RepeaterItem item in rep.Items)
            {
                Repeater rep2 = item.FindControl("rep2") as Repeater;
                foreach (RepeaterItem item2 in rep2.Items)
                {
                    CheckBox chk = item2.FindControl("chk") as CheckBox;
                    int qxid = int.Parse(chk.ToolTip);
                    if (chk.Checked)
                    {
                        //授权
                        if (new DAL.Temple_t_role_qxDAL().CalcCount("roleid=" + roleid + " and qxid=" + qxid) == 0)
                        {
                            new DAL.Temple_t_role_qxDAL().Add(new Temple_t_role_qx()
                            {
                              qxid = qxid ,
                               roleid = roleid
                            });
                        }
                    }
                    else
                    {
                        string cond = "roleid=" + roleid + " and qxid=" + qxid;

                        //取消授权
                        if (new DAL.Temple_t_role_qxDAL().CalcCount("roleid=" + roleid + " and qxid=" + qxid) > 0)
                        {
                            new DAL.Temple_t_role_qxDAL().DeleteByCond(cond);
                        }
                    }
                }
            }
            Tool.Alert("授权成功。", this.Page);

        }


    }
}