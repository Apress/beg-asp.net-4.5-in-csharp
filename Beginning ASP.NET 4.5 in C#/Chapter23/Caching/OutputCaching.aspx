<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OutputCaching.aspx.cs" Inherits="OutputCaching" %>
<%@ OutputCache Duration="20" VaryByParam="ProductID;CurrencyType" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblDate" runat="server" EnableViewState="False" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    </div>
    </form>
</body>
</html>
