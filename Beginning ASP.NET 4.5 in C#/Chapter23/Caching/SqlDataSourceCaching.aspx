<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SqlDataSourceCaching.aspx.cs" Inherits="SqlDataSourceCaching" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:SqlDataSource ID="sourceEmployeeCities" runat="server" ProviderName="System.Data.SqlClient" 
        ConnectionString="<%$ ConnectionStrings:Northwind %>" SelectCommand="SELECT DISTINCT City FROM Employees"
          EnableCaching="True" CacheDuration="3600">
        </asp:SqlDataSource>
        <asp:DropDownList ID="lstCities" runat="server" DataSourceID="sourceEmployeeCities"
            DataTextField="City" Width="205px" AutoPostBack="True">
        </asp:DropDownList><br />
            
        <asp:SqlDataSource ID="sourceEmployees" runat="server" 
        ProviderName="System.Data.SqlClient" ConnectionString="<%$ ConnectionStrings:Northwind %>" 
        SelectCommand="SELECT EmployeeID, FirstName, LastName, Title, City FROM Employees WHERE City=@City"
         EnableCaching="True" CacheDuration="600">
            <SelectParameters>
             
                <asp:ControlParameter ControlID="lstCities" Name="City" PropertyName="SelectedValue" />
            </SelectParameters>
        </asp:SqlDataSource>
        
    
        <br />
        <asp:GridView ID="GridView1" runat="server" DataSourceID="sourceEmployees" CellPadding="4" Font-Names="Verdana" Font-Size="Small" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataKeyNames="EmployeeID">
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" InsertVisible="False"
                    ReadOnly="True" SortExpression="EmployeeID" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            </Columns>
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
