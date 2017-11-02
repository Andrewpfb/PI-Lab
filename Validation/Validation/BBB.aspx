<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BBB.aspx.cs" Inherits="Validation.BBB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" ToolTip="Only russian char"></asp:TextBox>
            <asp:TextBox ID="TextBox6" runat="server" ToolTip="Only russian char"></asp:TextBox>
            <asp:TextBox ID="TextBox7" runat="server" ToolTip="Only russian char"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox6" Display="None" ErrorMessage="Check surname" ValidationExpression="^+$|^[А-ЯЁа-яё]+$"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="None" ErrorMessage="Name is empty"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextBox7" Display="None" ErrorMessage="Check patronymic" ValidationExpression="^[А-ЯЁа-яё]+$"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox6" Display="None" ErrorMessage="Surname is empty"></asp:RequiredFieldValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox7" Display="None" ErrorMessage="Patronymic is empty"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="TextBox2" runat="server" ToolTip="Date less now"></asp:TextBox>
            <asp:TextBox ID="HiddenDate" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox3" runat="server" ToolTip="Email"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox4" runat="server" ToolTip="Range"></asp:TextBox>
            <br />
            <asp:TextBox ID="TextBox5" runat="server" TextMode="Password" ToolTip="Pass, great 7, not duplicate"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox7" Display="None" ErrorMessage="Enter the pass"></asp:RequiredFieldValidator>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1" Display="None" ErrorMessage="Check name" ValidationExpression="^[А-ЯЁа-яё]+$"></asp:RegularExpressionValidator>
            &nbsp;&nbsp;&nbsp;
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="HiddenDate" Display="None" ErrorMessage="Date great now" Operator="GreaterThanEqual"></asp:CompareValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" Display="None" ErrorMessage="Incorrect email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            &nbsp;&nbsp;&nbsp;
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox4" Display="None" ErrorMessage="Value must 1000-2000" MaximumValue="2000" MinimumValue="1000"></asp:RangeValidator>
            &nbsp;&nbsp;<asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox5" Display="None" ErrorMessage="Pass contains duplicate char or length less 7" OnServerValidate="Check_Pass"></asp:CustomValidator>
            &nbsp;
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </p>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"/>
    </form>
</body>
</html>
