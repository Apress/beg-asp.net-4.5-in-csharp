<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SimpleDataBinding.aspx.cs" Inherits="SimpleDataBinding" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Simple Data Binding</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:Label id="lblDynamic" runat="server" Font-Size="X-Large" >
      There were <%# TransactionCount %> transactions today.
      I see that you are using <%# Request.Browser.Browser %>.
      </asp:Label>

    </div>
    </form>
</body>
</html>
