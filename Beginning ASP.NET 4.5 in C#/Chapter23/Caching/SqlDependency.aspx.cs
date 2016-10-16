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
using System.Data.SqlClient;
using System.Web.Caching;
using System.Web.Configuration;

public partial class Sql2005Dependency : System.Web.UI.Page
{
	protected void Page_PreRender(object sender, EventArgs e)
	{
		lblInfo.Text += "<br/>";
	}

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!this.IsPostBack)
		{
            //SqlDependency.Stop(connectionString);
            // Must be called at least once for application to set
            // up listener.
            SqlDependency.Start(connectionString);

			lblInfo.Text += "Creating dependent item...<br />";
			Cache.Remove("Customers");

			DataTable dt = GetTable();
			lblInfo.Text += "Adding dependent item<br />";
			Cache.Insert("Customers", dt, dependency);
		}
	}

	private SqlCacheDependency dependency;
	private string connectionString =
  WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
	private DataTable GetTable()
	{
		SqlConnection con = new SqlConnection(connectionString);
		string sql = "SELECT ContactName FROM dbo.Customers";
		SqlDataAdapter da = new SqlDataAdapter(sql, con);
 
        // Create a dependency for the Employees table.
        dependency = new SqlCacheDependency(da.SelectCommand);
   		
		DataSet ds = new DataSet();
		da.Fill(ds, "Customers");             
		return ds.Tables[0];
	}

	protected void cmdModify_Click(object sender, EventArgs e)
	{
		SqlConnection con = new SqlConnection(connectionString);
		// Even a change that really does do anything is still a change.
        string sql = "UPDATE dbo.Customers SET ContactName='Maria Anders' WHERE CustomerID='ALFKI'";
		SqlCommand cmd = new SqlCommand(sql, con);

		try
		{
			con.Open();
			cmd.ExecuteNonQuery();
		}
		finally
		{
			con.Close();
		}
		lblInfo.Text += "Update completed (no need to wait, because polling is not used).<br />";
	}
	protected void cmdGetItem_Click(object sender, EventArgs e)
	{
		if (Cache["Customers"] == null)
		{
			lblInfo.Text += "Cache item no longer exits.<br />";
		}
		else
		{
			lblInfo.Text += "Item is still present.<br />";
		}
	}

}
