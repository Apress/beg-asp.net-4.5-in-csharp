<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SimpleCounter.aspx.cs" Inherits="SimpleCounter" %>

<!DOCTYPE html>>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdIncrement" runat="server" OnClick="cmdIncrement_Click" Text="Increment" /><br />
        <br />
        <asp:Label ID="lblCount" runat="server"></asp:Label>&nbsp;</div>
    </form>
</body>
</html>
