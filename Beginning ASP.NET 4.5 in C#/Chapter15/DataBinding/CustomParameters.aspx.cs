using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class CustomParameters : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void sourceOrders_Selecting(object sender,
     SqlDataSourceSelectingEventArgs e)
    {        
        e.Command.Parameters["@EarliestOrderDate"].Value = DateTime.Today.AddYears(-10);
    }

}
