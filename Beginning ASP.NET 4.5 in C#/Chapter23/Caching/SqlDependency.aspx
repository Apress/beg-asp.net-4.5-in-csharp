<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SqlDependency.aspx.cs" Inherits="Sql2005Dependency" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdModify" runat="server" OnClick="cmdModify_Click"
            Text="Modify Table"
            Width="103px" />
        <asp:Button ID="cmdGetItem" runat="server" OnClick="cmdGetItem_Click"
            Text="Check for Item"
            Width="103px" />
        <br />
        <br />
        <asp:Label ID="lblInfo" runat="server" BackColor="LightYellow" BorderStyle="Groove"
            BorderWidth="2px" Font-Names="Verdana" Font-Size="X-Small" Width="480px"></asp:Label>
    
    </div>
    </form>
</body>
</html>
