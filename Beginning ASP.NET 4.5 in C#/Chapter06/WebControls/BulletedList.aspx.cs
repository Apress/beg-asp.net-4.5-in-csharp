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

public partial class BulletedList_aspx : System.Web.UI.Page
{
     
    protected void Page_Load(object sender, EventArgs e)
    {
		if (!Page.IsPostBack)
		{
			foreach (string style in
				Enum.GetNames(typeof(BulletStyle)))
			{
				BulletedList1.Items.Add(style);
			}
		}
    }
	protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
	{
		string styleName = BulletedList1.Items[e.Index].Text;
		BulletStyle style = (BulletStyle)Enum.Parse(typeof(BulletStyle), styleName);
		BulletedList1.BulletStyle = style;
	}
}
