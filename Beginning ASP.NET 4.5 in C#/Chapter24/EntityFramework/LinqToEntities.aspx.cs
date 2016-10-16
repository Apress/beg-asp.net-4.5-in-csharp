using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NorthwindModel;

public partial class LinqToEntities : System.Web.UI.Page
{
    // Create a data context, so it can be used by any
    // event handlers in this page.
    private NorthwindEntities entities = new NorthwindEntities();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {            
            lstCategories.DataTextField = "CategoryName";
            lstCategories.DataValueField = "CategoryID";
            lstCategories.DataSource = entities.Categories;
            lstCategories.DataBind();
        }
    }

    protected void lstCategories_SelectedIndexChanged(object sender, EventArgs e)
    {        
        int selectedID = Int32.Parse(lstCategories.SelectedValue);
        if (selectedID == -1)
        {
            // The "(Select a Category)" item was picked.
            // Don't show anything.
            gridProducts.DataSource = null;
        }
        else
        {
            // Query the products in the selected category.
            gridProducts.DataSource = from product in entities.Products
                                      where product.CategoryID == selectedID
                                      select new
                                      {
                                          Name = product.ProductName,
                                          Quantity = product.QuantityPerUnit,
                                          Stock = product.UnitsInStock
                                      };
        }
        gridProducts.DataBind();
                                  
    }
}