<%@ Page Language="C#" AutoEventWireup="true" Theme="Skin1" CodeBehind="default.aspx.cs" Inherits="CSS_themes_and_master_page._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="Text"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" CssClass="Button"/>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button2" runat="server" Text="Button" EnableTheming="false"/>
        <asp:Label ID="Label2" runat="server" Text="Label" SkinID="RedLabel"></asp:Label>
    </form>
</body>
</html>
