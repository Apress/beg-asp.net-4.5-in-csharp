<%@ Page Title="" Language="C#" MasterPageFile="~/LayoutWithStyles.master" AutoEventWireup="true" CodeFile="LayoutWithStylesPage.aspx.cs" Inherits="LayoutWithStylesPage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <p>
    Your content goes in this middle region, which automatically takes whatever 
    space is left over.</p>
    <p>
        &nbsp;</p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="AdditionalContent" Runat="Server">
    <p>
    Additional page content goes here.</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        And down here.</p>
</asp:Content>

