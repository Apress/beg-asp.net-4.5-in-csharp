using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestPage : System.Web.UI.Page
{

    protected void Button1_Click(object sender, EventArgs e)
    {
        double val;

        // Attempt to convert the text to a number, and only
        // continue if it is a valid number.
        if (Double.TryParse(TextBox1.Text, out val))
        {
            val *= 2;
            Label1.Text = "The doubled number is: " + val.ToString();
        }
    }
}


