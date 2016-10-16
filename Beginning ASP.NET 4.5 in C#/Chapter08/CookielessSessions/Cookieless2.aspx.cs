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

public partial class Cookieless2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Session["test"] != null)
		{
			lblInfo.Text = "Successfully retrieved " + (string)Session["test"];
		}
		else
		{
			lblInfo.Text = "Session information not found.";
		}
    }
}
