<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SimpleTypes.aspx.cs" Inherits="SimpleTypes" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table >
            <tr>
                <td style="width: 99px" >
                    First Name:
                </td>
                <td >
                    <asp:TextBox ID="txtFirst" runat="server">Harriet</asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 99px" >
                    Last Name:</td>
                <td >
                    <asp:TextBox ID="txtLast" runat="server">Smythe</asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 99px; height: 182px" >
                    Date of Birth:&nbsp;
                </td>
                <td style="height: 182px"  >
                    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                </td>
            </tr>
        </table>
        <br />
        <br />
        <asp:Button ID="cmdShow" runat="server" OnClick="cmdShow_Click" Text="Show Profile Data" />&nbsp;
        <asp:Button ID="cmdSet" runat="server" OnClick="cmdSet_Click" Text="Set Profile Data" /><br />
        <br />
        <br />
        &nbsp;<div style="background-color: lightyellow; border-right: 2px solid; border-top: 2px solid; border-left: 2px solid; border-bottom: 2px solid;">
        <asp:Label ID="lbl" runat="server" EnableViewState="False" Font-Bold="True"></asp:Label></div>
    
    </div>
    </form>
</body>
</html>
