<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HtmlEncodeTest.aspx.cs" Inherits="HtmlEncodeTest" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form ID="form1" runat="server">
    <div>
        <h1>Properly encoded:</h1> 
        <p ID="ctrl2" runat="server"/>
        <br /><hr /><br />
        <h1>Incorrectly encoded:</h1> 
        <p ID="ctrl1" runat="server"/>
    </div>
    </form>
</body>
</html>
