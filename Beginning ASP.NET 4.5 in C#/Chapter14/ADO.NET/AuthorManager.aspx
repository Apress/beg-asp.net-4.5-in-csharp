<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AuthorManager.aspx.cs" Inherits="AuthorManager" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div style="background-color: #FFE0C0; height: 100px; width: 601px; padding: 10px">
			<br />
			<asp:Label id="Label1" runat="server" Width="99px" Height="19px">Select Author:</asp:Label>
			<asp:DropDownList id="lstAuthor" runat="server" Width="187px" Height="21px" AutoPostBack="True" onselectedindexchanged="lstAuthor_SelectedIndexChanged"></asp:DropDownList>&nbsp;
			<asp:Button id="cmdUpdate" runat="server" Text="Update" onclick="cmdUpdate_Click"></asp:Button>
			<asp:Button id="cmdDelete" runat="server" Text="Delete" onclick="cmdDelete_Click"></asp:Button>
			<br />
            <br />
			<asp:Label id="Label11" runat="server" Width="99px" Height="19px">Or:</asp:Label>
			<asp:Button id="cmdNew" runat="server" Width="91px" Height="24px" Text="Create New" onclick="cmdNew_Click"></asp:Button>&nbsp;
			<asp:Button id="cmdInsert" runat="server" Width="85px" Height="24px" Text="Insert New" onclick="cmdInsert_Click"></asp:Button>
		</div>
		<br />
		<div style="background-color: #E0E0E0; height: 392px; width: 601px; padding: 10px">		
				
			<asp:Label id="Label10" runat="server" Width="100px">Unique ID:</asp:Label>
			<asp:TextBox id="txtID" runat="server" Width="184px"></asp:TextBox>&nbsp; 
			(required:&nbsp;###-##-#### form)<br />
			
			<asp:Label id="Label2" runat="server" Width="100px">First Name:</asp:Label>
			<asp:TextBox id="txtFirstName" runat="server" Width="184px"></asp:TextBox><br />
			
			<asp:Label id="Label3" runat="server" Width="100px">Last Name:</asp:Label>
			<asp:TextBox id="txtLastName" runat="server" Width="183px"></asp:TextBox><br />
			
			<asp:Label id="Label4" runat="server" Width="100px">Phone:</asp:Label>
			<asp:TextBox id="txtPhone" runat="server" Width="183px"></asp:TextBox><br />
			
			<asp:Label id="Label5" runat="server" Width="100px">Address:</asp:Label>
			<asp:TextBox id="txtAddress" runat="server" Width="183px"></asp:TextBox><br />
			
			<asp:Label id="Label6" runat="server" Width="100px">City:</asp:Label>
			<asp:TextBox id="txtCity" runat="server" Width="184px"></asp:TextBox><br />
			
			<asp:Label id="Label7" runat="server" Width="100px">State:</asp:Label>
			<asp:TextBox id="txtState" runat="server" Width="184px"></asp:TextBox><br />
			
			<asp:Label id="Label9" runat="server" Width="100px">Zip Code:</asp:Label>
			<asp:TextBox id="txtZip" runat="server" Width="184px"></asp:TextBox>&nbsp; 
			(required: any five&nbsp;digits)<br />
			<br />
			
			<asp:Label id="Label8" runat="server" Width="93px" Height="19px">Contract:</asp:Label>&nbsp;
			<asp:CheckBox id="chkContract" runat="server"></asp:CheckBox><br />
			<br />
			
			<asp:Label id="lblResults" runat="server" Width="575px" Height="121px" Font-Bold="True"></asp:Label>
		</div>
    </div>
    </form>
</body>
</html>
