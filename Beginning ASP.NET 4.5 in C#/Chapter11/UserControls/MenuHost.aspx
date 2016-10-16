<%@ Page Language="C#" AutoEventWireup="true"
    CodeFile="MenuHost.aspx.cs" Inherits="MenuHost"%>
<%@ Register TagPrefix="apress" TagName="LinkMenu" Src="LinkMenu.ascx" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Menu Host</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table >
            <tr>
                <td style="width: 100px">
                    <apress:LinkMenu id="Menu1" runat="server" />
                </td>
                <td>
                    &nbsp;&nbsp;<asp:Label id="lblSelection" runat="server" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
