<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QueryStringSender.aspx.cs" Inherits="QueryStringSender" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="lstItems" runat="server" Height="155px" Width="165px"></asp:ListBox><br />
        <br />
        <asp:CheckBox ID="chkDetails" runat="server" Text="Show full details" /><br />
        <br />
        <asp:Button ID="cmdGo" runat="server" OnClick="cmdGo_Click" Text="View Information"
            Width="165px" /><br />
        <br />
        <asp:Label ID="lblError" runat="server" EnableViewState="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
