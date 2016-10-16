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

public partial class ConnectionTester : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void cmdConnect_Click(object sender, EventArgs e)
    {
        // Define the connection string.
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Pubs;";

        if (optWindows.Checked)
        {
            connectionString += "Integrated Security=SSPI";
        }
        else
        {
            connectionString += "User ID=sa";
        }
        // Define the ADO.NET Connection object.
        SqlConnection myConnection = new SqlConnection(connectionString);

        try
        {
            // Try to open the connection.
            myConnection.Open();
            lblInfo.Text = "<b>Server Version:</b> " + myConnection.ServerVersion;
            lblInfo.Text += "<br /><b>Connection Is:</b> " + myConnection.State.ToString();
        }
        catch (Exception err)
        {
            // Handle an error by displaying the information.
            lblInfo.Text = "Error reading the database. ";
            lblInfo.Text += err.Message;
        }
        finally
        {
            // Either way, make sure the connection is properly closed.
            // (Even if the connection wasn't opened successfully,
            //  calling Close() won't cause an error.)
            myConnection.Close();
            lblInfo.Text += "<br /><b>Now Connection Is:</b> ";
            lblInfo.Text += myConnection.State.ToString();
        }
    }
}
