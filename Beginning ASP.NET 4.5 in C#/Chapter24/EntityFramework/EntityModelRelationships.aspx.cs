using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NorthwindModel;
using System.Text;

public partial class EntityModelRelationships : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        NorthwindEntities entities = new NorthwindEntities();

        // Build a string full of HTML markup.
        StringBuilder sb = new StringBuilder();
        foreach (Customer customer in entities.Customers.Include("Orders.Order_Details.Product"))
        {
            // Write out the customer information in bold.
            sb.Append("<b>");
            sb.Append(customer.CompanyName);
            sb.Append("</b><br />");

            // List this customer's orders.
            foreach (Order order in customer.Orders)
            {
                sb.Append(order.OrderID.ToString());
                sb.Append(" - made on date: ");
                sb.Append(order.OrderDate.Value.ToShortDateString());
                sb.Append("<br />");

                sb.Append("&nbsp;&nbsp;Products: ");
                sb.Append("<ul>");
                foreach (Order_Detail orderDetail in order.Order_Details)
                {
                    sb.Append("<li>" + orderDetail.Product.ProductName + "</li>");  
                }
                sb.Append("</ul><br />");
            }
            // Add a horizontal line.
            sb.Append("<hr /><br />");
        }

        // Show the HTML in a Label control.
        lblData.Text = sb.ToString();
    }
}