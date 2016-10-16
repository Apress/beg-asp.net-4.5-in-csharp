<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SessionStateExample.aspx.cs" Inherits="SessionStateExample" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
      <div>
   
   <asp:Label id="lblSession" runat="server" Width="472px" Font-Size="Medium" Font-Names="Verdana" Font-Bold="True"></asp:Label>
   <br /><br />
	<div style="border-right: 2px groove; border-top: 2px groove; border-left: 2px groove; width: 576px; border-bottom: 2px groove; HEIGHT: 160px; background-color: #FFFFD9">
	<table>
	  <tr>
	  <td style="padding: 10px">
	  <asp:ListBox id="lstItems" Width="208px" Height="128px" runat="server"></asp:ListBox>
	  </td>
	  <td style="padding: 10px">
	  <asp:Button id="cmdMoreInfo" Width="120px" Text="More Information" runat="server" 
			OnClick="cmdMoreInfo_Click"></asp:Button>
	  <br />
	  <br />
	  <asp:Label id="lblRecord" runat="server" Width="272px" Font-Size="Small" Font-Names="Verdana" Font-Bold="True"></asp:Label>
	  </td>	  
	  </tr>
	</table>
	</div>
	
	</div>
    </form>
</body>
</html>
