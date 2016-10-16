<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomParameters.aspx.cs" Inherits="CustomParameters" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Custom Parameters</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <asp:SqlDataSource ID="sourceCustomers" runat="server"
  ProviderName="System.Data.SqlClient"
  ConnectionString="<%$ ConnectionStrings:Northwind %>"
  SelectCommand="SELECT CustomerID, ContactName FROM Customers ORDER BY ContactName"
/>
        <asp:DropDownList ID="lstCustomers" runat="server" DataSourceID="sourceCustomers" DataTextField="ContactName" DataValueField="CustomerID" AutoPostBack="True">
        </asp:DropDownList>
          <br />
          <br />
          <asp:SqlDataSource ID="sourceOrders" runat="server"
  ProviderName="System.Data.SqlClient"
  ConnectionString="<%$ ConnectionStrings:Northwind %>"
  SelectCommand="SELECT OrderID,OrderDate,ShippedDate FROM Orders WHERE CustomerID=@CustomerID AND OrderDate<=@EarliestOrderDate"
 OnSelecting="sourceOrders_Selecting">
<SelectParameters>
    <asp:ControlParameter Name="CustomerID" ControlID="lstCustomers" PropertyName="SelectedValue" />
    <asp:Parameter Name="EarliestOrderDate" DefaultValue="1900/01/01" Type="DateTime" />
  </SelectParameters>

      </asp:SqlDataSource>
  
        <asp:GridView ID="gridOrders" runat="server" DataSourceID="sourceOrders" 
                AutoGenerateColumns="False" DataKeyNames="OrderID" >
            <Columns>
                <asp:boundfield DataField="OrderID" HeaderText="OrderID" InsertVisible="False" 
                    ReadOnly="True" SortExpression="OrderID"></asp:boundfield>
                <asp:boundfield DataField="OrderDate" HeaderText="OrderDate" DataFormatString="{0:d}"
                    SortExpression="OrderDate"></asp:boundfield>
                <asp:boundfield DataField="ShippedDate" DataFormatString="{0:d}"  
                    HeaderText="ShippedDate" 
                    SortExpression="ShippedDate"></asp:boundfield>
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
