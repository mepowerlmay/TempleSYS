<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TempleSYS.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
      
    
<div class="container">
    <div class="row">
    	<div class="col-md-8 col-md-offset-2">
   <div class="panel panel-info">
  <div class="panel-heading">
			    	<h3 class="panel-title">
                        
                        <br />
                        登入
			    	</h3>
			 	</div>
			  	<div class="panel-body">			  
                    <fieldset>
			    	  	<div class="form-group">			    	
                             <label>帳號:</label>
                            <asp:TextBox ID="txtAccount" runat="server" CssClass="form-control"></asp:TextBox>
			    		</div>
			    		<div class="form-group">
                            <label>密碼:</label>
                            <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
			    		</div>
			    	        <asp:Button ID="btnLogin" runat="server" Text="登入" CssClass=" btn btn-lg     btn-success " OnClick="btnLogin_Click" />
			  
			    	</fieldset>
			     
			    </div>
			</div>
		</div>
	</div>
</div>
    </form>
</body>
</html>
