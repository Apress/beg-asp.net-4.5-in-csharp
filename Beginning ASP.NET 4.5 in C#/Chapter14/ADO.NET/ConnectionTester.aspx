<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConnectionTester.aspx.cs" Inherits="ConnectionTester" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:RadioButton id="optSQL" runat="server" Text="Use SQL Authentication (with sa account)" GroupName="Authentication" Font-Size="Smaller" Font-Names="Verdana"></asp:RadioButton>
		<br />
		<asp:RadioButton id="optWindows" runat="server" Text="Use Windows Integrated Authentication" GroupName="Authentication" Font-Size="Smaller" Font-Names="Verdana" Checked="True"></asp:RadioButton>
        <br />
		<br />
		<asp:button id="cmdConnect" runat="server" Text="Connect" onclick="cmdConnect_Click"></asp:button>
		<br />
        <br />
		<asp:label id="lblInfo" runat="server" Height="128px" Width="464px" Font-Size="Small" Font-Names="Verdana" ForeColor="Maroon"></asp:label>
    </div>
    </form>
</body>
</html>
