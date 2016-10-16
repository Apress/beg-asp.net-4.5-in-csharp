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

public partial class Menu2Host : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Request.Params["product"] != null)
            {
                lblSelection.Text = "You chose: ";
                lblSelection.Text += Request.Params["product"];
            }
        }
    }

    protected void LinkClicked(object sender, LinkClickedEventArgs e)
    {
        if (e.Url == "Menu2Host.aspx?product=Furniture")
        {
            lblClick.Text = "This link is not allowed.";
            e.Cancel = true;
        }
        else
        {
            // Allow the redirect, and don't make any changes to the URL.
        }
    }

}

