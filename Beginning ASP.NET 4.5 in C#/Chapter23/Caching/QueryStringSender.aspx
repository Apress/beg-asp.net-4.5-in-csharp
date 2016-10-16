<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QueryStringSender.aspx.cs" Inherits="QueryStringSender" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdNormal" runat="server" Text="Normal Version" OnClick="cmdVersion_Click" /><br />
        <asp:Button ID="cmdLarge" runat="server" Text="Large Version" OnClick="cmdVersion_Click" Width="133px" /><br />
        <asp:Button ID="cmdSmall" runat="server" Text="Small Version" OnClick="cmdVersion_Click" Width="133px" />
    </div>
    </form>
</body>
</html>
