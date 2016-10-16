<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErrorPage.aspx.cs" Inherits="ErrorPage" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    An error occured. Click to go back and try again.<br />
        <br />
        <asp:Button ID="cmdOK" runat="server" Text="OK" onclick="cmdOK_Click" />
    </div>
    </form>
</body>
</html>
