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

public partial class CrossPage1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		if (Request.QueryString["err"] != null)
			Page.Validate();
    }


	protected void cmdTransfer_Click(object sender, EventArgs e)
	{
		Server.Transfer("CrossPage2.aspx", true);
	}

    public string FullName
    {
        get { return txtFirstName.Text + " " + txtLastName.Text; }
    }

}
