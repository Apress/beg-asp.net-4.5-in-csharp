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
using System.Drawing;

public partial class GraphicalText2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the user name.
        if (Request.QueryString["Name"] == null)
        {
            // No name was supplied.
            // Don't display anything.
        }
        else
        {
            string name = Request.QueryString["Name"];

            // Create an in-memory bitmap where you will draw the image. 
            Bitmap image = new Bitmap(300, 50);

            // Get the graphics context for the bitmap.
            Graphics g = Graphics.FromImage(image);

            g.FillRectangle(Brushes.LightYellow, 0, 0, 300, 50);
            g.DrawRectangle(Pens.Red, 0, 0, 299, 49);

            // Draw some text based on the query string.
            Font font = new Font("Ravie", 25, FontStyle.Regular);
            g.DrawString(name, font, Brushes.Blue, 10, 0);

            // Render the entire bitmap to the HTML output stream.
            Response.ContentType = "image/gif";
            image.Save(Response.OutputStream,
              System.Drawing.Imaging.ImageFormat.Gif);

            g.Dispose();
            image.Dispose();
        }

    }
}
