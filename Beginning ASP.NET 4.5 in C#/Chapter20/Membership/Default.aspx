<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <asp:LoginView ID="LoginView1" runat="server">
        <AnonymousTemplate>
            <h2>You are anonymous</h2>
             Why don't you <a href="Login.aspx">log in</a>?
        </AnonymousTemplate>
        <LoggedInTemplate>
            <h2>You are logged in</h2>
            <p>You are now ready to see this super-secret content.</p>
        </LoggedInTemplate>
      </asp:LoginView>
    </div>
    </form>
</body>
</html>
