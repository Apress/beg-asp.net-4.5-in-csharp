using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace WebControls
{
	public partial class EventTracker : System.Web.UI.Page
	{
	
		protected void Page_Load(object sender, System.EventArgs e)
		{
			 Log("<< Page_Load >>");
		}

		private void Log(string entry)
		{
			lstEvents.Items.Add(entry);

			// Select the last item to scroll the list so the most recent
			// entries are visible.
			lstEvents.SelectedIndex = lstEvents.Items.Count - 1;
		}

		protected void Page_PreRender(object sender, System.EventArgs e)
		{
			// When the Page.PreRender event occurs it is too late
			// to change the list.
			Log("Page_PreRender");
		}

		protected void CtrlChanged(Object sender, EventArgs e)
		{
			// Find the control ID of the sender.
			// This requires converting the Object type into a Control class.
			string ctrlName = ((Control)sender).ID;
			Log(ctrlName + " Changed");
		}

	}
}
