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

public partial class DataSetBinding : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Define a DataSet with a single DataTable.
        DataSet dsInternal = new DataSet();
        dsInternal.Tables.Add("Users");

        // Define two columns for this table.
        dsInternal.Tables["Users"].Columns.Add("Name");
        dsInternal.Tables["Users"].Columns.Add("Country");

        // Add some actual information into the table.
        DataRow rowNew = dsInternal.Tables["Users"].NewRow();
        rowNew["Name"] = "John";
        rowNew["Country"] = "Uganda";
        dsInternal.Tables["Users"].Rows.Add(rowNew);

        rowNew = dsInternal.Tables["Users"].NewRow();
        rowNew["Name"] = "Samantha";
        rowNew["Country"] = "Belgium";
        dsInternal.Tables["Users"].Rows.Add(rowNew);

        rowNew = dsInternal.Tables["Users"].NewRow();
        rowNew["Name"] = "Rico";
        rowNew["Country"] = "Japan";
        dsInternal.Tables["Users"].Rows.Add(rowNew);

        // Define the binding.
        lstUser.DataSource = dsInternal.Tables["Users"];
        lstUser.DataTextField = "Name";

        // Define the binding.
        lstUser.DataSource = dsInternal;
        lstUser.DataMember = "Users";
        lstUser.DataTextField = "Name";

        this.DataBind();  // Could also use lstItems.DataBind() to bind just the list box.

    }
}
