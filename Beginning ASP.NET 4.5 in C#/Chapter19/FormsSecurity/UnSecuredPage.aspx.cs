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

public partial class UnSecuredPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblInfo.Text = "Are you authenticated? ";
        lblInfo.Text += User.Identity.IsAuthenticated;
    }
    protected void cmdGo_Click(object sender, EventArgs e)
    {
        Response.Redirect("SecuredPages/SecuredPage.aspx");
    }
}
