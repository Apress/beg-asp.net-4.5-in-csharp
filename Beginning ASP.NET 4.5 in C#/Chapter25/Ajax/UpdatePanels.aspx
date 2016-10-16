<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdatePanels.aspx.cs" Inherits="UpdatePanels" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="lblError" style="color:Red; font-weight:bold"></div>
        <img src="lava_lamp.gif" alt="Lava Lamp" /><br />
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
    
    
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
             <div style="background-color:#FFFFE0;padding: 20px">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
                    <br />
                    <br />
                <asp:Button ID="Button1" runat="server" Text="Refresh Time" />
                </div>
            </ContentTemplate>            
        </asp:UpdatePanel>
        &nbsp;<asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <div style="background-color:#FFFFE0;padding: 20px">
                    <asp:Label ID="Label2" runat="server" Font-Bold="True"></asp:Label>
                    <br />
                    <br />
                <asp:Button ID="Button2" runat="server" Text="Refresh Time" />
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        &nbsp;&nbsp;
        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
            <ContentTemplate>
                <div style="background-color:#FFFFE0;padding: 20px">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Refresh Time" />
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        <br />
        
        Click here to trigger a real (full-page) postback:
        <asp:Button ID="Button4" runat="server" Text="Button" />
        
        </div>
    </form>
</body>
</html>

