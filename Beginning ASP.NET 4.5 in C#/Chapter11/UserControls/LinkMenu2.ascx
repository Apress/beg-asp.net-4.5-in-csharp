<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LinkMenu2.ascx.cs" Inherits="LinkMenu2" %>
<div style="border-right: 2px groove; padding-right: 5px; border-top: 2px groove;
    padding-left: 5px; font-weight: bold; font-size: small; padding-bottom: 5px;
    border-left: 2px groove; width: 100px; padding-top: 5px; border-bottom: 2px groove;
    font-family: Verdana; height: 120px; background-color: #FFFFD9">
    Products:
    <asp:LinkButton ID="lnkBooks" runat="server" CommandArgument="Menu2Host.aspx?product=Books" OnCommand="lnk_Command" >Books
  </asp:LinkButton><br />
    <asp:LinkButton ID="lnkToys" runat="server" CommandArgument="Menu2Host.aspx?product=Toys" OnCommand="lnk_Command">Toys
  </asp:LinkButton><br />
    <asp:LinkButton ID="lnkSports" runat="server" CommandArgument="Menu2Host.aspx?product=Sports" OnCommand="lnk_Command">Sports
  </asp:LinkButton><br />
    <asp:LinkButton ID="lnkFurniture" runat="server" CommandArgument="Menu2Host.aspx?product=Furniture" OnCommand="lnk_Command">Furniture
  </asp:LinkButton>
</div>
