<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewTemplates.aspx.cs" Inherits="GridViewTemplates" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="ProductID"
            DataSourceID="sourceProducts" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="8">
            <Columns>
                
                <asp:BoundField DataField="ProductID" HeaderText="ID" ReadOnly="True" />
                <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Price" />
                <asp:TemplateField HeaderText="Status">
                <ItemStyle Width="100px" />
                  <ItemTemplate>
                      <small>
                      <b>In Stock:</b> <%# Eval("UnitsInStock") %><br />
                      <b>On Order:</b> <%# Eval("UnitsOnOrder") %><br />
                      <b>Reorder:</b> <%# Eval("ReorderLevel") %>
                      
                      <br /><br />
  <asp:LinkButton runat="server" Text="Edit" 
   CommandName="Edit" ID="Linkbutton1" />

                      </small>
                   </ItemTemplate>
                   <EditItemTemplate>
                        <small>
                      
                      <b>In Stock:</b> <%# Eval("UnitsInStock") %><br />
                      <b>On Order:</b> <%# Eval("UnitsOnOrder") %><br /><br />
                      <b>Reorder:</b> <asp:TextBox Font-Size="X-Small" Text='<%# Bind("ReorderLevel") %>' Width="25px" runat="server" id="txtReorder" />
                      <asp:RangeValidator id="rngValidator" MinimumValue="0" MaximumValue="100" ControlToValidate="txtReorder" runat="server" ErrorMessage="Value out of range." Type="Integer"></asp:RangeValidator>
                     
                       <br /><br />
  <asp:LinkButton runat="server" Text="Update" 
   CommandName="Update" ID="Linkbutton1" />
  <asp:LinkButton runat="server" Text="Cancel" 
   CommandName="Cancel" ID="Linkbutton2" CausesValidation="False" />

                      </small>
                   </EditItemTemplate>
               </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
            <RowStyle BackColor="White" ForeColor="#330099" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
            <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        </asp:GridView>
        <asp:SqlDataSource ID="sourceProducts" runat="server" ConnectionString="<%$ ConnectionStrings:Northwind %>"
            SelectCommand="SELECT ProductID, ProductName, UnitPrice, UnitsInStock, UnitsOnOrder,ReorderLevel FROM Products" UpdateCommand="UPDATE Products SET ProductName=@ProductName, UnitPrice=CONVERT(money,@UnitPrice), ReorderLevel=@ReorderLevel WHERE ProductID=@ProductID">
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
