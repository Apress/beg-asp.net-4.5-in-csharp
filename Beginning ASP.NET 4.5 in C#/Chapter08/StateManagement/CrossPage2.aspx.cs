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

public partial class CrossPage2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (PreviousPage != null)
        {

            lblInfo.Text = "You came from a page titled " +
                PreviousPage.Title + "<br />";

            CrossPage1 prevPage = PreviousPage as CrossPage1;
            if (prevPage != null)
            {
                lblInfo.Text += "You typed in this: " + prevPage.FullName +
                  "<br />";
            }                    
        }        
    }
}