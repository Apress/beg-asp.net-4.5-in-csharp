<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PreserveMembers.aspx.cs" Inherits="PreserveMembers" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txtValue" runat="server" Height="153px" TextMode="MultiLine" Width="460px">This is a test of the PreserveMembers.aspx page</asp:TextBox><br />
        <br />
        <asp:Button ID="cmdSave" runat="server" OnClick="cmdSave_Click" Text="Save Contents" />
        &nbsp;<asp:Button ID="cmdLoad" runat="server" OnClick="cmdLoad_Click" Text="Load Contents" /></div>
    </form>
</body>
</html>
