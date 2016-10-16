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

public partial class CalendarTest : System.Web.UI.Page
{
    protected void MyCalendar_SelectionChanged(object sender, EventArgs e)
	{
		lblDates.Text = "You selected these dates:<br />";

		foreach (DateTime dt in MyCalendar.SelectedDates)
		{
			lblDates.Text += dt.ToLongDateString() + "<br />";
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
			lbl.Text = "<br />My Birthday!";
			e.Cell.Controls.Add(lbl);
		}


	}
}
