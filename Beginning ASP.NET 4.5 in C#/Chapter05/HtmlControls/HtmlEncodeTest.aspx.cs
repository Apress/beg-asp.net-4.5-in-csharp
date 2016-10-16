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

public partial class HtmlEncodeTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		ctrl1.InnerHtml = "To <b>bold</b> text use the <b> tag.";
		ctrl2.InnerHtml = "To <b>bold</b> text use the " + Server.HtmlEncode("<b>") + " tag.";
    }
}
