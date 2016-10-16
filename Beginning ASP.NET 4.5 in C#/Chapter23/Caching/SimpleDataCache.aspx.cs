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

public partial class SimpleDataCache : System.Web.UI.Page
{
	protected void Page_Load(Object sender, EventArgs e)
	{
		if (this.IsPostBack)
		{
			lblInfo.Text += "Page posted back.<br />";
		}
		else
		{
			lblInfo.Text += "Page created.<br />";
		}

		if (Cache["TestItem"] == null)
		{
			lblInfo.Text += "Creating TestItem...<br />";
			DateTime testItem = DateTime.Now;

			lblInfo.Text += "Storing TestItem in cache ";
			lblInfo.Text += "for 30 seconds.<br />";
			Cache.Insert("TestItem", testItem, null,
			  DateTime.Now.AddSeconds(30), TimeSpan.Zero);
		}
		else
		{
			lblInfo.Text += "Retrieving TestItem...<br />";
			DateTime testItem = (DateTime)Cache["TestItem"];
			lblInfo.Text += "TestItem is '" + testItem.ToString();
			lblInfo.Text += "'<br />";
		}

		lblInfo.Text += "<br />";
	}

}
