<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TimedRefresh.aspx.cs" Inherits="TimedRefresh" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <img src="lava_lamp.gif" alt="Lava Lamp" /><br />
        <br />
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="True">
        </asp:ScriptManager>
        <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div style="padding-right: 20px; padding-left: 20px; padding-bottom: 20px; padding-top: 20px;
                    background-color: lightyellow">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
                    <br />
                    This time refreshes automatically every 1 second (for about 10 seconds).<br />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Refresh Time" />
                </div>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="TimerControl1" EventName="Tick" />
            </Triggers>
            
        </asp:UpdatePanel>
        <asp:Timer ID="TimerControl1" runat="server" Interval="1000" OnTick="TimerControl1_Tick">
        </asp:Timer>
        
    </form>
</body>
</html>
