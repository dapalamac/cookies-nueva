<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="cookies_nueva._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><br />

            <div id="msgDiv" runat="server" visible="false" />

            <asp:label ID="welcomelabel" runat="server"/>

            </div>
            <div id ="textdiv" runat="server" visible="false" />
            
            Name: <asp:TextBox ID="NameTextBox" runat="server" /><br />

            <asp:Button ID="SignUpButton" Text="Sign up" runat="server" />

        </div>
    </form>
</body>
</html>
