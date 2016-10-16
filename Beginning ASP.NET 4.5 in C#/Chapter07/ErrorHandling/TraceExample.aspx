<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TraceExample.aspx.cs" Inherits="TraceExample" Trace="true" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="cmdWrite" runat="server" OnClick="cmdWrite_Click" Text="Write" />
        <asp:Button ID="cmdWriteCategory" runat="server" OnClick="cmdWriteCategory_Click"
            Text="Write Category" />
        <asp:Button ID="cmdError" runat="server" OnClick="cmdError_Click" Text="Write Error" />
    
    </div>
    </form>
</body>
</html>
