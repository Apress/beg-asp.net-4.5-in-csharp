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

public partial class GetProfile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		
    }
	protected void cmdGet_Click(object sender, EventArgs e)
	{
		ProfileCommon profile = Profile.GetProfile(txtUserName.Text);
        if (profile.LastUpdatedDate == DateTime.MinValue)
        {
            lbl.Text = "No user match found.";
        }
        else
        {
            lbl.Text = "This user lives in " + profile.Address.Country;
        }
	}
}
