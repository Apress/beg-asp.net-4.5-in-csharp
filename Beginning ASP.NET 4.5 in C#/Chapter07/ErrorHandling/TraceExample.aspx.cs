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

public partial class TraceExample : System.Web.UI.Page
{

    protected void cmdError_Click(object sender, EventArgs e)
    {
        try
        {
            DivideNumbers(5, 0);
        }
        catch (Exception err)
        {
            Trace.Warn("cmdError_Click", "Caught Error", err);
        }

    }
    protected void cmdWrite_Click(object sender, EventArgs e)
    {
        Trace.Write("About to place an item in session state.");
        Session["Test"] = "Contents";
        Trace.Write("Placed item in session state.");

    }
    protected void cmdWriteCategory_Click(object sender, EventArgs e)
    {
        Trace.Write("Page_Load", "About to place an item in session state.");
        Session["Test"] = "Contents";
        Trace.Write("Page_Load", "Placed item in session state.");
    }

    private decimal DivideNumbers(decimal number, decimal divisor)
    {
        return number / divisor;
    }

}
