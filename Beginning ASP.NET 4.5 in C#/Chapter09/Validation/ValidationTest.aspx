<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ValidationTest.aspx.cs" Inherits="ValidationTest" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Validation Test</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>
		A number (1 to 10):
		<asp:TextBox id="txtValidated" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:RangeValidator id="RangeValidator" runat="server" ErrorMessage="This Number Is Not In The Range" ControlToValidate="txtValidated" MaximumValue="10" MinimumValue="1" Type="Integer" EnableClientScript="False"></asp:RangeValidator>&nbsp;
        &nbsp;<br />
		<br />
		&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Not validated:&nbsp;
		<asp:TextBox id="txtNotValidated" runat="server"></asp:TextBox><br />
	</p>
	<p><br />
		<asp:Button id="cmdOK" runat="server" Text="OK" OnClick="cmdOK_Click" Width="46px"></asp:Button><br />
		<br />
		<asp:Label id="lblMessage" runat="server" EnableViewState="False" Font-Bold="True" ForeColor="Red"></asp:Label>&nbsp;
	</p>
    <p>
        Client script is disabled on this page so you can see how validation performs on
        down-level browsers. Even though they trigger a postback, your code should detect
        that the page is invalid. To switch back to the default behavior, set RangeValidation.EnableClientScript
        to true.</p>
    </div>
    </form>
</body>
</html>
