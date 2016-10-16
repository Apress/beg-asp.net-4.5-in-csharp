<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LinqToEntities.aspx.cs" Inherits="LinqToEntities" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>        
        <asp:DropDownList ID="lstCategories" runat="server" AutoPostBack="true" onselectedindexchanged="lstCategories_SelectedIndexChanged"
          AppendDataBoundItems="true" >
          <asp:ListItem Text="(Select a Category)" Value="-1"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="gridProducts" runat="server" CellPadding="4" GridLines="None" 
            Font-Size="X-Small" ForeColor="#333333" AutoGenerateColumns="True">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
