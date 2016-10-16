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

public partial class GraphicalText : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Create an in-memory bitmap where you will draw the image. 
        // The Bitmap is 300 pixels wide and 50 pixels high.
        Bitmap image = new Bitmap(350, 50);

        // Get the graphics context for the bitmap.
        Graphics g = Graphics.FromImage(image);

        // Draw a solid yellow rectangle with a red border.
        g.FillRectangle(Brushes.LightYellow, 0, 0, 350, 50);
        g.DrawRectangle(Pens.Red, 0, 0, 349, 49);

        // Draw some text using a fancy font.
        Font font = new Font("Ravie", 20, FontStyle.Regular);
        g.DrawString("This is a test.", font, Brushes.Blue, 10, 5);

        // Copy a smaller gif into the image from a file.
        System.Drawing.Image icon = System.Drawing.Image.FromFile(Server.MapPath("smiley.gif"));
        g.DrawImageUnscaled(icon, 290, 0);

        // Render the entire bitmap to the HTML output stream.
        Response.ContentType = "image/gif";
        image.Save(Response.OutputStream,
          System.Drawing.Imaging.ImageFormat.Gif);
                        
        // Clean up.
        g.Dispose();
        image.Dispose();

    }
}
