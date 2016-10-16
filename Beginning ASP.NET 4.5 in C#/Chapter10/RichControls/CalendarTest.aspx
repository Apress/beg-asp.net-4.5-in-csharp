<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CalendarTest.aspx.cs" Inherits="CalendarTest" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="MyCalendar" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" OnDayRender="MyCalendar_DayRender" OnSelectionChanged="MyCalendar_SelectionChanged" SelectionMode="DayWeek" Width="350px">
            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <TodayDayStyle BackColor="#CCCCCC" />
            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
            <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True"
                Font-Size="12pt" ForeColor="#333399" />
        </asp:Calendar>
        <br />
        <asp:Label ID="lblDates" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
