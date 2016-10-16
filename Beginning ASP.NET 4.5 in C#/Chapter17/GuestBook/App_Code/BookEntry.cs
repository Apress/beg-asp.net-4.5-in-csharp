using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


public class BookEntry
{
    private string author;
    private DateTime submitted;
    private string message;

    public string Author
    {
        get
        { return author; }
        set
        { author = value; }
    }

    public DateTime Submitted
    {
        get
        { return submitted; }
        set
        { submitted = value; }
    }

    public string Message
    {
        get
        { return message; }
        set
        { message = value; }
    }
}
