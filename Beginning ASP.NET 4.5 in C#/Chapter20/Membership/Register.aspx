<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE"
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" Height="304px" Width="472px" DisplaySideBar="True" OnFinishButtonClick="CreateUserWizard1_FinishButtonClick" OnCreatedUser="CreateUserWizard1_CreatedUser">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" Title="Create User">
                </asp:CreateUserWizardStep>
                
                <asp:WizardStep runat="server" Title="Subscribe">
                    <table style="padding-right: 15px; padding-left: 15px; padding-bottom: 15px; width: 232px;
                        padding-top: 15px">
                        <tr>
                            <td style="padding-right: 15px; padding-left: 15px; padding-bottom: 5px; padding-top: 15px">
                                Would you like to sign up for the following newsletters?<br />
                                <br />
                                <asp:CheckBoxList ID="chkSubscription" runat="server">
                                    <asp:ListItem>MSN Today</asp:ListItem>
                                    <asp:ListItem>.NET Planet</asp:ListItem>
                                    <asp:ListItem Value="High-Tech Herald">High-Tech Herald</asp:ListItem>
                                </asp:CheckBoxList>
                            </td>
                        </tr>
                    </table>
                
                </asp:WizardStep>
                
                <asp:CompleteWizardStep runat="server">
                    <ContentTemplate>
                        <table border="0" style="font-size: 100%; width: 472px; font-family: Verdana; height: 304px;
                            background-color: #eff3fb">
                            <tr>
                                <td align="center" colspan="2" style="font-weight: bold; font-size: large; color: white;
                                    height: 35px; background-color: #507cd1">
                                    Complete</td>
                            </tr>
                            <tr>
                                <td>
                                    Your account has been successfully created.<br />
                                    <br />
                                    You subscibed to:
                                    <asp:Label ID="lblSubscriptionList" runat="server"></asp:Label></td>                                    
                            </tr>
                            <tr>
                                <td align="right" colspan="2">
                                    <asp:Button ID="ContinueButton" runat="server" BackColor="White" BorderColor="#507CD1"
                                        BorderStyle="Solid" BorderWidth="1px" CausesValidation="False" CommandName="Continue"
                                        Font-Names="Verdana" ForeColor="#284E98" Text="Continue" ValidationGroup="CreateUserWizard1" />
                                        
                                </td>
                            </tr>
                        </table>
                    </ContentTemplate>
                </asp:CompleteWizardStep>
            </WizardSteps>
            <SideBarStyle BackColor="#507CD1" VerticalAlign="Top" />
              <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="35px" />
            <SideBarButtonStyle BackColor="#507CD1" Font-Names="Verdana" ForeColor="White" Width="100px" />
            <NavigationButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Verdana" ForeColor="#284E98" />
            <HeaderStyle BackColor="#284E98" BorderColor="#EFF3FB" BorderStyle="Solid" BorderWidth="2px"
                Font-Bold="True"  ForeColor="White" HorizontalAlign="Center" />
            <CreateUserButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Verdana" ForeColor="#284E98" />
            <ContinueButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid"
                BorderWidth="1px" Font-Names="Verdana" ForeColor="#284E98" />
        </asp:CreateUserWizard>
    
    </div>
    </form>
</body>
</html>
