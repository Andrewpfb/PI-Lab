<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="lab_34.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="Label1" runat="server" />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
                <br />
                <asp:Button ID="Button3" runat="server" Text="Update Sync" />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button4" EventName="Click" />
                <asp:PostBackTrigger ControlID="Button3" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="Label2" runat="server" />
                <br />
                <asp:TextBox ID="TextBox1" runat="server" Width="250" AutoPostBack="true" OnTextChanged="TextBox1_TextChanged" />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button4" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="Label3" runat="server" />
                <br />
                <asp:CheckBox ID="CheckBox1" runat="server" Width="250" AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged" Text="AJAX CHECKBOX" />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button4" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel4" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="Label4" runat="server" />
                <br />
                <asp:RadioButton ID="RadioButton1" runat="server" Width="250" AutoPostBack="true" OnCheckedChanged="RadioButton1_CheckedChanged" Text="AJAX RADIO" />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button4" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <asp:UpdatePanel ID="UpdatePanel5" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="Label5" runat="server" />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Get custom error" OnClick="Button2_Click" />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button4" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>


        <asp:Button ID="Button4" runat="server" Text="Update all panel (async)" />


        <asp:Timer ID="Timer1" runat="server" Interval="1000" />
        <asp:Label ID="Label9" runat="server" Text="Timer. Update with interval 5 sec"></asp:Label>
        <br />
        <asp:UpdatePanel ID="UpdatePanel6" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="Label6" runat="server" />
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
            </Triggers>
        </asp:UpdatePanel>



        <asp:UpdatePanel ID="UpdatePanel7" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Label ID="Label7" runat="server" />
                <asp:Timer ID="Timer2" runat="server" Interval="5000" />
            </ContentTemplate>

        </asp:UpdatePanel>






        <asp:UpdatePanel ID="UpdatePanel8" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div style="background-color: #FFFFE0; padding: 20px">
                    <asp:Label ID="Label8" runat="server" Font-Bold="True" />
                    <br />
                    <br />
                    <asp:Button ID="cmdRefreshTime" runat="server"
                        Text="Go update"
                        OnClick="cmdRefreshTime_Click" />
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <asp:UpdateProgress ID="UpdateProgress1" runat="server">
            <ProgressTemplate>
                <br />
                <br />
                <div style="font-size: x-small">
                    Соединение с сервером ...
                        <img src="ajax-loader.gif" alt="Загрузка" style="vertical-align: middle" />
                    <input id="Button10" onclick="AbortPostBack()"
                        type="button" value="Cancel" />
                </div>
            </ProgressTemplate>
        </asp:UpdateProgress>




    </form>
    <script type="text/javascript">


        var prm = Sys.WebForms.PageRequestManager.getInstance();
        prm.add_initializeRequest(InitializeRequest);

        function InitializeRequest(sender, args) {
            if (prm.get_isInAsyncPostBack()) {
                args.set_cancel(true);
            }
        }

        function AbortPostBack() {
            if (prm.get_isInAsyncPostBack()) {
                prm.abortPostBack();
            }
        }



        function pageLoad() {
            var pageManager = Sys.WebForms.PageRequestManager.getInstance();
            pageManager.add_endRequest(endRequest);
        }

        function endRequest(sender, args) {
            debugger;
            // Обработка ошибки
            if (args.get_error() != null) {
                $get("Label5").innerHTML = args.get_error().message;

                // Подавить вывод ошибки в консоль
                args.set_errorHandled(true);
            }
        }
    </script>

</body>
</html>
