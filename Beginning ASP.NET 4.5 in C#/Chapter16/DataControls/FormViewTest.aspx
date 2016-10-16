<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormViewTest.aspx.cs" Inherits="FormView" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:SqlDataSource ID="sourceProducts" runat="server" ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="SELECT * FROM Products"></asp:SqlDataSource>
            
        <asp:DropDownList ID="lstProducts" runat="server" AutoPostBack="True" DataSourceID="sourceProducts"
            DataTextField="ProductName" DataValueField="ProductID" Width="184px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:SqlDataSource ID="sourceProductFull" runat="server" ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="SELECT * FROM Products WHERE ProductID=@ProductID">
            <SelectParameters>
            <asp:ControlParameter Name="ProductID" ControlID="lstProducts" PropertyName="SelectedValue" />
            </SelectParameters>
            </asp:SqlDataSource>
        <asp:FormView ID="FormView1" runat="server" DataSourceID="sourceProductFull"
            Width="184px" BackColor="#FFE0C0" BorderStyle="Solid" BorderWidth="2px" CellPadding="5">
            <ItemTemplate>
               
                <b>In Stock:</b>
                    <%# Eval("UnitsInStock") %>
                    <br />
                    <b>On Order:</b>
                    <%# Eval("UnitsOnOrder") %>
                    <br />
                    <b>Reorder:</b>
                    <%# Eval("ReorderLevel") %>
                    <br />
                    <br />
                
            </ItemTemplate>
        </asp:FormView>
        
    
    </div>
    </form>
</body>
</html>
