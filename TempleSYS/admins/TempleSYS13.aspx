<%@ Page Title="" Language="C#" MasterPageFile="~/Dashboard01.Master" AutoEventWireup="true" CodeBehind="TempleSYS13.aspx.cs" Inherits="TempleSYS.admins.TempleSYS13" ValidateRequest="false"  %>
<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="<%= ResolveUrl("~/Scripts/ckeditor/ckeditor.js") %>"></script>

    <script>
        

        $(function () {
            CKEDITOR.replace('<%=txtBoContent.ClientID%>');
        })
        
     
</script>

    <div class="panel panel-primary">
        <div class="panel-heading">
            <h3 class="panel-title">公佈欄維護作業</h3>
        </div>
        <div class="panel-body">
            <asp:Button ID="btnQry" runat="server" Text="查詢"  CssClass="btn btn-primary" OnClick="btnQry_Click"  />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnAdd" runat="server" Text="新增"  CssClass="btn  btn-success" OnClick="btnAdd_Click"  />
            
            <asp:Panel ID="PanelQ" runat="server">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="Id" OnRowDataBound="GridView1_RowDataBound" OnRowCommand="GridView1_RowCommand" CssClass="rtable">
                    <Columns>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="btngv1Edit" runat="server" Text="編輯" CommandName="cmdEdit"  CssClass="btn btn-primary" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField HeaderText="公告日期" DataField="BoDate" />
                        <asp:BoundField HeaderText="內容" DataField="BoContent" HtmlEncode="false" />
                        <asp:BoundField HeaderText="公告截止日" DataField="BoEndDate" />
                        <asp:BoundField HeaderText="公告人" DataField="BoPeo" />
                        <asp:BoundField HeaderText="建立日期" DataField="CreateDate" />
                        <asp:BoundField HeaderText="建立人" DataField="CreateName" />
                        <asp:BoundField HeaderText="更新日期" DataField="UpdateDate" />
                        <asp:BoundField HeaderText="更新人" DataField="UpdateName" />
                    </Columns>
                </asp:GridView>
                   <div>
                    <div class="pull-right">
                        <webdiyer:AspNetPager ID="anp" runat="server" Width="100%" UrlPaging="true" CssClass="pagination" LayoutType="Ul" PagingButtonLayoutType="UnorderedList" PagingButtonSpacing="0" CurrentPageButtonClass="active" PageSize="20" OnPageChanged="anpList_PageChanged">
                        </webdiyer:AspNetPager>
                    </div>
                </div>

            </asp:Panel>


            <asp:Panel ID="PanelCRUD" runat="server">                

                <h3>公佈欄維護作業  編輯/新增</h3>
                <div class="form-horizontal">
                    <fieldset>
                         &nbsp;<div class="form-group">
                            <label class="col-lg-2 control-label">公告日期</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="txtBoDate" runat="server" CssClass="input-sm" autocomplete="off" onclick="GetDate()"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label">內容</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="txtBoContent" runat="server" TextMode="MultiLine" Height="200px" Width="600px"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label">公告截止日</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="txtBoEndDate" runat="server"  CssClass="input-sm" autocomplete="off"   onclick="GetDate()"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-lg-2 control-label">公告人</label>
                            <div class="col-lg-10">
                                <asp:TextBox ID="txtBoPeo" runat="server"  CssClass="input-sm" autocomplete="off"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                                <asp:Button ID="btnSave" runat="server" Text="儲存"  CssClass="btn btn-success"  OnClick="btnSave_Click"/>
                                &nbsp;&nbsp;
                                <asp:Button ID="btnCancel" runat="server" Text="取消"  CssClass="btn btn-danger"  OnClick="btnCancel_Click" />
                            </div>
                        </div>
                    </fieldset>
                </div>


            </asp:Panel>
        </div>
    </div>
<asp:HiddenField ID="hfId" runat="server" />
</asp:Content>
