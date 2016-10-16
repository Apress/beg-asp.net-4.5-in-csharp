<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PasswordRecovery.aspx.cs" Inherits="PasswordRecovery" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BackColor="#EFF3FB" BorderColor="#B5C7DE"
            BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana"
            Font-Size="0.8em" Height="144px" Width="344px" OnSendingMail="PasswordRecovery1_SendingMail">
                        <InstructionTextStyle Font-Italic="True" ForeColor="Black"  />
            <SuccessTextStyle Font-Bold="True" ForeColor="#507CD1" />
            
           <TitleTextStyle BackColor="#507CD1" Font-Bold="True" Font-Size="Large" ForeColor="White" Height="35px" />
            <SubmitButtonStyle BackColor="White" BorderColor="#507CD1" BorderStyle="Solid" BorderWidth="1px"
                Font-Names="Verdana"  ForeColor="#284E98" />
        </asp:PasswordRecovery>
    
    </div>
    </form>
</body>
</html>
