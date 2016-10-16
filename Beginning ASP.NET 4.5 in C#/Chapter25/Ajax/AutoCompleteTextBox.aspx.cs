using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Configuration;

public partial class AutoCompleteTextBox : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [System.Web.Services.WebMethod]
    [System.Web.Script.Services.ScriptMethod]
    public static List<string> GetNames(string prefixText, int count)
    {
        List<string> names = null;

        // Check if the list is in the cache.
        if (HttpContext.Current.Cache["NameList"] == null)
        {
            // If not, regenerate the list. The ADO.NET code for this part
            // isn't shown (but you can see it in the downloadable examples
            // for this chapter.
            names = GetNameListFromDB();

            // Store the name list in the cache for sixty minutes.
            HttpContext.Current.Cache.Insert("NameList", names, null,
              DateTime.Now.AddMinutes(60), TimeSpan.Zero);
        }
        else
        {
            // Get the name list out of the cache.
            names = (List<string>)HttpContext.Current.Cache["NameList"];
        }

        int index = -1;
        for (int i = 0; i < names.Count; i++)
        {
            // Check if this is a suitable match.
            if (names[i].StartsWith(prefixText, StringComparison.InvariantCultureIgnoreCase))
            {
                index = i;
                break;
            }
        }

        // Give up if there isn't a match.
        if (index == -1) return new List<string>();

        List<string> wordList = new List<string>();
        for (int i = index; i < (index + count); i++)
        {
            // Stop if the end of the list is reached.
            if (i >= names.Count) break;

            // Stop if the names stop matching.
            if (!names[i].StartsWith(prefixText, StringComparison.InvariantCultureIgnoreCase)) break;

            wordList.Add(names[i]);
        }

        return wordList;
    }

    private static List<string> GetNameListFromDB()
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd = new SqlCommand("SELECT ContactName FROM Customers ORDER BY ContactName", con);

        List<string> names = new List<string>();

        try
        {
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                names.Add((string)reader["ContactName"]);
            }
            reader.Close();

            return names;
        }        
        finally
        {
            con.Close();
        }
    }
}
