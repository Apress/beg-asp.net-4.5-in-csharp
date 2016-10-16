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
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class RecordEditor : System.Web.UI.Page
{
    private string connectionString = WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            // Define the ADO.NET objects for selecting Products.
            string selectSQL = "SELECT ProductName, ProductID FROM Products";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(selectSQL, con);

            // Open the connection.
            con.Open();

            // Define the binding.
            lstProduct.DataSource = cmd.ExecuteReader();
            lstProduct.DataTextField = "ProductName";
            lstProduct.DataValueField = "ProductID";

            // Activate the binding.
            lstProduct.DataBind();

            con.Close();

            // Make sure nothing is currently selected.
            lstProduct.SelectedIndex = -1;
        }

    }
    protected void lstProduct_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Create a command for selecting the matching product record.
        string selectProduct = "SELECT ProductName, QuantityPerUnit, " +
         "CategoryName FROM Products INNER JOIN Categories ON " +
         "Categories.CategoryID=Products.CategoryID " +
         "WHERE ProductID=@ProductID";
        
        // Create the Connection and Command objects.
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmdProducts = new SqlCommand(selectProduct, con);
        cmdProducts.Parameters.AddWithValue("@ProductID", lstProduct.SelectedItem.Value);

        // Retrieve the information for the selected product.
        using (con)
        {
            con.Open();
            SqlDataReader reader = cmdProducts.ExecuteReader();
            reader.Read();

            // Update the display.
            lblRecordInfo.Text = "<b>Product:</b> " + reader["ProductName"] + "<br />";
            lblRecordInfo.Text += "<b>Quantity:</b> " + reader["QuantityPerUnit"] + "<br />";
            lblRecordInfo.Text += "<b>Category:</b> " + reader["CategoryName"];

            // Store the corresponding CategoryName for future reference.
            string matchCategory = reader["CategoryName"].ToString();

            // Close the reader.
            reader.Close();

            // Create a new Command for selecting categories.
            string selectCategory = "SELECT CategoryName, CategoryID FROM Categories";
            SqlCommand cmdCategories = new SqlCommand(selectCategory, con);

            // Retrieve the category information, and bind it.
            lstCategory.DataSource = cmdCategories.ExecuteReader();
            lstCategory.DataTextField = "CategoryName";
            lstCategory.DataValueField = "CategoryID";
            lstCategory.DataBind();

            // Highlight the matching category in the list.
            lstCategory.Items.FindByText(matchCategory).Selected = true;
        }


        pnlCategory.Visible = true;

    }
    protected void cmdUpdate_Click(object sender, EventArgs e)
    {
        // Define the Command.
        string updateCommand = "UPDATE Products " +
         "SET CategoryID=@CategoryID WHERE ProductID=@ProductID";

        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(updateCommand, con);

        cmd.Parameters.AddWithValue("@CategoryID", lstCategory.SelectedItem.Value);
        cmd.Parameters.AddWithValue("@ProductID", lstProduct.SelectedItem.Value);

        // Perform the update.
        using (con)
        {
            con.Open();
            cmd.ExecuteNonQuery();
        }

    }
}
