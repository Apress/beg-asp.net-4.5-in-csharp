<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MultipleViews.aspx.cs" Inherits="MultipleViews" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    	<asp:label id="Label1" runat="server">Hide Columns:</asp:label>
        <asp:checkboxlist id="chkColumns" runat="server" RepeatColumns="2"></asp:checkboxlist><br />
		<asp:button id="cmdFilter"  runat="server" Width="112px" Text="Filter and Show" OnClick="cmdFilter_Click"></asp:button><br />
        <asp:Label ID="lblCacheStatus" runat="server">Hide Columns:</asp:Label>
		<hr />
        <asp:gridview id="gridCustomers"  runat="server" Width="384px" Height="120px" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" BackColor="White" CellPadding="4" Font-Size="X-Small" Font-Names="Verdana" EnableViewState="False">
			<RowStyle ForeColor="#330099" BackColor="White"></RowStyle>
			<HeaderStyle Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
		</asp:gridview>
    </div>
    </form>
</body>
</html>
