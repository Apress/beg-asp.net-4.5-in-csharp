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

public partial class PreserveMembers : System.Web.UI.Page
{
	private string contents;
    protected void Page_Load(object sender, EventArgs e)
    {
		if (this.IsPostBack)
		{
			// Restore variables.
			contents = (string)ViewState["contents"];
		}
    }

	protected void Page_PreRender(Object sender, EventArgs e)
	{
		// Persist variables.
		ViewState["contents"] = contents;
	}

	protected void cmdSave_Click(object sender, EventArgs e)
	{
		// Transfer contents of text box to member variable.
		contents = txtValue.Text;
		txtValue.Text = "";
	}
	protected void cmdLoad_Click(object sender, EventArgs e)
	{
		// Restore contents of member variable to text box.
		txtValue.Text = contents;
	}
}
