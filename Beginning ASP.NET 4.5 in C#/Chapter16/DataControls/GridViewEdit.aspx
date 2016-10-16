<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewEdit.aspx.cs" Inherits="GridViewEdit" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="GridView2" runat="server" DataSourceID="sourceProducts"
  AutoGenerateColumns="False" DataKeyNames="ProductID">           
    <Columns>
      <asp:BoundField DataField="ProductID" HeaderText="ID" ReadOnly="True" />
      <asp:BoundField DataField="ProductName" HeaderText="Product Name"/>
      <asp:BoundField DataField="UnitPrice" HeaderText="Price" />
      <asp:CommandField ShowEditButton="True" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource id="sourceProducts" runat="server" 
SelectCommand="SELECT ProductID, ProductName, UnitPrice FROM Products" ConnectionString="<%$ ConnectionStrings:Northwind %>"
UpdateCommand="UPDATE Products SET ProductName=@ProductName, UnitPrice=CONVERT(money,@UnitPrice) WHERE ProductID=@ProductID"
></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
