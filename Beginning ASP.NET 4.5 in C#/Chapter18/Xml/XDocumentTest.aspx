<%@ Page Language="C#" AutoEventWireup="true" CodeFile="XDocumentTest.aspx.cs" Inherits="XDocumentTest" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>XDocument Test</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    
    <div class="Box">
        <asp:Button ID="cmdCreateXml" runat="server" Text="Create XML" OnClick="cmdCreateXml_Click" />
        <asp:Button ID="cmdReadXml" runat="server" Text="Read XML" OnClick="cmdReadXml_Click" Width="103px" />
        <asp:Button ID="cdmSearchXml" runat="server" Text="Search XML" OnClick="cmdSearchXml_Click" Width="115px" />
    </div>
    <div>
        <br />
        <asp:Label ID="lblXml" runat="server" Text="" EnableViewState="false" ></asp:Label>&nbsp;
        <asp:GridView ID="gridResults"
            runat="server" EnableViewState="false" >
        </asp:GridView>
    </div>
    </form>
</body>
</html>
