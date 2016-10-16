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

public partial class AdBoard : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            DatabaseComponent.DBUtil DB = new DatabaseComponent.DBUtil();

            lstCategories.DataSource = DB.GetCategories();
            lstCategories.DataTextField = "Name";
            lstCategories.DataValueField = "ID";
            lstCategories.DataBind();
            pnlNew.Visible = false;
        }  
    }
    protected void cmdDisplay_Click(object sender, EventArgs e)
    {
        DatabaseComponent.DBUtil DB = new DatabaseComponent.DBUtil();

        gridItems.DataSource = DB.GetItems(
          Int32.Parse(lstCategories.SelectedItem.Value));
        gridItems.DataBind();
        pnlNew.Visible = true;

    }
    protected void cmdAdd_Click(object sender, EventArgs e)
    {
                DatabaseComponent.DBUtil DB = new DatabaseComponent.DBUtil();

        try
        {
            DB.AddItem(txtTitle.Text, txtDescription.Text, 
              Decimal.Parse(txtPrice.Text),
              Int32.Parse(lstCategories.SelectedItem.Value));

            gridItems.DataSource = DB.GetItems(
              Int32.Parse(lstCategories.SelectedItem.Value));
            gridItems.DataBind();
        }
        catch (FormatException err)
        {
            // An error occurs if the user has entered an
            // invalid price (non-numeric characters).
            // In this case, take no action.
            // Another option is to add a validator control
            // for the price text box to prevent invalid input.
        }
    }

}
