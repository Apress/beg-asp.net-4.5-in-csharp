<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DynamicThemes.aspx.cs" Inherits="DynamicThemes" Theme="ProTheme"  %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="lstThemes" runat="server"></asp:ListBox><br />
        <br />
        <asp:Button ID="cmdApply" runat="server" Text="Apply Theme" OnClick="cmdApply_Click" />
        <asp:Button ID="cmdClear" runat="server" Text="Clear Theme" OnClick="cmdClear_Click" />
    </div>
    </form>
</body>
</html>
