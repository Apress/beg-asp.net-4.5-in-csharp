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

public partial class QueryStringRecipient : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblDate.Text = "The time is now:<br>" + DateTime.Now.ToString();

        switch (Request.QueryString["Version"])
        {
            case "cmdLarge":
                lblDate.Font.Size = FontUnit.XLarge;
                break;
            case "cmdNormal":
                lblDate.Font.Size = FontUnit.Large;
                break;
            case "cmdSmall":
                lblDate.Font.Size = FontUnit.Small;
                break;
        }

    }
}
