<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Html_servers_elements.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="InputReset"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Reset1" type="reset" value="reset" runat="server" onserverclick="Reset_OnServerClick"/>
        <br />
        <asp:Label ID="Label2" runat="server" Text="InputButton"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Button1" type="button" value="button" runat="server" onserverclick="Button_OnServerClick"/>
        <br />
        <asp:Label ID="Label3" runat="server" Text="InputSubmit"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Submit1" type="submit" value="submit" runat="server" onserverclick="Submit_OnServerClick"/>
        <br />
        <asp:Label ID="Label4" runat="server" Text="InputFile"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="File1" type="file" runat="server" onserverclick="File_OnServerClick"/>
        <br />
        <asp:Label ID="Label5" runat="server" Text="InputText"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Text1" type="text" runat="server" onserverchange="Common_OnServerChange"/>
        <br />
        <asp:Label ID="Label6" runat="server" Text="InputPassword"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Password1" type="password" runat="server" onserverchange="Common_OnServerChange"/>
        <br />
        <asp:Label ID="Label7" runat="server" Text="InputCheckbox"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <input id="Checkbox1" type="checkbox" runat="server" onserverchange="Common_OnServerChange"/>
        <br />
        <asp:Label ID="Label8" runat="server" Text="InputRadioButton"></asp:Label>
        &nbsp;&nbsp;
        <input id="Radio1" type="radio" runat="server" onserverchange="Common_OnServerChange"/>
        <br />
        <asp:Label ID="Label9" runat="server" Text="TextArea"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <textarea id="TextArea1" cols="20" rows="2" runat="server" onserverchange="Common_OnServerChange"></textarea>
        <br />
        <asp:Label ID="Label10" runat="server" Text="Select"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <select id="Select1" runat="server" onserverchange="Common_OnServerChange">
            <option></option>

        </select>
    </form>
</body>
</html>
