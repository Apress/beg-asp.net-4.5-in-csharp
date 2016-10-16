<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CrossPage1.aspx.cs" Inherits="CrossPage1" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>CrossPage1</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" >
    <div>
        First Name:
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br />
        Last Name:
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button runat="server" ID="cmdPost" 
                PostBackUrl="CrossPage2.aspx" Text="Cross-Page Postback" /><br />
        <asp:Button runat="server" ID="cmdTransfer" Text="Manual Transfer" OnClick="cmdTransfer_Click" Visible="False" />
    </div>
    </form>
</body>
</html>
