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

public partial class ValidationGroups : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		
    }

    protected void Button_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            lblInfo.Text = "Page posted back at " + DateTime.Now.ToLongTimeString();
        }
    
    }
}
