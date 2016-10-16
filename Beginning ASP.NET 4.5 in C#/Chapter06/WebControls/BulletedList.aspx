<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BulletedList.aspx.cs" Inherits="BulletedList_aspx" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form runat="server">
    <div>
        Bullet styles:<br />
        <br />
        <asp:BulletedList BulletStyle="Numbered" DisplayMode="LinkButton" ID="BulletedList1"
            OnClick="BulletedList1_Click" runat="server">
        </asp:BulletedList>   
    </div>
    </form>
</body>
</html>
