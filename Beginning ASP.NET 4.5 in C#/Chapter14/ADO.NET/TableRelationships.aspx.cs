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
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class TableRelationships : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            CreateList();
        }
    }

    private string connectionString =
  WebConfigurationManager.ConnectionStrings["Pubs"].ConnectionString;


    private void CreateList()
    {
        // Define ADO.NET objects.
        string selectSQL = "SELECT au_lname, au_fname, au_id FROM Authors";
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand(selectSQL, con);
        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        DataSet dsPubs = new DataSet();

        try
        {
            con.Open();
            adapter.Fill(dsPubs, "Authors");

            // This command is still linked to the data adapter.
            cmd.CommandText = "SELECT au_id, title_id FROM TitleAuthor";
            adapter.Fill(dsPubs, "TitleAuthor");

            // This command is still linked to the data adapter.
            cmd.CommandText = "SELECT title_id, title FROM Titles";
            adapter.Fill(dsPubs, "Titles");
        }
        catch (Exception err)
        {
            lblList.Text = "Error reading list of names. ";
            lblList.Text += err.Message;
        }
        finally
        {
            con.Close();
        }

        DataRelation Titles_TitleAuthor = new DataRelation("Titles_TitleAuthor",
            dsPubs.Tables["Titles"].Columns["title_id"],
            dsPubs.Tables["TitleAuthor"].Columns["title_id"]);
        DataRelation Authors_TitleAuthor = new DataRelation("Authors_TitleAuthor",
            dsPubs.Tables["Authors"].Columns["au_id"],
            dsPubs.Tables["TitleAuthor"].Columns["au_id"]);
        dsPubs.Relations.Add(Titles_TitleAuthor);
        dsPubs.Relations.Add(Authors_TitleAuthor);

        foreach (DataRow rowAuthor in dsPubs.Tables["Authors"].Rows)
        {
            lblList.Text += "<br /><b>" + rowAuthor["au_fname"];
            lblList.Text += " " + rowAuthor["au_lname"] + "</b><br />";

            foreach (DataRow rowTitleAuthor in
                rowAuthor.GetChildRows(Authors_TitleAuthor))
            {
                DataRow rowTitle =
                    rowTitleAuthor.GetParentRows(Titles_TitleAuthor)[0];
                lblList.Text += "&nbsp;&nbsp;";
                lblList.Text += rowTitle["title"] + "<br />";
            }
        }
    }
}