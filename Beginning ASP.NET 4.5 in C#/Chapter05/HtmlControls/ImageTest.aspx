<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageTest.aspx.cs" Inherits="ImageTest" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form ID="form1" runat="server">
    <div>
    
      <h1>Click on the Image </h1>

      <input type="image"
             src="button.png" 
             ID="ImgButton"
             runat="server" OnServerClick="ImgButton_ServerClick" />
      <br />
      <p ID="Result" runat="server"/>


    </div>
    </form>
</body>
</html>
