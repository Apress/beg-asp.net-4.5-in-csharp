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

public partial class DetailsView : System.Web.UI.Page
{
    private bool insertComplete = false;
    protected void SqlDataSource1_Inserted(object sender, SqlDataSourceStatusEventArgs e)
    {
        // Flag that a new record is inserted, which we'll show when the grid is bound.
        if (e.AffectedRows > 0) insertComplete = true;

        // You could also get output parameters at this point from e.Command.
        // For example, if you called a stored procedure that returns the newly
        // generated ProductID value, you could get it here.
    }

    protected void DetailsView1_DataBound(object sender, EventArgs e)
    {
        if (insertComplete)
        {
            // Show the last record (the newly added one).
            DetailsView1.PageIndex = DetailsView1.PageCount - 1;
        }
    }
}
