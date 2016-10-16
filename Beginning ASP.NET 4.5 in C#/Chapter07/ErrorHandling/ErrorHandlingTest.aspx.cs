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

public partial class ErrorHandlingTest : System.Web.UI.Page
{

    protected void cmdCompute_Click(object sender, EventArgs e)
    {
        try
        {
            decimal a, b, result;
            a = Decimal.Parse(txtA.Text);
            b = Decimal.Parse(txtB.Text);
            result = a / b;

            //Alternate approach:
            //result = DivideNumbers(a, b);

            lblResult.Text = result.ToString();
            lblResult.ForeColor = Color.Black;
        }
        catch (Exception err)
        {
            lblResult.Text = "<b>Message:</b> " + err.Message;
            lblResult.Text += "<br /><br />";
            lblResult.Text += "<b>Source:</b> " + err.Source;
            lblResult.Text += "<br /><br />";
            lblResult.Text += "<b>Stack Trace:</b> " + err.StackTrace;
            lblResult.ForeColor = Color.Red;
        }

    }

    private decimal DivideNumbers(decimal number, decimal divisor)
    {
        if (divisor == 0)
        {
            DivideByZeroException err = new DivideByZeroException(
              "You supplied 0 for the divisor parameter. You must be stopped.");
            throw err;
        }
        else
        {
            return number / divisor;
        }
    }

}
