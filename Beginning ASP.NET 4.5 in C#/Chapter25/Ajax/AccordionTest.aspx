<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AccordionTest.aspx.cs" Inherits="AccordionTest" %>
<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit"%>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <asp:Accordion ID="Accordion1" runat="server"
  HeaderCssClass="accordionHeader"
  HeaderSelectedCssClass="accordionHeaderSelected"
  ContentCssClass="accordionContent">

  <Panes>
    <asp:AccordionPane runat="server" ID="paneColors">
      <Header>Colors</Header>
      <Content>
        Choose a background color:<br />
        <asp:DropDownList id="lstBackColor" runat="server"
         Width="194px" AutoPostBack="True">
        </asp:DropDownList>
        <br /><br />
        Choose a foreground (text) color:<br />
        <asp:DropDownList id="lstForeColor" runat="server"
         Height="22px" Width="194px" AutoPostBack="True" >
        </asp:DropDownList>
      </Content>
    </asp:AccordionPane>

    <asp:AccordionPane runat="server" ID="paneText">
      <Header>Text</Header>
      <Content>
        Choose a font name:<br />
        <asp:DropDownList id="lstFontName" runat="server"
         Height="22px" Width="194px" AutoPostBack="True">
        </asp:DropDownList>
        <br /><br />
        Specify a font size:<br />
        <asp:TextBox id="txtFontSize" runat="server" 
         AutoPostBack="True">
        </asp:TextBox>
        <br /><br />
        Enter the greeting text below:<br />
        <asp:TextBox id="txtGreeting" runat="server"
         Height="85px" Width="240px" TextMode="MultiLine"
         AutoPostBack="True">
        </asp:TextBox>
      </Content>
    </asp:AccordionPane>

    <asp:AccordionPane runat="server" ID="paneOther">
      <Header>Other</Header>
      <Content>
        Choose a border style:<br />
        <asp:RadioButtonList id="lstBorder" runat="server"
         Height="59px" Width="177px" Font-Size="X-Small"
         AutoPostBack="True" RepeatColumns="2">
        </asp:RadioButtonList>
        <br /><br />
        <asp:CheckBox id="chkPicture" runat="server"
         Text="Add the Default Picture" AutoPostBack="True">
        </asp:CheckBox>
        </Content>
    </asp:AccordionPane>
  </Panes>            
</asp:Accordion>

</div>
    </form>
</body>
</html>
