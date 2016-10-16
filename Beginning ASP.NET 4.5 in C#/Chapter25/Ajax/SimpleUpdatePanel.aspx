<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SimpleUpdatePanel.aspx.cs" Inherits="SimpleUpdatePanel" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    
    <script type="text/javascript">

    function pageLoad()
    {
        // Get the PageRequestManager for this page.
        var pageManager = Sys.WebForms.PageRequestManager.getInstance();

        // Attach a function named endRequest to the endRequest event.
        pageManager.add_endRequest(endRequest);
    }
    function endRequest(sender, args)
    {
        // Check if an error exists.
        if (args.get_error() != null)
        {
            // Find the HTML element for the label where you want to show
            // the error message.
            var lbl = document.getElementById("lblError");

            // Set the content of the label using the error message.
            lbl.innerHTML = args.get_error().message;

            // Suppress the message box.
            args.set_errorHandled(true);
        }
    }
</script>
</head>

<body>
    <form id="form1" runat="server">
    <div>
      <asp:ScriptManager ID="ScriptManager1" runat="server">
	  </asp:ScriptManager>
	  <img alt="Lava Lamp" src="lava_lamp.gif" style="width: 66px; height: 144px" /><br />
		
      <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
          <div style="background-color:#FFFFE0;padding: 20px">
            <asp:Label ID="lblTime" runat="server" Font-Bold="True"></asp:Label>
            <br />
            <br />
            <asp:Button ID="cmdRefreshTime" runat="server" Text="Refresh Time" 
      	    	onclick="cmdRefreshTime_Click" />
          </div>
        </ContentTemplate>
      </asp:UpdatePanel>

      <br />
      <asp:Label ID="lblError" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
