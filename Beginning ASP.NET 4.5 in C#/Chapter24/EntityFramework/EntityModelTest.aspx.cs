using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NorthwindModel;

public partial class EntityModelTest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {        
        NorthwindEntities entities = new NorthwindEntities();
        GridView1.DataSource = entities.Products;

        // If the database isn't accesible, an exception occurs here (on the next line).
        GridView1.DataBind();
    }
    
}