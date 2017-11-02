<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body style="height: 285px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="16px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Height="24px" OnClick="Button1_Click" Text="Press" Width="64px" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Button" />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;
        </p>
        <asp:DropDownList ID="DropList" runat="server">
        </asp:DropDownList>
        <asp:CheckBox ID="Check" runat="server" AutoPostBack="True" OnCheckedChanged="Check_CheckedChanged" />
        <p>
            <asp:Button ID="Button2" runat="server" Text="Get System Info" OnClick="Button2_Click" />
        </p>
        <p>
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
