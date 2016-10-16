<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetProfile.aspx.cs" Inherits="GetProfile" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        User Name: &nbsp;<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <asp:Button ID="cmdGet" runat="server" OnClick="cmdGet_Click" Text="Get Profile" /><br />
        <br />
        <asp:Label ID="lbl" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
