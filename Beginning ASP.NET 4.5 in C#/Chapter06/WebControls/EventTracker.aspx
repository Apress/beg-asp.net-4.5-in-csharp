<%@ Page language="c#" Inherits="WebControls.EventTracker" CodeFile="EventTracker.aspx.cs" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
  <title>Event Tracker</title>
  <style type="text/css">
      h1 
      {
          font-size: large;       
      }
  </style>
</head>
<body>
  <form id="Form1" runat="server">
    <div>       
      <h1>Controls being monitored for change events:</h1>
      <asp:TextBox ID="txt" runat="server" AutoPostBack="true"
       OnTextChanged="CtrlChanged" />
      <br /><br />
      <asp:CheckBox ID="chk" runat="server" AutoPostBack="true"
       OnCheckedChanged="CtrlChanged"/>
      <br /><br />
      <asp:RadioButton ID="opt1" runat="server" GroupName="Sample"
       AutoPostBack="true" OnCheckedChanged="CtrlChanged"/>
      <asp:RadioButton ID="opt2" runat="server" GroupName="Sample"
       AutoPostBack="true" OnCheckedChanged="CtrlChanged"/>
      <br /><br /><br /> 
       <h1>List of events:</h1>
      <asp:ListBox ID="lstEvents" runat="server" Width="355px"
       Height="305px" /><br />      
    </div>
  </form>
</body>
</html>
