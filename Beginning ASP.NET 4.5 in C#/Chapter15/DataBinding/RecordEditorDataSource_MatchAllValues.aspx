<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RecordEditorDataSource_MatchAllValues.aspx.cs" Inherits="RecordEditorDataSource_MatchAllValues" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Record Editor</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="lstProduct" runat="server" AutoPostBack="True" Width="280px" DataSourceID="sourceProducts" DataTextField="ProductName" DataValueField="ProductID">
        </asp:DropDownList>
        <br />
        <br />
        <hr />
        <br />
        <table>
            <tr>
                <td style="width: 234px" valign="top">
                    <asp:DetailsView ID="DetailsView1" runat="server" DataSourceID="sourceProductDetails"
                        Height="50px" Width="200px" AutoGenerateEditButton="True">
                    </asp:DetailsView>
                    &nbsp;
                </td>
                <td style="width: 190px">
                    <br />
                    <br />
                    </td>
            </tr>
        </table>
        
        <asp:SqlDataSource ID="sourceProducts" runat="server"
  ProviderName="System.Data.SqlClient"
  ConnectionString="<%$ ConnectionStrings:Northwind %>"
  SelectCommand="SELECT ProductName, ProductID FROM Products"
/>

<asp:SqlDataSource ID="sourceProductDetails" runat="server"
  ProviderName="System.Data.SqlClient"
  ConnectionString="<%$ ConnectionStrings:Northwind %>"
  SelectCommand="SELECT ProductID, ProductName, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued FROM Products WHERE ProductID=@ProductID"
UpdateCommand="UPDATE Products SET ProductName=@ProductName, UnitPrice=@UnitPrice, UnitsInStock=@UnitsInStock, UnitsOnOrder=@UnitsOnOrder, ReorderLevel=@ReorderLevel, Discontinued=@Discontinued WHERE ProductID=@ProductID AND ProductName=@original_ProductName AND UnitPrice=@original_UnitPrice AND UnitsInStock=@original_UnitsInStock AND UnitsOnOrder=@original_UnitsOnOrder AND ReorderLevel=@original_ReorderLevel AND Discontinued=@original_Discontinued"
  
  OldValuesParameterFormatString="original_{0}" ConflictDetection="CompareAllValues" OnUpdated="sourceProductDetails_Updated">
  <SelectParameters>
        <asp:ControlParameter ControlID="lstProduct" Name="ProductID"
     PropertyName="SelectedValue" />
  </SelectParameters>
</asp:SqlDataSource>
        <asp:Label ID="lblInfo" runat="server" EnableViewState="False" Font-Bold="True" ForeColor="#C00000"></asp:Label>
        <br />
        <br />
        <br />
        <hr />
        This page prevents overlapping edits. To try this out, open two copies of the page
        in two browser windows. Start editing the same record in both pages. Make changes
        in both pages to same field (for example, use two different UnitCost values). Now
        try applying the changes. The first change will be applied, but the second will
        fail due to the concurrency conflict.
    </div>
    </form>
</body>
</html>
