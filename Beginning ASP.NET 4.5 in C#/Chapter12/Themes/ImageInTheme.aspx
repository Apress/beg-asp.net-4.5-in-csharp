<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageInTheme.aspx.cs" Inherits="ImageInTheme" Theme="FunkyTheme" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ImageButton ID="ImageButton1" runat="server" SkinID="OKButton" />
        <asp:ImageButton ID="ImageButton2" runat="server" SkinID="CancelButton" />
     </div>
    </form>
</body>
</html>
