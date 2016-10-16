using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NorthwindModel;

public partial class UpdateInsertDelete : System.Web.UI.Page
{
    private NorthwindEntities entities = new NorthwindEntities();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdUpdate_Click(object sender, EventArgs e)
    {
        // Only allow updating if a record is currently selected.
        if (gridProducts.SelectedIndex != -1)
        {
            // Use a LINQ expression to find the selected product.
            int selectedProductID = (int)gridProducts.SelectedDataKey.Value;
            var matches = from p in entities.Products
                              where p.ProductID == selectedProductID
                              select p;

            // Execute the query and return the entity object.
            Product product = matches.Single();

            // Change the entity object.
            product.UnitsInStock -= 1;

            // Commit the changes back to the database.
            entities.SaveChanges();
        }
    }
        
    protected void cmdInsert_Click(object sender, EventArgs e)
    {
        // The CreateProduct() method requires the three non-nullable Product fields
        // as arguments: ProductID, ProductName, and Discontinued. However, the
        // ProductName isn't actually used--when the update is finsihed, it's replaced
        // by the automatically generated ID that the database creates.
        Product newProduct = Product.CreateProduct(0, "Thick-As-Cement Milkshake", false);

        // You can now set additional properties that aren't required.
        newProduct.CategoryID = 1;
        newProduct.UnitsInStock = 10;
        newProduct.UnitPrice = 15.99M;

        // Finally, commit the changes and insert the record in the database.
        entities.Products.AddObject(newProduct);
        entities.SaveChanges();
    }

    protected void cmdDelete_Click(object sender, EventArgs e)
    {
        // Check if a row is selected.
        if (gridProducts.SelectedIndex != -1)
        {
            // Use a LINQ expression to find the selected product.
            int selectedProductID = (int)gridProducts.SelectedDataKey.Value;
            var matches = from p in entities.Products
                          where p.ProductID == selectedProductID
                          select p;

            // Execute the query and return the entity object.
            Product product = matches.Single();
                        
            // Delete the record from the database.
            entities.Products.DeleteObject(product);
            entities.SaveChanges();

            // Clear the selection (which may now be pointing to a different row.)
            gridProducts.SelectedIndex = -1;
        }
    }

    // Update grid just before page is rendered, so it includes the most
    // recent changes.
    protected override void OnPreRender(EventArgs e)
    {
        gridProducts.DataSource = entities.Products;
        gridProducts.DataBind();

        base.OnPreRender(e);
    }

}