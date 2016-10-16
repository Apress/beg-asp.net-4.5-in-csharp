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

public partial class CookieExample : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		HttpCookie cookie = Request.Cookies["Preferences"];
		if (cookie == null)
		{
			lblWelcome.Text = "<b>Unknown Customer</b>";
		}
		else
		{
			lblWelcome.Text = "<b>Cookie Found.</b><br><br>";
			lblWelcome.Text += "Welcome, " + cookie["Name"];
		}

    }
	protected void cmdStore_Click(object sender, EventArgs e)
	{
		// Check for a cookie, and only create a new one if
		// one doesn't already exist.
		HttpCookie cookie = Request.Cookies["Preferences"];
		if (cookie == null)
		{
			cookie = new HttpCookie("Preferences");
		}

		cookie["Name"] = txtName.Text;
		cookie.Expires = DateTime.Now.AddYears(1);
		Response.Cookies.Add(cookie);

		lblWelcome.Text = "<b>Cookie Created.</b><br><br>";
		lblWelcome.Text += "New Customer: " + cookie["Name"];

	}
}
