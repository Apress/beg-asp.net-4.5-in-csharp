using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class NameTextBox : TextBox
{
    private string firstName;
    private string lastName;

    public string GetFirstName()
    {
        UpdateNames();
        return firstName;
    }

    public string GetLastName()
    {
        UpdateNames();
        return lastName;
    }

    private void UpdateNames()
    {
        int commaPos = this.Text.IndexOf(',');
        int spacePos = this.Text.IndexOf(' ');

        string[] nameArray;
        if (commaPos != -1)
        {
            nameArray = this.Text.Split(',');
            firstName = nameArray[1];
            lastName = nameArray[0];
        }
        else if (spacePos != -1)
        {
            nameArray = this.Text.Split(' ');
            firstName = nameArray[0];
            lastName = nameArray[1];
        }
        else
        {
            // The text has no comma or space.
            // It cannot be converted to a name.
            throw new InvalidOperationException();
        }
    }
}
