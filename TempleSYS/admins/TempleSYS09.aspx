<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard01.Master" AutoEventWireup="true" CodeBehind="TempleSYS09.aspx.cs" Inherits="TempleSYS.TempleSYS09" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 130px;
        }
    </style>


    <asp:HiddenField ID="hfoperate" runat="server" />
    <asp:HiddenField ID="hfroleid" runat="server" />

    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title">權限維護作業</h3>
        </div>
        <div class="panel-body">
                
              <table class="style1">
        <tr>
            <td class="style2" rowspan="2">
                <asp:ListBox ID="lsbrole" DataTextField="rolename" DataValueField="id" runat="server"
                    AutoPostBack="True" Width="76px" OnSelectedIndexChanged="lsbrole_SelectedIndexChanged">
                </asp:ListBox>
            </td>
            <td>
                您選擇的角色是：<asp:Literal ID="litrole" runat="server"></asp:Literal>
                <br />
                <asp:Repeater ID="rep" runat="server" onitemdatabound="rep_ItemDataBound">
                    <ItemTemplate>
                        
                        <asp:Literal ID="litname" Text='<%#Eval("ModuleName") %>' runat="server"></asp:Literal>
                        <asp:Repeater ID="rep2" runat="server" onitemdatabound="rep2_ItemDataBound">
                            <ItemTemplate>
                                <asp:CheckBox ID="chk" ToolTip='<%#Eval("id") %>' runat="server" Text='<%#Eval("cmd") %>' />
                            </ItemTemplate>
                        </asp:Repeater>
                        <br />
                    </ItemTemplate>
                </asp:Repeater>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="新增角色" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="编辑角色" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="删除角色" OnClick="Button3_Click" />
                <asp:Button ID="Button4" runat="server" Text="授權" onclick="Button4_Click" />
            </td>
        </tr>
    </table>

              <div id="pop" style="z-index: 10; position: absolute; display: none; background-color: White;
        border: 3px solid blue; width: 400px; height: 150px; line-height: 50px;">
        角色名稱：
        <asp:TextBox ID="txtrolename" runat="server"></asp:TextBox>
        <asp:Button ID="Button5" runat="server" Text="确定" OnClick="OK" />
        <input type="button" value="取消" onclick="$.popup.close('#pop')" />
    </div>

        </div>
    </div>
</asp:Content>
