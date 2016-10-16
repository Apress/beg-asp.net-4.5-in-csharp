<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetAllProfiles.aspx.cs" Inherits="GetAllProfiles" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gridProfiles" runat="server" AutoGenerateColumns="true">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
