<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GreetingCardMakerRevisited.aspx.cs" Inherits="GreetingCardMakerRevisited" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        
        <div style="BORDER-RIGHT: thin ridge; PADDING-RIGHT: 20px; BORDER-TOP: thin ridge; PADDING-LEFT: 20px; FONT-SIZE: x-small; PADDING-BOTTOM: 20px; BORDER-LEFT: thin ridge; WIDTH: 293px; PADDING-TOP: 20px; BORDER-BOTTOM: thin ridge; FONT-FAMILY: Verdana; HEIGHT: 508px; BACKGROUND-COLOR: lightyellow">Choose 
		 a background color:<br />
		<asp:dropdownlist id="lstBackColor" runat="server" Height="22px" Width="194px" AutoPostBack="True"></asp:dropdownlist><br />
		<br />
		Choose a foreground (text) color:<br />
		<asp:dropdownlist id="lstForeColor" runat="server" Height="22px" Width="194px" AutoPostBack="True"></asp:dropdownlist><br />
		<br />
		Choose a font name:<br />
		<asp:dropdownlist id="lstFontName" runat="server" Height="22px" Width="194px" AutoPostBack="True"></asp:dropdownlist><br />
		<br />
		Specify a font size:<br />
		<asp:textbox id="txtFontSize" runat="server" AutoPostBack="True"></asp:textbox><br />
		<br />
		Choose a border style:<br />
		<asp:radiobuttonlist id="lstBorder" runat="server" Height="59px" Width="177px" Font-Size="X-Small" AutoPostBack="True" RepeatColumns="2"></asp:radiobuttonlist><br />
		<br />
		<asp:checkbox id="chkPicture" runat="server" Text="Add the Default Picture" AutoPostBack="True"></asp:checkbox><br />
		<br />
		Enter the greeting text below:<br />
		<asp:textbox id="txtGreeting" runat="server" Height="85px" Width="240px" TextMode="MultiLine" AutoPostBack="True"></asp:textbox><br />
		<br />
	</div>
			
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
			<asp:panel id="pnlCard" 
				style="Z-INDEX: 101; LEFT: 367px; POSITION: absolute; TOP: 15px; height: 546px; width: 368px;" 
				runat="server" HorizontalAlign="Center"><br />&nbsp; 
                <asp:Label id="lblGreeting" runat="server" Width="272px" Height="150px"></asp:Label>
                <br />
                <asp:Image id="imgDefault" ImageUrl="~/ajax.jpg" runat="server" Width="212px" Height="160px" Visible="False"></asp:Image>
           </asp:panel>            
        </ContentTemplate>
        
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="lstBackColor" />
            <asp:AsyncPostBackTrigger ControlID="lstForeColor" />
            <asp:AsyncPostBackTrigger ControlID="lstFontName" />
            <asp:AsyncPostBackTrigger ControlID="txtFontSize" />
            <asp:AsyncPostBackTrigger ControlID="lstBorder" />
            <asp:AsyncPostBackTrigger ControlID="chkPicture" />
            <asp:AsyncPostBackTrigger ControlID="txtGreeting" />
        </Triggers>
    </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
