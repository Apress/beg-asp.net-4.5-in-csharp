<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CSSStyles.aspx.cs" Inherits="CSSStyles" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label CssClass="heading1" ID="Label1" runat="server" Text="This Label Uses heading1"></asp:Label>
        <br />
        This is sample unformatted text.<br />
        &nbsp;<br />
        <asp:Label CssClass="heading2" ID="Label2" runat="server" Text="This Label Uses heading2"></asp:Label>
        <br />
        Here's more unformatted text.<br />
        <br />
        &nbsp;<div class="blockText" id="DIV1" runat="server" >
            This control uses the blockText style. This control uses the blockText style. This
            control uses the blockText style. This control uses the blockText style.
        </div>
    </div>   
    </form>
</body>
</html>
