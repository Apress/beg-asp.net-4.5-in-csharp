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

public partial class WaitIndicator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }

    protected void cmdRefreshTime_Click(object sender, EventArgs e)
    {
        System.Threading.Thread.Sleep(TimeSpan.FromSeconds(10));
        lblTime.Text = DateTime.Now.ToLongTimeString();
    }
}
