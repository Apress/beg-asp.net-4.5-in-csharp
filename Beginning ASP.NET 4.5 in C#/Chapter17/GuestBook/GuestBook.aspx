<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GuestBook.aspx.cs" Inherits="GuestBook" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GuestBookList" runat="server" BackColor="White" BorderColor="#CC9966"
            BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Both" AutoGenerateColumns="False">
            
            <RowStyle BackColor="White" ForeColor="#330099" />
            
            <Columns>
            <asp:TemplateField HeaderText="Guest Book Comments">
            <ItemTemplate>
                Left By:
                <%# Eval("Author") %>
                <br />
                <b>
                    <%# Eval("Message") %>
                </b>
                <br />
                Left On:
                <%# Eval("Submitted") %>
            </ItemTemplate>
            </asp:TemplateField>
            </Columns>
            
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        </asp:GridView><br />
        <div style="left: 0px; width: 560px; position: relative; height: 248px">
            <asp:Label ID="Label1" runat="server" Height="24px" Style="z-index: 100; left: 16px;
                position: absolute; top: 16px" Width="104px">Your Name:</asp:Label>
            <asp:Label ID="Label2" runat="server" Height="24px" Style="z-index: 101; left: 16px;
                position: absolute; top: 48px" Width="104px">Your Message:</asp:Label>
            <asp:TextBox ID="txtName" runat="server" Style="z-index: 102; left: 136px; position: absolute;
                top: 16px" Width="392px"></asp:TextBox>
            <asp:TextBox ID="txtMessage" runat="server" Height="154px" Style="z-index: 104; left: 136px;
                position: absolute; top: 48px" TextMode="MultiLine" Width="392px"></asp:TextBox>
            <asp:Button ID="cmdSubmit" runat="server" OnClick="cmdSubmit_Click" Style="z-index: 105;
                left: 136px; position: absolute; top: 208px" Text="Submit" Width="104px" />
        </div>
    
        <br />
        <asp:Label ID="lblError" runat="server" Font-Bold="True" 
		ForeColor="Maroon"></asp:Label>
    </div>
    </form>
</body>
</html>
