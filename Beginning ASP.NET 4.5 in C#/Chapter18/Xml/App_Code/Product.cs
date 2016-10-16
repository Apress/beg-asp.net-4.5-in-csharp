using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    public int ID {get; set;}
    public string Name {get; set;}
    public decimal Price {get; set;}
}