<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2__handler_client_.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="GetBtn" runat="server" Text="Get" Width="67px" OnClick="GetBtn_Click" />
        <asp:Button ID="PostBtn" runat="server" Text="Post" Width="67px" OnClick="PostBtn_Click" />
        <asp:Button ID="PutBtn" runat="server" Text="Put" Width="67px" OnClick="PutBtn_Click" />
    </form>
</body>
</html>
