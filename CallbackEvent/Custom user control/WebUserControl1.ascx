<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="Custom_user_control.WebUserControl1" %>
<script type="text/javascript">
    function SendData() {
        var firstname = document.getElementById("WebUserControl11_FirstnameTB");
        var lastname = document.getElementById("WebUserControl11_LastnameTB");
        var middlename = document.getElementById("WebUserControl11_MiddlenameTB");
        var birthDate = document.getElementById("WebUserControl11_BirthDateTB");
        var faculty = document.getElementById("WebUserControl11_FacultyList");
        var group = document.getElementById("WebUserControl11_GroupTB");
        var enterDate = document.getElementById("WebUserControl11_EnterDateTB");
        var sexM = document.getElementById("WebUserControl11_SexRadioList_0");
        var sexW = document.getElementById("WebUserControl11_SexRadioList_1");
        var sex = sexM.checked ? 'М' : 'Ж';
        CallServer(firstname.value + "," + lastname.value + "," + middlename.value + "," +
            birthDate.value + "," + faculty.value + "," + sex + "," + group.value + "," + enterDate.value);
    }
    function ReceiveServerData(arg, context) {
        var dc = document.getElementById("message");
        dc.innerText = arg;
    }
</script>
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
<br />
<asp:TextBox ID="EnterDateTB" runat="server"></asp:TextBox>
<br />
<asp:Button ID="OkButton" runat="server" Text="OK" OnClientClick="SendData(); return false;" OnClick="OkButton_Click" />
&nbsp;&nbsp;&nbsp;
<asp:Button ID="CLButton" runat="server" Text="Cancel" OnClick="CLButton_Click" />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />



<p>
    <span id="message"></span>
</p>




