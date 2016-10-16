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

public partial class Cookieless1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
	{
		Session["test"] = "Test String";

    }
	protected void cmdLink_Click(object sender, EventArgs e)
	{
		Response.Redirect("Cookieless2.aspx");
	}
	protected void cmdLinkAbsolute_Click(object sender, EventArgs e)
	{
		// Create a new URL based on the current URL (but ending with 
		// the page Cookieless2.aspx instead of Cookieless1.aspx.
		string url = "http://" + Request.Url.Authority +
			Request.Url.Segments[0] + "Cookieless2.aspx";
		Response.Redirect(url);
	}
}
