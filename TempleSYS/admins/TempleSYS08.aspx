<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard01.Master" AutoEventWireup="true" CodeBehind="TempleSYS08.aspx.cs" Inherits="TempleSYS.TempleSYS08" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-info">
        <div class="panel-heading">
            <h3 class="panel-title">帳號管理作業</h3>
        </div>
        <div class="panel-body">

            <label>帳號:</label>
            <asp:TextBox ID="qtxtAccount" runat="server"></asp:TextBox>
            <label>姓名:</label>
            <asp:TextBox ID="qtxtUserName" runat="server"></asp:TextBox>
            &nbsp;<asp:Button ID="bnQry" runat="server" Text="查詢" CssClass="btn btn-sccess" OnClick="bnQry_Click" />

            &nbsp;&nbsp;

            <asp:Button ID="btnAdd" runat="server" Text="新增" CssClass="btn btn-sccess" OnClick="btnAdd_Click" />
            <table class="table table-border">
                <thead>
                    <tr class="warning">
                        <th></th>
                        <th>帳號</th>
                    
                        <th>姓名</th>
                        <th>角色代號</th>
                        <th>角色名稱</th>
                        <th>停用狀態</th>
                        <th>建立日期</th>
                        <th>建立人</th>
                        <th>更新時間</th>
                        <th>更新人</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="rep" runat="server">
                        <ItemTemplate>
                            <tr>
                                <td>
                                    <asp:LinkButton ID="lbEdit" runat="server" CommandArgument='<%#Eval("Id") %>' OnClick="lbEdit_Click" CssClass="btn btn-info">編輯</asp:LinkButton>
                                    &nbsp;
                            <asp:LinkButton ID="lbDelete" runat="server" CommandArgument='<%#Eval("Id") %>' OnClientClick="return confirm('确认删除吗？')" OnClick="lbDelete_Click" CssClass="btn btn-danger">删除</asp:LinkButton>&nbsp
             
                                </td>
                                <td><%#Eval("Account") %> </td>
                           
                                <td><%#Eval("UserName") %> </td>
                                <td><%#Eval("URole") %> </td>
                                <td><%#Eval("URoleName") %> </td>
                                <td><%#Eval("IsDelete") %> </td>
                                <td><%#Eval("CreateDate") %> </td>
                                <td><%#Eval("CreateName") %> </td>
                                <td><%#Eval("UpdateDate") %> </td>
                                <td><%#Eval("UpdateName") %> </td>

                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
            <div>
             


                 <div class="pull-right">
        <webdiyer:AspNetPager ID="anp" runat="server" Width="100%" UrlPaging="true" CssClass="pagination" LayoutType="Ul" PagingButtonLayoutType="UnorderedList" PagingButtonSpacing="0" CurrentPageButtonClass="active" PageSize="20" OnPageChanged="anpList_PageChanged">
        </webdiyer:AspNetPager></div>


            </div>
             
        </div>
    </div>



    <div class="panel panel-info">
        <div class="panel-heading">
            <h3 class="panel-title">帳號管理作業新增/編輯</h3>
        </div>
        <div class="panel-body">
            <table>
                <tr>
                    <td><label>帳號</label></td>
                    <td><asp:TextBox ID="txtAccount" runat="server" autocomplete="off" ></asp:TextBox></td>
                    <td><label>密碼</label></td>
                    <td><asp:TextBox ID="txtPassword" runat="server"  autocomplete="off" ></asp:TextBox></td>
                </tr>



                   <tr>
                    <td><label>姓名</label></td>
                    <td><asp:TextBox ID="txtUserName" runat="server" autocomplete="off" ></asp:TextBox></td>
                    <td><label>角色權限</label></td>
                    <td><asp:TextBox ID="txtURole" runat="server" autocomplete="off" ></asp:TextBox></td>
                </tr>
                   <tr>
                    <td><label>職稱</label></td>
                    <td><asp:TextBox ID="txtURoleName" runat="server" autocomplete="off" ></asp:TextBox></td>
                    <td><label>停用</label></td>
                    <td>
                    
                        <asp:CheckBox ID="chkIsDelete" runat="server" />
                    </td>
                </tr>
                   <tr>
                          <td><label>建立人</label></td>
                    <td><asp:Literal ID="ltCreateName" runat="server"  ></asp:Literal></td>

                    <td><label>建立日期</label></td>
                    <td><asp:Literal ID="ltCreateDate" runat="server"  ></asp:Literal></td>
                 
                </tr>
                   <tr>
                          <td><label>更新日期</label></td>
                    <td><asp:Literal ID="ltUpdateDate" runat="server"  ></asp:Literal></td>

                    <td><label>更新人</label></td>
                    <td><asp:Literal ID="ltUpdateName" runat="server"  ></asp:Literal></td>
                 
                </tr>
             
                <tr>   
                    <td colspan="2">
                        <asp:Button ID="btnSave" runat="server" Text="儲存" CssClass="btn btn-success" />
                               <asp:Button ID="btnBack" runat="server" Text="返回"  CssClass="btn btn-primary"  />
                    </td>
                </tr>
            </table>
        </div>
    </div>


</asp:Content>
