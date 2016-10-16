<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegularExpressionTest.aspx.cs" Inherits="RegularExpressionTest" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Regular Expression Test</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:textbox id="txtExpression" style="LEFT: 224px; POSITION: absolute; TOP: 49px" runat="server" Width="192px"></asp:textbox>
        <asp:button id="cmdSetExpression" style="LEFT: 424px; POSITION: absolute; TOP: 48px" runat="server"  Width="138px" Text="Set This Expression" CausesValidation="False" OnClick="cmdSetExpression_Click">
        </asp:button>
        <asp:label id="lblExpression" style="LEFT: 24px; POSITION: absolute; TOP: 16px" runat="server" Height="21px" Width="512px" >Current Expression: (none)</asp:label>
        <asp:label id="Label1" style="LEFT: 88px; POSITION: absolute; TOP: 51px" runat="server" >New Expression:</asp:label>
		
		<div style="BORDER-RIGHT: 2px groove; BORDER-TOP: 2px groove; Z-INDEX: 110; LEFT: 16px; BORDER-LEFT: 2px groove; WIDTH: 584px; BORDER-BOTTOM: 2px groove; POSITION: absolute; TOP: 120px; HEIGHT: 160px; BACKGROUND-COLOR: #FFFFC0" >
			<asp:validationsummary id="ValidationSummary1" style="LEFT: 192px; POSITION: absolute; TOP: 88px" runat="server" ></asp:validationsummary>
			<asp:regularexpressionvalidator id="TestValidator" style="LEFT: 208px; POSITION: absolute; TOP: 64px" runat="server" EnableClientScript="False" ErrorMessage="Failed Validation" ControlToValidate="txtValidate"></asp:regularexpressionvalidator>
			<asp:textbox id="txtValidate" style="LEFT: 208px; POSITION: absolute; TOP: 25px" runat="server" Width="192px"></asp:textbox>
			<asp:button id="cmdValidate" style="LEFT: 408px; POSITION: absolute; TOP: 24px" runat="server"  Width="139px" Text="Validate"></asp:button>
			<asp:label id="Label2" style="LEFT: 16px; POSITION: absolute; TOP: 27px" runat="server" Height="16px" Width="184px" >Test Current Expression:</asp:label>
		</div>
    </div>
    </form>
</body>
</html>
