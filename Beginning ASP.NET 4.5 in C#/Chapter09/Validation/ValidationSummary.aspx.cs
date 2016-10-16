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

public partial class ValidationSummary : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void cmdOK_Click(object sender, EventArgs e)
	{
		// Abort the event if the page isn’t valid.
		if (!Page.IsValid) return;
		lblMessage.Text = "cmdOK_Click event handler executed.";
	}
}
