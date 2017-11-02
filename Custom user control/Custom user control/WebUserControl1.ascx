<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="Custom_user_control.WebUserControl1" %>
<asp:TextBox ID="FirstnameTB" runat="server"></asp:TextBox>
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="LastnameTB" Display="None" ErrorMessage="Enter the lastname"></asp:RequiredFieldValidator>
<br />
<asp:TextBox ID="LastnameTB" runat="server"></asp:TextBox>
<br />
<asp:TextBox ID="MiddlenameTB" runat="server"></asp:TextBox>
<br />
<asp:TextBox ID="BirthDateTB" runat="server"></asp:TextBox>

<asp:RadioButtonList ID="SexRadioList" runat="server" RepeatDirection="Horizontal">
    <asp:ListItem>М</asp:ListItem>
    <asp:ListItem>Ж</asp:ListItem>
</asp:RadioButtonList>


<asp:DropDownList ID="FacultyList" runat="server">
    <asp:ListItem>FIT</asp:ListItem>
    <asp:ListItem>PIM</asp:ListItem>
    <asp:ListItem>TOV</asp:ListItem>
</asp:DropDownList>
<br />
<asp:TextBox ID="GroupTB" runat="server"></asp:TextBox>
<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="GroupTB" ErrorMessage="Group must be 1-100" MaximumValue="100" MinimumValue="1" Display="None" Type="Integer"></asp:RangeValidator>
<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="GroupTB" Display="None" ErrorMessage="Enter group(1-100)"></asp:RequiredFieldValidator>
<br />
<asp:TextBox ID="EnterDateTB" runat="server"></asp:TextBox>
<br />
<asp:Button ID="OkButton" runat="server" Text="OK" OnClick="OkButton_Click" />
&nbsp;&nbsp;&nbsp;
<asp:Button ID="CLButton" runat="server" Text="Cancel" OnClick="CLButton_Click" />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />



