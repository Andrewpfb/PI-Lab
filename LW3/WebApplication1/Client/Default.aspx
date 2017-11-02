<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Client.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <asp:Label ID="Label1" runat="server" Text="A:  "></asp:Label>
        <asp:TextBox ID="TBA" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="B:  "></asp:Label>
        <asp:TextBox ID="TBB" runat="server"></asp:TextBox>
        <asp:Button ID="PostButton" runat="server" Text="Post" Width="67px" OnClientClick="OnClick(); return false"/>
        <input type="text" id="TBR" />
        <br />
        <asp:Button ID="GetButton" runat="server" Text="Get" Width="67px" OnClick="GetButton_Click" />
        <asp:Button ID="OptionsButton" runat="server" Text="Options" Width="67px" OnClick="OptionsButton_Click" />
        <asp:Button ID="PutButton" runat="server" OnClick="PutButton_Click" Text="Put" Width="56px" />
    </form>
    <script type="text/javascript">
        function OnClick()
        {
            var xhr = new XMLHttpRequest();
            var a = document.getElementById("TBA").value;
            var b = document.getElementById("TBB").value;
            var body = "a=" + encodeURIComponent(a) + "&b=" + encodeURIComponent(b);
            xhr.open("POST", "http://localhost:80/handlers/yyy.ndy", true);
            xhr.setRequestHeader("Content-Type", "application/x-www-form-urlencoded");
            xhr.send(body);
            xhr.onreadystatechange = function () {
                if (xhr.readyState == 4) {
                    if (xhr.status == 200) {
                        document.getElementById("TBR").value = xhr.responseText;
                    }
                }
            };
        }
    </script>
</body>
</html>
