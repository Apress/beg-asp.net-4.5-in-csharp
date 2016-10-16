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

public partial class TimedRefresh : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = DateTime.Now.ToLongTimeString();
    }

    
    protected void TimerControl1_Tick(object sender, EventArgs e)
    {
        int tickCount = 0;
        if (ViewState["TickCount"] != null)
        {
            tickCount = (int)ViewState["TickCount"];
        }
        tickCount++;
        ViewState["TickCount"] = tickCount;
        if (tickCount > 10)
        {
            TimerControl1.Enabled = false;
        }

    }
}
