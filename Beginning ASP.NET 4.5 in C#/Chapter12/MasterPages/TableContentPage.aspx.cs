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

public partial class TableContentPage_aspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
	protected void cmdHide_Click(object sender, EventArgs e)
	{
		TableMaster master = (TableMaster)this.Master;
        master.ShowNavigationControls = false;
	}
	protected void cmdShow_Click(object sender, EventArgs e)
	{
		TableMaster master = (TableMaster)this.Master;
        master.ShowNavigationControls = true;
	}
}
