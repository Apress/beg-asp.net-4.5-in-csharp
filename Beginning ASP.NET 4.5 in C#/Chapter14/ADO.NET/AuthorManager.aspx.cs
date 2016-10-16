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

public partial class AuthorManager : System.Web.UI.Page
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
            lblResults.Text = "Error reading list of names.";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }
    }

    protected void lstAuthor_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Define ADO.NET objects.
        string selectSQL;
        selectSQL = "SELECT * FROM Authors ";
        selectSQL += "WHERE au_id='" + lstAuthor.SelectedItem.Value + "'";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataReader reader;

        // Try to open database and read information.
        try
        {
            con.Open();
            reader = cmd.ExecuteReader();
            reader.Read();

            // Fill the controls.
            txtID.Text = reader["au_id"].ToString();
            txtFirstName.Text = reader["au_fname"].ToString();
            txtLastName.Text = reader["au_lname"].ToString();
            txtPhone.Text = reader["phone"].ToString();
            txtAddress.Text = reader["address"].ToString();
            txtCity.Text = reader["city"].ToString();
            txtState.Text = reader["state"].ToString();
            txtZip.Text = reader["zip"].ToString();
            chkContract.Checked = (bool)reader["contract"];
            reader.Close();
            lblResults.Text = "";
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
    protected void cmdNew_Click(object sender, EventArgs e)
    {
        txtID.Text = "";
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtPhone.Text = "";
        txtAddress.Text = "";
        txtCity.Text = "";
        txtState.Text = "";
        txtZip.Text = "";
        chkContract.Checked = false;
        
        lblResults.Text = "Click Insert New to add the completed record.";


    }
    protected void cmdInsert_Click(object sender, EventArgs e)
    {
        // Perform user-defined checks.
        if (txtID.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "")
        {
            lblResults.Text = "Records require an ID, first name, and last name.";
            return;
        }

        // Define ADO.NET objects.
        string insertSQL;
        insertSQL = "INSERT INTO Authors (";
        insertSQL += "au_id, au_fname, au_lname, ";
        insertSQL += "phone, address, city, state, zip, contract) ";
        insertSQL += "VALUES (";
        insertSQL += "@au_id, @au_fname, @au_lname, ";
        insertSQL += "@phone, @address, @city, @state, @zip, @contract)";

        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(insertSQL, con);

        // Add the parameters.
        cmd.Parameters.AddWithValue("@au_id", txtID.Text);
        cmd.Parameters.AddWithValue("@au_fname", txtFirstName.Text);
        cmd.Parameters.AddWithValue("@au_Lname", txtLastName.Text);
        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
        cmd.Parameters.AddWithValue("@city", txtCity.Text);
        cmd.Parameters.AddWithValue("@state", txtState.Text);
        cmd.Parameters.AddWithValue("@zip", txtZip.Text);
        cmd.Parameters.AddWithValue("@contract", chkContract.Checked);

        // Try to open the database and execute the update.
        int added = 0;
        try
        {
            con.Open();
            added = cmd.ExecuteNonQuery();
            lblResults.Text = added.ToString() + " record inserted.";
        }
        catch (Exception err)
        {
            lblResults.Text = "Error inserting record. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

        // If the insert succeeded, refresh the author list.
        if (added > 0)
        {
            FillAuthorList();
        }
    }

    protected void cmdUpdate_Click(object sender, EventArgs e)
    {
        // Define ADO.NET objects.
        string updateSQL;
        updateSQL = "UPDATE Authors SET ";
        updateSQL += "au_fname=@au_fname, au_lname=@au_lname, ";
        updateSQL += "phone=@phone, address=@address, city=@city, state=@state, ";
        updateSQL += "zip=@zip, contract=@contract ";
        updateSQL += "WHERE au_id=@au_id_original";

        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(updateSQL, con);

        // Add the parameters.        
        cmd.Parameters.AddWithValue("@au_fname", txtFirstName.Text);
        cmd.Parameters.AddWithValue("@au_Lname", txtLastName.Text);
        cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
        cmd.Parameters.AddWithValue("@address", txtAddress.Text);
        cmd.Parameters.AddWithValue("@city", txtCity.Text);
        cmd.Parameters.AddWithValue("@state", txtState.Text);
        cmd.Parameters.AddWithValue("@zip", txtZip.Text);
        cmd.Parameters.AddWithValue("@contract", chkContract.Checked);
        cmd.Parameters.AddWithValue("@au_id_original", lstAuthor.SelectedItem.Value);

        // Try to open database and execute the update.
        int updated = 0;
        try
        {
            con.Open();
            updated = cmd.ExecuteNonQuery();
            lblResults.Text = updated.ToString() + " record updated.";
        }
        catch (Exception err)
        {
            lblResults.Text = "Error updating author. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

        // If the updated succeeded, refresh the author list.
        if (updated > 0)
        {
            FillAuthorList();
        }

    }
    protected void cmdDelete_Click(object sender, EventArgs e)
    {
        // Define ADO.NET objects.
        string deleteSQL;
        deleteSQL = "DELETE FROM Authors ";
        deleteSQL += "WHERE au_id=@au_id";

        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(deleteSQL, con);
        cmd.Parameters.AddWithValue("@au_id ", lstAuthor.SelectedItem.Value);

        // Try to open the database and delete the record.
        int deleted = 0;
        try
        {
            con.Open();
            deleted = cmd.ExecuteNonQuery();
            lblResults.Text = "Record deleted.";
        }
        catch (Exception err)
        {
            lblResults.Text = "Error deleting author. ";
            lblResults.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

        // If the delete succeeded, refresh the author list.
        if (deleted > 0)
        {
            FillAuthorList();
        }

    }
}
