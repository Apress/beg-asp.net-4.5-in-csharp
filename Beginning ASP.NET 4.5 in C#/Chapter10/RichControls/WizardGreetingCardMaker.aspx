<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WizardGreetingCardMaker.aspx.cs" Inherits="WizardGreetingCardMaker" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Greeting Card Wizard</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Wizard ID="Wizard1" runat="server" ActiveStepIndex="0" BackColor="LemonChiffon" BorderStyle="Groove" BorderWidth="2px" CellPadding="10" OnFinishButtonClick="Wizard1_FinishButtonClick" Width="456px">
            <WizardSteps>
                <asp:WizardStep runat="server" Title="Step 1 - Colors">
                
                Choose a foreground (text) color:<br  />
                <asp:DropDownList ID="lstForeColor" runat="server" Width="194px">
                </asp:DropDownList><br  />
                <br  />
                Choose a background color:<br  />
                <asp:DropDownList ID="lstBackColor" runat="server" Width="194px">
                </asp:DropDownList>                          
                
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Step 2 - Background">
                
                    Choose a border style:<br  />
                <asp:RadioButtonList ID="lstBorder" runat="server" 
                    Height="59px" RepeatColumns="2" Width="177px">
                </asp:RadioButtonList><br  />
                <br  />
                <asp:CheckBox ID="chkPicture" runat="server" 
                    Text="Add the Default Picture"  />                
                
                </asp:WizardStep>
                <asp:WizardStep runat="server" Title="Step 3 - Text">
                
                
                Choose a font name:<br  />
                <asp:DropDownList ID="lstFontName" runat="server"  Width="194px">
                </asp:DropDownList><br  />
                <br  />
                Specify a font size:<br  />
                <asp:TextBox ID="txtFontSize" runat="server" ></asp:TextBox><br  />
                <br  />
                Enter the greeting text below:<br  />
                <asp:TextBox ID="txtGreeting" runat="server" 
                    TextMode="MultiLine" Width="240px" ></asp:TextBox>
                
                </asp:WizardStep>
                <asp:WizardStep runat="server" StepType="Complete" Title="Greeting Card">
                <asp:Panel ID="pnlCard" runat="server" Height="445px" HorizontalAlign="Center" Style="z-index: 101;
            " Width="339px">
            <br />
            &nbsp;
            <asp:Label ID="lblGreeting" runat="server" Height="150px" Width="272px"></asp:Label>
            <asp:Image ID="imgDefault" runat="server" Height="160px" Visible="False" Width="212px" /></asp:Panel>
                </asp:WizardStep>
            </WizardSteps>
        </asp:Wizard>
    
    </div>
    </form>
</body>
</html>
