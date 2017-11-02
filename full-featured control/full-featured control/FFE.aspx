<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FFE.aspx.cs" Inherits="full_featured_control.FFE" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" Height="253px" Width="607px" OnActiveStepChanged="Wizard1_ActiveStepChanged" OnFinishButtonClick="Wizard1_FinishButtonClick" DisplayCancelButton="True" OnCancelButtonClick="Wizard1_CancelButtonClick">
                    <FinishNavigationTemplate>
                        <asp:Button ID="FinishPreviousButton" runat="server" BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="MovePrevious" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" Text="Предыдущ." />
                        <asp:Button ID="FinishButton" runat="server" BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" CommandName="MoveComplete" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" Text="Готово" />
                    </FinishNavigationTemplate>
                    <HeaderStyle BackColor="#284E98" BorderColor="#EFF3FB" BorderStyle="Solid" BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White" HorizontalAlign="Center" />
                    <NavigationButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284E98" />
                    <SideBarButtonStyle BackColor="#507CD1" Font-Names="Verdana" ForeColor="White" />
                    <SideBarStyle BackColor="#507CD1" Font-Size="0.9em" VerticalAlign="Top" />
                    <StepStyle Font-Size="0.8em" ForeColor="#333333" />
                    <WizardSteps>
                        <asp:WizardStep runat="server" Title="Personal data">
                            <asp:Table ID="Table1" runat="server" Height="92px" Width="130px">
                                <asp:TableRow runat="server">
                                    <asp:TableCell runat="server">
                                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow runat="server">
                                    <asp:TableCell runat="server">
                                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                                <asp:TableRow runat="server">
                                    <asp:TableCell runat="server">
                                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                                    </asp:TableCell>
                                </asp:TableRow>
                            </asp:Table>

                        </asp:WizardStep>
                        <asp:WizardStep runat="server" Title="Change">
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                                <asp:ListItem>Rad1</asp:ListItem>
                                <asp:ListItem>Rad2</asp:ListItem>
                                <asp:ListItem>Rad3</asp:ListItem>
                            </asp:RadioButtonList>
                        </asp:WizardStep>
                        <asp:WizardStep runat="server" Title="Additional services">
                            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                                <asp:ListItem>Chk1</asp:ListItem>
                                <asp:ListItem>Chk2</asp:ListItem>
                                <asp:ListItem>Chk3</asp:ListItem>
                            </asp:CheckBoxList>
                        </asp:WizardStep>
                        <asp:WizardStep runat="server" Title="Pay">
                            &nbsp;<asp:ListBox ID="ListBox1" runat="server">
                                <asp:ListItem>1111</asp:ListItem>
                                <asp:ListItem>2222</asp:ListItem>
                                <asp:ListItem>3333</asp:ListItem>
                            </asp:ListBox>
                        </asp:WizardStep>
                        <asp:WizardStep runat="server" Title="Date">
                            <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnSelectionChanged="Calendar1_SelectionChanged" Width="350px" SelectionMode="DayWeekMonth">
                                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                                <OtherMonthDayStyle ForeColor="#999999" />
                                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                                <TodayDayStyle BackColor="#CCCCCC" />
                            </asp:Calendar>
                        </asp:WizardStep>
                        <asp:WizardStep runat="server" Title="Confirm" StepType="Finish">
                            <asp:Label ID="FinishText" runat="server"></asp:Label>
                        </asp:WizardStep>
                    </WizardSteps>
                </asp:Wizard>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <asp:TreeView ID="TreeView1" runat="server" ImageSet="Arrows" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" OnTreeNodeCheckChanged="TreeView1_TreeNodeCheckChanged">
                    <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
                    <Nodes>
                        <asp:TreeNode Text="Новый узел" Value="Новый узел">
                            <asp:TreeNode ShowCheckBox="True" Value="Ch" Text="Ch"></asp:TreeNode>
                            <asp:TreeNode Text="ToolTip" ToolTip="Test" Value="ToolTip"></asp:TreeNode>
                            <asp:TreeNode ImageUrl="~/Images/clock.jpg" Text="Icon" Value="Icon"></asp:TreeNode>
                        </asp:TreeNode>
                        <asp:TreeNode Text="Новый узел" Value="Новый узел"></asp:TreeNode>
                        <asp:TreeNode Text="Новый узел" Value="Новый узел"></asp:TreeNode>
                    </Nodes>
                    <NodeStyle Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
                    <ParentNodeStyle Font-Bold="False" />
                    <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
                </asp:TreeView>
            </asp:View>
            <asp:View ID="View3" runat="server">
                <asp:Menu ID="Menu1" runat="server" BackColor="#F7F6F3" DynamicHorizontalOffset="2" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#7C6F57" OnMenuItemClick="Menu1_MenuItemClick" StaticSubMenuIndent="10px">
                    <DynamicHoverStyle BackColor="#7C6F57" ForeColor="White" />
                    <DynamicMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <DynamicMenuStyle BackColor="#F7F6F3" />
                    <DynamicSelectedStyle BackColor="#5D7B9D" />
                    <Items>
                        <asp:MenuItem Text="Создать элемент" Value="Создать элемент">
                            <asp:MenuItem Text="Создать элемент" ToolTip="test" Value="Создать элемент"></asp:MenuItem>
                        </asp:MenuItem>
                        <asp:MenuItem Text="Создать элемент" Value="Создать элемент"></asp:MenuItem>
                        <asp:MenuItem Text="Создать элемент" Value="Создать элемент"></asp:MenuItem>
                    </Items>
                    <StaticHoverStyle BackColor="#7C6F57" ForeColor="White" />
                    <StaticMenuItemStyle HorizontalPadding="5px" VerticalPadding="2px" />
                    <StaticSelectedStyle BackColor="#5D7B9D" />
                </asp:Menu>
            </asp:View>
        </asp:MultiView>
        <asp:Button ID="Button4" runat="server" Text="Next View" OnClick="Button4_Click" />
        <p>
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/App_Data/AdRotator.xml" />
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Filter" />
        </p>
    </form>
</body>
</html>
