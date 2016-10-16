<%@ Page Language="C#" MasterPageFile="~/TableMaster.master" AutoEventWireup="true" CodeFile="TableContentPage.aspx.cs" Inherits="TableContentPage_aspx" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Your content goes in this cell.<br />
    <br />
    <asp:Button ID="cmdShow" runat="server" Text="Show" OnClick="cmdShow_Click" />
    <asp:Button ID="cmdHide" runat="server" Text="Hide" OnClick="cmdHide_Click" />
</asp:Content>

