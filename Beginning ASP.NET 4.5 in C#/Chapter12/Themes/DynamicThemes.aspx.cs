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
using System.IO;

public partial class DynamicThemes : System.Web.UI.Page
{
     
    protected void Page_Load(object sender, EventArgs e)
    {
		if (!Page.IsPostBack)
		{
			// Fill the list box with available themes
			// by reading the folders in the App_Themes folder.
			DirectoryInfo themeDir = new DirectoryInfo(Server.MapPath("App_Themes"));
			lstThemes.DataTextField = "Name";
			lstThemes.DataSource = themeDir.GetDirectories();
			lstThemes.DataBind();
		}
    }

	protected void Page_PreInit(object sender, EventArgs e)
	{
		if (Session["Theme"] == null)
		{
			// No theme has been chosen. Choose a default
			// (or set a blank string to make sure no theme
			// is used).
			Page.Theme = "";
		}
		else
		{
			Page.Theme = (string)Session["Theme"];
		}
	}

	protected void cmdApply_Click(object sender, EventArgs e)
	{
		// Set the chosen theme.
		Session["Theme"] = lstThemes.SelectedValue;

		// Refresh the page.
		Server.Transfer(Request.FilePath);

	}
    protected void cmdClear_Click(object sender, EventArgs e)
    {
        // Set the chosen theme.
        Session["Theme"] = "";

        // Refresh the page.
        Server.Transfer(Request.FilePath);
    }
}
