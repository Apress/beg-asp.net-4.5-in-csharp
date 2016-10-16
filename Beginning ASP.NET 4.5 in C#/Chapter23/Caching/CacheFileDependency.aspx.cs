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

public partial class CacheFileDependency : System.Web.UI.Page
{
	protected void Page_PreRender(object sender, EventArgs e)
	{
		lblInfo.Text += "<br />";
	}

    protected void Page_Load(object sender, EventArgs e)
    {
		if (!this.IsPostBack)
			{
				lblInfo.Text += "Creating dependent item...<br />";
				Cache.Remove("File");
				System.Web.Caching.CacheDependency dependency =
				 new System.Web.Caching.CacheDependency(Server.MapPath("dependency.txt"));
				string item = "Dependent cached item";
				lblInfo.Text += "Adding dependent item<br />";
				Cache.Insert("File", item, dependency);
			}
    }
	protected void cmdModify_Click(object sender, EventArgs e)
	{
		lblInfo.Text += "Modifying dependency.txt file.<br />";
		StreamWriter w = File.CreateText(Server.MapPath("dependency.txt"));
		w.Write(DateTime.Now);
		w.Flush();
		w.Close();
	}
	protected void cmdGetItem_Click(object sender, EventArgs e)
	{
		if (Cache["File"] == null)
		{
			lblInfo.Text += "Cache item no longer exits.<br />";
		}
		else
		{
			string cacheInfo = (string)Cache["File"];
			lblInfo.Text += "Retrieved item with text: '" + cacheInfo + "'<br />";
		}
	}
}
