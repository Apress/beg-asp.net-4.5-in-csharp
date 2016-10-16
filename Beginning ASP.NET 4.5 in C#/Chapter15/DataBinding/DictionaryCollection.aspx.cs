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
using System.Collections.Generic;

public partial class DictionaryCollection : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            Dictionary<int, string> fruit = new Dictionary<int, string>();
            fruit.Add(1, "Kiwi");
            fruit.Add(2, "Pear");
            fruit.Add(3, "Mango");
            fruit.Add(4, "Blueberry");
            fruit.Add(5, "Apricot");
            fruit.Add(6, "Banana");
            fruit.Add(7, "Peach");
            fruit.Add(8, "Plum");

            // Define the binding for the list controls.
            MyListBox.DataSource = fruit;
            MyListBox.DataTextField = "Value"; 
            MyListBox.DataValueField = "Key";
            // Activate the binding.
            this.DataBind();
        }

    }
    protected void MyListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblMessage.Text = "You picked: " + MyListBox.SelectedItem.Text;
        lblMessage.Text += " which has the key: " + MyListBox.SelectedItem.Value;

    }
}
