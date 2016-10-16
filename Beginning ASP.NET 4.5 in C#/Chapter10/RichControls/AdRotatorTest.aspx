<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AdRotatorTest.aspx.cs" Inherits="AdRotatorTest" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:AdRotator id="Ads" runat="server" 
     Target="_blank" AdvertisementFile="~/MainAds.xml" OnAdCreated="Ads_AdCreated" />
        <br />
        <br />
        <br />
        <asp:HyperLink ID="lnkBanner" runat="server">HyperLink</asp:HyperLink></div>
    </form>
</body>
</html>
