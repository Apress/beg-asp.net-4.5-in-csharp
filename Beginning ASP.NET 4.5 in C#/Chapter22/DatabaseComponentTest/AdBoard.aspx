<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdBoard.aspx.cs" Inherits="AdBoard" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Category:
        <asp:DropDownList ID="lstCategories" runat="server"  Width="264px" DataTextField="Name" DataValueField="ID">
        </asp:DropDownList>
        <asp:Button ID="cmdDisplay" runat="server" OnClick="cmdDisplay_Click" Text="Display" Width="88px" /><br />
        <br />

        <asp:panel id="pnlNew" runat="server" Width="448px" style="padding: 10px"  >        	
            <b>Add Item To Current Category</b>
            <br /><br />
            <table>
            <tr>
              <td>Title:</td>
			  <td><asp:TextBox id="txtTitle" runat="server" Width="264px"></asp:TextBox></td>
			</tr>
			<tr>
			  <td>Price:</td>
			  <td><asp:TextBox id="txtPrice" runat="server" Width="264px"></asp:TextBox></td>
			</tr>
			<tr>
			  <td>Description:</td>
			  <td><asp:TextBox id="txtDescription" runat="server" Height="64px" Width="264px" TextMode="MultiLine"></asp:TextBox></td>
			</tr>
			</table>
			<br />
			<asp:Button id="cmdAdd" runat="server" Width="88px" Text="Add" OnClick="cmdAdd_Click"></asp:Button>
			<br />
		</asp:panel>
		<br />
		<asp:datagrid id="gridItems" runat="server" Width="418px" Font-Size="X-Small" BorderStyle="Outset" CellPadding="5"></asp:datagrid>
				
    </div>
    </form>
</body>
</html>
