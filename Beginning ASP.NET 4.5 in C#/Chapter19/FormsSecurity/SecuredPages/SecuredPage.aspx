<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SecuredPage.aspx.cs" Inherits="SecuredPages_SecuredPage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="../StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblMessage" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label><br />
        <br />
        <br />
        <asp:Button ID="cmdSignOut" runat="server" OnClick="cmdSignOut_Click" Text="Sign Out" />
    </div>
    </form>
</body>
</html>
