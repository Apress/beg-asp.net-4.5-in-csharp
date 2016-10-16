<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UnSecuredPage.aspx.cs" Inherits="UnSecuredPage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Anyone can access this page.<br />
        <br />
        <asp:Label ID="lblInfo" runat="server"></asp:Label><br />
        <br />
        <asp:Button ID="cmdGo" runat="server" OnClick="cmdGo_Click" Text="Go To Secure Page" />
    </div>
    </form>
</body>
</html>
