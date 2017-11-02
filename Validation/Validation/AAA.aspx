<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AAA.aspx.cs" Inherits="Validation.AAA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" Text="RequiredFieldValidator"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" ValidationGroup="g1">
        </asp:DropDownList>
        <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="g1"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="g1" />
        <p>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="DropDown Not " ValidationGroup="g1" ControlToValidate="DropDownList1" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="TextBox Not" ValidationGroup="g1" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <div>
            <asp:Label runat="server" Text="RangeValidator"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" ValidationGroup="g2"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" ValidationGroup="g2"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Button" ValidationGroup="g2" />
        </div>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="TextBox not range int" ValidationGroup="g2" ControlToValidate="TextBox2" ForeColor="Red" MaximumValue="200" MinimumValue="100" Type="Integer"></asp:RangeValidator>
        <br />
        <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="TextBox not range date" ValidationGroup="g2" ControlToValidate="TextBox3" ForeColor="Red" MaximumValue="31.12.2011" MinimumValue="01.01.2011" Type="Date"></asp:RangeValidator>
        <div>
            <asp:Label runat="server" Text="CompareValidator"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" ValidationGroup="g3"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" ValidationGroup="g3"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" Text="Button" ValidationGroup="g3" />
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox5" ControlToValidate="TextBox4" ErrorMessage="CompareValidator" ValidationGroup="g3" ForeColor="Red" Operator="LessThan" Type="Date"></asp:CompareValidator>
        </div>
        <div>
            <asp:Label runat="server" Text="RegularExpressionValidator"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" ValidationGroup="g4"></asp:TextBox>
            <asp:Button ID="Button4" runat="server" Text="Button" ValidationGroup="g4" />
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Check Email" ValidationGroup="g4" ControlToValidate="TextBox6" ForeColor="Red" ValidationExpression="\S+@\S+\.\S+"></asp:RegularExpressionValidator>
        </div>
        <div>
            <asp:TextBox ID="TextBox7" runat="server" ValidationGroup="g5"></asp:TextBox>
            <asp:Button ID="Button5" runat="server" Text="Button" ValidationGroup="g5" />
            <br />
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="TextBox7" ErrorMessage="Not simple" ForeColor="Red" ValidationGroup="g5" OnServerValidate="Error_Handler" ClientValidationFunction="JsErrorHandler"></asp:CustomValidator>
        </div>
    </form>
    <script type="text/javascript">
        function JsErrorHandler(c, a) {
            debugger
            var isSimple = true;
            for (var i = 2; i <= a.Value / 2; i++) {
                debugger
                if (a.Value % i == 0) {
                    debugger
                    isSimple = false;
                    break;
                }
            }
            a.IsValid = (isSimple) ? true : false;
        }
    </script>
</body>
</html>
