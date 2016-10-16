<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewStyles.aspx.cs" Inherits="GridViewStyles" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td valign="top" style="width: 328px">
                    Global style settings:<br />
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1"
         AutoGenerateColumns="false"
            >
            
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />                    
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
              <Columns>
    <asp:BoundField DataField="ProductID" HeaderText="ID" />
    <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
    <asp:BoundField DataField="UnitPrice" HeaderText="Price" />
  </Columns>
  </asp:GridView>
                </td>
                <td valign="top" style="width: 358px">
                    Column-specific styles:<br />
        <asp:GridView ID="GridView2" runat="server" DataSourceID="SqlDataSource1"
         AutoGenerateColumns="false" >
            
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="ID" />
                <asp:BoundField DataField="ProductName" HeaderText="Product Name">
                
                 <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />                    
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                </asp:BoundField>
                <asp:BoundField DataField="UnitPrice" HeaderText="Price" />
             </Columns>
        </asp:GridView>
                </td>
            </tr>
        </table>
        &nbsp;<br />
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="SELECT ProductID, ProductName, UnitPrice FROM Products"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
