using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Appointment : System.Web.UI.Page
{

    protected void MyCalendar_SelectionChanged(object sender, EventArgs e)
    {
        lstTimes.Items.Clear();

        switch (MyCalendar.SelectedDate.DayOfWeek)
        {
            case DayOfWeek.Monday:
                // Apply special Monday schedule.
                lstTimes.Items.Add("10:00");
                lstTimes.Items.Add("10:30");
                lstTimes.Items.Add("11:00");
                break;
            default:
                lstTimes.Items.Add("10:00");
                lstTimes.Items.Add("10:30");
                lstTimes.Items.Add("11:00");
                lstTimes.Items.Add("11:30");
                lstTimes.Items.Add("12:00");
                lstTimes.Items.Add("12:30");
                break;
        }

    }
    protected void MyCalendar_DayRender(object sender, DayRenderEventArgs e)
    {
        // Check for May 5 in any year, and format it.
        if (e.Day.Date.Day == 5 && e.Day.Date.Month == 5)
        {
            e.Cell.BackColor = System.Drawing.Color.Yellow;

            // Add some static text to the cell.
            Label lbl = new Label();
            lbl.Text = "<br/>My Birthday!";
            e.Cell.Controls.Add(lbl);
        }
        // Restrict dates after the year 2012, and those on the weekend.
        if (e.Day.IsWeekend || e.Day.Date.Year > 2012)
        {
            e.Day.IsSelectable = false;
        }

    }
}
