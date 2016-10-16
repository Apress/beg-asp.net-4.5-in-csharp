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

public partial class SimpleTypes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		Calendar1.SelectedDate = DateTime.Now;
    }
	protected void cmdShow_Click(object sender, EventArgs e)
	{
		lbl.Text = "First Name: " + Profile.FirstName + "<br />" +
			"Last Name: " + Profile.LastName + "<br />" +
			"Date of Birth: " + Profile.DateOfBirth.ToString("D");
	}
	protected void cmdSet_Click(object sender, EventArgs e)
	{
		Profile.FirstName = txtFirst.Text;
		Profile.LastName = txtLast.Text;
		Profile.DateOfBirth = Calendar1.SelectedDate;
	}
}
