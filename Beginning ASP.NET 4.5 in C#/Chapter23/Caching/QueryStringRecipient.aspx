<%@ Page Language="C#" AutoEventWireup="true" CodeFile="QueryStringRecipient.aspx.cs" Inherits="QueryStringRecipient" %>
<%@ OutputCache Duration="30" VaryByParam="Version" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label id="lblDate" runat="server" Font-Size="X-Large" Font-Bold="True" EnableViewState="False"></asp:Label>
    </div>
    </form>
</body>
</html>
