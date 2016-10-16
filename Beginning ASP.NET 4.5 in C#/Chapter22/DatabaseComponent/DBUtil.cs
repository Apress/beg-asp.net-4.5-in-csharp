using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace DatabaseComponent
{
    public class DBUtil
    {
        private string connectionString;

        public DBUtil()
        {
            connectionString =
              WebConfigurationManager.ConnectionStrings[
              "AdBoard"].ConnectionString;
        }

        public DataSet GetCategories()
        {
            string query = "SELECT * FROM Categories";
            SqlCommand cmd = new SqlCommand(query);
            return FillDataSet(cmd, "Categories");
        }

        public DataSet GetItems()
        {
            string query = "SELECT * FROM Items";
            SqlCommand cmd = new SqlCommand(query);
            return FillDataSet(cmd, "Items");
        }

        public DataSet GetItems(int categoryID)
        {
            // Create the Command.
            string query = "SELECT * FROM Items WHERE Category_ID=@CategoryID";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@CategoryID", categoryID);

            // Fill the DataSet.
            return FillDataSet(cmd, "Items");
        }

        public void AddCategory(string name)
        {
            SqlConnection con = new SqlConnection(connectionString);

            // Create the Command.
            string insertSQL = "INSERT INTO Categories ";
            insertSQL += "(Name) VALUES @Name";
            SqlCommand cmd = new SqlCommand(insertSQL, con);
            cmd.Parameters.AddWithValue("@Name", name);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        public void AddItem(string title, string description,
          decimal price, int categoryID)
        {
            SqlConnection con = new SqlConnection(connectionString);

            // Create the Command.
            string insertSQL = "INSERT INTO Items ";
            insertSQL += "(Title, Description, Price, Category_ID)";
            insertSQL += "VALUES (@Title, @Description, @Price, @CategoryID)";
            SqlCommand cmd = new SqlCommand(insertSQL, con);
            cmd.Parameters.AddWithValue("@Title", title);
            cmd.Parameters.AddWithValue("@Description", description);
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@CategoryID", categoryID);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con.Close();
            }
        }

        private DataSet FillDataSet(SqlCommand cmd, string tableName)
        {
            SqlConnection con = new SqlConnection(connectionString);
            cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            try
            {
                con.Open();
                adapter.Fill(ds, tableName);
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
    }

}
