<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IterativeVsDeclarative.aspx.cs" Inherits="IterativeVsDeclarative" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Iterative Vs. Decalarative</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdForeach" runat="server" OnClick="cmdForeach_Click" Text="Get Matches with foreach" />
        <asp:Button ID="cmdLinq" runat="server" OnClick="cmdLinq_Click" Text="Get Matches with LINQ" /><br />
        <br />
        <asp:GridView ID="gridEmployees" runat="server">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
