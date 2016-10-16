<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataBindingUrl.aspx.cs" Inherits="DataBindingUrl" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label id="lblDynamic" runat="server"><%# URL %></asp:Label>
<br /><br />
<asp:CheckBox id="chkDynamic" Text="<%# URL %>" runat="server" />
<br /><br />
<asp:Hyperlink id="lnkDynamic" Text="Click here!" NavigateUrl="<%# URL %>" 
 runat="server" />
<br /><br />
<asp:Image id="imgDynamic" ImageUrl="<%# URL %>" runat="server" />

    </div>
    </form>
</body>
</html>
