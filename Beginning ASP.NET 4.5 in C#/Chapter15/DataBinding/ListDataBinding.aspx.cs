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

public partial class ListDataBinding : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create and fill the collection.
        List<string> fruit = new List<string>();
        fruit.Add("Kiwi");
        fruit.Add("Pear");
        fruit.Add("Mango");
        fruit.Add("Blueberry");
        fruit.Add("Apricot");
        fruit.Add("Banana");
        fruit.Add("Peach");
        fruit.Add("Plum");

        // Define the binding for the list controls.
        MyListBox.DataSource = fruit;
        MyDropDownListBox.DataSource = fruit;
        MyHTMLSelect.DataSource = fruit;
        MyCheckBoxList.DataSource = fruit;
        MyRadioButtonList.DataSource = fruit;

        // Activate the binding.
        this.DataBind();
    }
}
