<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ThreeColumns.aspx.cs" Inherits="ThreeColumns" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div class="LeftPanel">
       <p><b>Here is some text on the left.</b></p>
       <p>This is a great place for navigation links or a site map.</p>
    </div>
    <div class="RightPanel">
       <p><b>Here is some text on the right.</b></p>
       <p>You can put less critical content here, like links to related
        content or an advertisement.</p>
    </div>
    <div class="CenterPanel">
       <p><b>This the is middle content.</b></p>
       <p>Here you put the main content of your page--for example,
       paragraphs of text and images, forms with controls, and so on.</p>
    </div>
    </div>
    </form>
</body>
</html>
