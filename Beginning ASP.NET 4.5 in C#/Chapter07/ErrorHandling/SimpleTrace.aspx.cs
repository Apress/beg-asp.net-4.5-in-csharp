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

public partial class SimpleTrace : System.Web.UI.Page
{

    protected void cmdTrace_Click(object sender, EventArgs e)
    {
        Page.Trace.IsEnabled = true;

        Session["TestString"] = "This is just a string.";
        Session["MyDataSet"] = new DataSet();
    }
}
