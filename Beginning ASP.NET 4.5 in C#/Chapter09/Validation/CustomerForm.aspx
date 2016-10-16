<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerForm.aspx.cs" Inherits="CustomerForm" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Customer Form</title>
    		<script type="text/javascript">
<!--
function MyCustomValidation(objSource, objArgs)
{
    // Get value.
    var number = objArgs.Value;//.substr(0, 3);
     objArgs.IsValid = true;

    // Check value and return result.
    number = number.substr(0, 3);
    if (number % 7 == 0)
    {
        objArgs.IsValid = true;
        return;
    }
    else
    {
        objArgs.IsValid = false;
        return;
    }
}
// -->
		</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <div style="border: thin groove; font-size: 80%; width: 613px; font-family: Verdana; height: 272px; background-color: #FFFFC0; padding-right: 10px; padding-left: 10px; padding-bottom: 10px; padding-top: 10px;"
				>
        <table style="width: 584px" >
            <tr>
                <td style="width: 112px">
				<asp:Label id="Label1" runat="server"
					Font-Bold="True">User Name:</asp:Label>
                </td>
                <td style="width: 166px" >
					<asp:TextBox id="txtUserName" 
					runat="server" Width="152px"></asp:TextBox></td>
                <td style="width: 199px">
				<asp:RequiredFieldValidator id="vldUserName" 
					runat="server" ErrorMessage="You must enter a user name." ControlToValidate="txtUserName"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 112px">
					
				<asp:Label id="Label2" runat="server"
					Font-Bold="True">Password:</asp:Label></td>
                <td style="width: 166px">
				<asp:TextBox id="txtPassword" 
					runat="server" TextMode="Password" Width="152px"></asp:TextBox></td>
                <td style="width: 4px">
				<asp:RequiredFieldValidator id="vldPassword" 
					runat="server" ErrorMessage="You must enter a password." ControlToValidate="txtPassword" Width="224px"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td style="width: 112px">
					
				<asp:Label id="Label3" runat="server" 
					Font-Bold="True">Password (retype):</asp:Label></td>
                <td style="width: 166px">
				<asp:TextBox id="txtRetype" 
					runat="server" TextMode="Password" Width="152px"></asp:TextBox></td>
                <td style="width: 4px">
				<asp:CompareValidator id="vldRetype" 
					runat="server" ErrorMessage="Your password does not match."
					ControlToCompare="txtPassword" ControlToValidate="txtRetype" Width="224px"></asp:CompareValidator></td>
		        <asp:RequiredFieldValidator id="vldRetypeRequired"
		            runat="server" ErrorMessage="You must confirm your password."
		            ControlToValidate="txtRetype" />

            </tr>
            <tr>
                <td style="width: 112px">
					
				<asp:Label id="Label4" runat="server" 
					Font-Bold="True">E-mail:</asp:Label></td>
                <td style="width: 166px">
				<asp:TextBox id="txtEmail" 
					runat="server" Width="152px"></asp:TextBox></td>
                <td style="width: 4px">
				<asp:RegularExpressionValidator id="vldEmail" 
					runat="server" ErrorMessage="This email is missing the @ symbol." 
					ValidationExpression=".+@.+" ControlToValidate="txtEmail" Width="232px"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td style="width: 112px">
					
				<asp:Label id="Label5"  runat="server"
					Width="32px" Height="16px" Font-Bold="True">Age:</asp:Label></td>
                <td style="width: 166px">
				<asp:TextBox id="txtAge"  runat="server"
					Width="152px"></asp:TextBox></td>
                <td style="width: 4px">
				<asp:RangeValidator id="vldAge"  runat="server"
					ErrorMessage="This age is not between 0 and 120." Type="Integer" 
					MaximumValue="120" MinimumValue="0"
					ControlToValidate="txtAge" Width="240px"></asp:RangeValidator></td>
            </tr>
            <tr>
                <td style="width: 112px">
				
				<asp:Label id="Label6"  runat="server"
					Width="106px" Height="24px" Font-Bold="True">Referrer Code:</asp:Label></td>
                <td style="width: 166px">
				<asp:TextBox id="txtCode"  runat="server"
					Width="152px"></asp:TextBox></td>
                <td style="width: 4px">
				<asp:CustomValidator id="vldCode" runat="server"
					ErrorMessage="Try a string that starts with 014." ValidateEmptyText="False"
					ControlToValidate="txtCode" ClientValidationFunction="MyCustomValidation" OnServerValidate="vldCode_ServerValidate" Width="232px"></asp:CustomValidator></td>
            </tr>
        </table>
        <br />
				
				<asp:Button id="cmdSubmit" 
					runat="server" Width="120px" Text="Submit" OnClick="cmdSubmit_Click"></asp:Button>&nbsp;
				<asp:Button id="cmdCancel" 
					runat="server" Width="120px" Text="Cancel" 
					CausesValidation="False" OnClick="cmdCancel_Click"></asp:Button>
		</div>
        <br />
			<asp:Label id="lblMessage" 
				runat="server" Width="616px" Height="72px"></asp:Label>
    </div>
    </form>
</body>
</html>
