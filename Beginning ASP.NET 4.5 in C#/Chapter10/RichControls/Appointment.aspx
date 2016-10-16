<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Appointment.aspx.cs" Inherits="Appointment" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Untitled Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="border-right: 2px groove; border-top: 2px groove; border-left: 2px groove; border-bottom: 2px groove">
            <tr>
                <td style="width: 199px; padding-right: 5px; padding-left: 5px; padding-bottom: 5px; padding-top: 5px;">
                    Choose day:<br />
                    <asp:Calendar ID="MyCalendar" runat="server" OnDayRender="MyCalendar_DayRender" OnSelectionChanged="MyCalendar_SelectionChanged">
                    </asp:Calendar>
                </td>
                <td style="width: 215px; padding-right: 5px; padding-left: 5px; padding-bottom: 5px; padding-top: 5px;" valign="top">
                    Choose time:<br />
                    <asp:ListBox ID="lstTimes" runat="server" Height="168px" Width="136px"></asp:ListBox></td>
            </tr>
        </table>    
    </div>        
    </form>
</body>
</html>
