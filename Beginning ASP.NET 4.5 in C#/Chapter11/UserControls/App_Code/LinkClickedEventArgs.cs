using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public class LinkClickedEventArgs : EventArgs
{
    public string Url { get; set; }
    public bool Cancel { get; set; }

    public LinkClickedEventArgs(string url)
    {
        Url = url;
    }
}


