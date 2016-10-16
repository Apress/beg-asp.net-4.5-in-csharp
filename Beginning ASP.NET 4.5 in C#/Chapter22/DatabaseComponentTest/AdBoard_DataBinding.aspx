<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdBoard_DataBinding.aspx.cs" Inherits="AdBoard_DataBinding" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ObjectDataSource ID="sourceCategories" runat="server" SelectMethod="GetCategories"
            TypeName="DatabaseComponent.DBUtil"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="sourceItems" runat="server" SelectMethod="GetItems"
            TypeName="DatabaseComponent.DBUtil" InsertMethod="AddItem" >
            <SelectParameters>
                <asp:ControlParameter ControlID="lstCategories" Name="categoryID" PropertyName="SelectedValue"
                    Type="Int32" />
            </SelectParameters>
            <InsertParameters>
                <asp:ControlParameter ControlID="lstCategories" Name="categoryID" PropertyName="SelectedValue"
                    Type="Int32" />
            </InsertParameters>
        </asp:ObjectDataSource>
        Category:
        <asp:DropDownList ID="lstCategories" runat="server"  Width="264px" DataSourceID="sourceCategories" DataTextField="Name" DataValueField="ID">
        </asp:DropDownList>
        <asp:Button ID="cmdDisplay" runat="server" Text="Display" Width="88px" /><br />
        <br />
        <asp:DetailsView ID="detailsAddItem" runat="server" AutoGenerateInsertButton="True" 
            Height="50px" Width="125px" DataSourceID="sourceItems" DefaultMode="Insert" AutoGenerateRows="False">
            <Fields>
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Price" HeaderText="Price"/>
            <asp:BoundField DataField="Description" HeaderText="Description" >
                <ControlStyle Height="75px" Width="100px" />
            </asp:BoundField>
        </Fields>
           
        </asp:DetailsView>
        <br />
        <asp:GridView ID="gridItems" runat="server" DataSourceID="sourceItems">
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
