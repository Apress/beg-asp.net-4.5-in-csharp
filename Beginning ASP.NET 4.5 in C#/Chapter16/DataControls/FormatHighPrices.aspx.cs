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

public partial class FormatHighPrices : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            // Get the price for this row.
            decimal price = (decimal)DataBinder.Eval(e.Row.DataItem, "UnitPrice");

            if (price > 50)
            {
                e.Row.BackColor = System.Drawing.Color.Maroon;
                e.Row.ForeColor = System.Drawing.Color.White;
                e.Row.Font.Bold = true;
            }
        }

    }
}
