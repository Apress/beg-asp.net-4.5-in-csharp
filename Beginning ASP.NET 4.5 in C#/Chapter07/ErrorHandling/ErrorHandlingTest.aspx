<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErrorHandlingTest.aspx.cs" Inherits="ErrorHandlingTest" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="A:"></asp:Label>
        <asp:TextBox ID="txtA" runat="server">5</asp:TextBox><br />
        <asp:Label ID="Label2" runat="server" Text="B:"></asp:Label>
        <asp:TextBox ID="txtB" runat="server">0</asp:TextBox><br />
        <br />
        <asp:Button ID="cmdCompute" runat="server" OnClick="cmdCompute_Click" Text="Divide A / B" /><br />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label></div>
    </form>
</body>
</html>
