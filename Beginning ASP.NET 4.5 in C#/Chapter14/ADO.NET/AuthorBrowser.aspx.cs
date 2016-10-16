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
using System.Text;

public partial class AuthorBrowser : System.Web.UI.Page
{
    private string connectionString =
  WebConfigurationManager.ConnectionStrings["Pubs"].ConnectionString;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            FillAuthorList();
        }
    }

    private void FillAuthorList()
    {
        lstAuthor.Items.Clear();

        // Define the Select statement.
        // Three pieces of information are needed: the unique id,
        // and the first and last name.
        string selectSQL = "SELECT au_lname, au_fname, au_id FROM Authors";

        // Define the ADO.NET objects.
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader reader;

        // Try to open database and read information.
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();

            // For each item, add the author name to the displayed
            // list box text, and store the unique ID in the Value property.
            while (reader.Read())
            {
                ListItem newItem = new ListItem();
                newItem.Text = reader["au_lname"] + ", " + reader["au_fname"];
                newItem.Value = reader["au_id"].ToString();
                lstAuthor.Items.Add(newItem);
            }
            reader.Close();
        }
        catch (Exception err)
        {
            lblResults.Text = "Error reading list of names. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }

    protected void lstAuthor_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Create a Select statement that searches for a record
        // matching the specific author id from the Value property.
        string selectSQL;
        selectSQL = "SELECT * FROM Authors ";
        selectSQL += "WHERE au_id='" + lstAuthor.SelectedItem.Value + "'";

        // Define the ADO.NET objects.
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader reader;

        // Try to open database and read information.
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();

            StringBuilder sb = new StringBuilder();
            sb.Append("<b>");
            sb.Append(reader["au_lname"]);
            sb.Append(", ");
            sb.Append(reader["au_fname"]);
            sb.Append("</b><br />");
            sb.Append("Phone: ");
            sb.Append(reader["phone"]);
            sb.Append("<br />");
            sb.Append("Address: ");
            sb.Append(reader["address"]);
            sb.Append("<br />");
            sb.Append("City: ");
            sb.Append(reader["city"]);
            sb.Append("<br />");
            sb.Append("State: ");
            sb.Append(reader["state"]);
            sb.Append("<br />");
            lblResults.Text = sb.ToString();

            reader.Close();
        }
        catch (Exception err)
        {
            lblResults.Text = "Error getting author. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

    }
}
