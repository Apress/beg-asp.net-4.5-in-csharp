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

public partial class RecordEditorDataSource_MatchAllValues : System.Web.UI.Page
{
    protected void sourceProductDetails_Updated(object sender, SqlDataSourceStatusEventArgs e)
    {
        if (e.AffectedRows == 0)
        {
            lblInfo.Text = "No update was performed. A concurrency error is likely, or the command is incorrectly written.";
        }
        else
        {
            lblInfo.Text = "Record successfully updated.";
        }
    }
}
