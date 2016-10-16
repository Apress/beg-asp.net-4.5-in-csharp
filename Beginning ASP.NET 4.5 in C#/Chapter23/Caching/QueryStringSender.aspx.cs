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

public partial class QueryStringSender : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdVersion_Click(Object sender, EventArgs e)
    {
        Response.Redirect("QueryStringRecipient.aspx" + "?Version=" +
          ((Control)sender).ID);
    }

}
