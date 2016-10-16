<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateInsertDelete.aspx.cs" Inherits="UpdateInsertDelete" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdUpdate" runat="server" Text="Update Product" 
            onclick="cmdUpdate_Click" />
        &nbsp;<asp:Button ID="cmdInsert" runat="server" Text="Insert Product" 
            onclick="cmdInsert_Click" />
        &nbsp;<asp:Button ID="cmdDelete" runat="server" Text="Delete Product" 
            onclick="cmdDelete_Click" />
        <br />
        <br />
        <asp:GridView ID="gridProducts" runat="server" DataKeyNames="ProductID"  AutoGenerateColumns="false"
            BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px"
            CellPadding="4" Font-Size="X-Small" ForeColor="Black" GridLines="Horizontal">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />

            <Columns>
            <asp:BoundField DataField="ProductID" />
            <asp:BoundField DataField="ProductName" />
            <asp:BoundField DataField="UnitsInStock" />            
            <asp:BoundField DataField="UnitPrice" DataFormatString="{0:C}" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
