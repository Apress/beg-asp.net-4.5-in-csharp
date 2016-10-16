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

public partial class ComplexTypes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		if (!Page.IsPostBack)
			LoadProfile();
    }
	protected void cmdSave_Click(object sender, EventArgs e)
	{
		Profile.Address = new Address(txtName.Text, txtStreet.Text, txtCity.Text, txtZip.Text, txtState.Text, txtCountry.Text);
	}
	protected void cmdGet_Click(object sender, EventArgs e)
	{
		LoadProfile();
	}

	private void LoadProfile()
	{
		txtName.Text = Profile.Address.Name;
		txtStreet.Text = Profile.Address.Street;
		txtCity.Text = Profile.Address.City;
		txtZip.Text = Profile.Address.ZipCode;
		txtState.Text = Profile.Address.State;
		txtCountry.Text = Profile.Address.Country;
	}
}

