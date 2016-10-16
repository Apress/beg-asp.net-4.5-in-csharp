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

public partial class CustomerForm : System.Web.UI.Page
{
	protected void cmdSubmit_Click(object sender, EventArgs e)
	{
        if (Page.IsValid)
        {
            lblMessage.Text = "This is a valid form.";
        }
	}
	protected void cmdCancel_Click(object sender, EventArgs e)
	{
		lblMessage.Text = "No attempt was made to validate this form.";
	}
	protected void vldCode_ServerValidate(object source, ServerValidateEventArgs e)
	{
		try
		{
			// Check if the first three digits are divisible by seven.
			int val = Int32.Parse(e.Value.Substring(0, 3));
			if (val % 7 == 0)
			{
				e.IsValid = true;
			}
			else
			{
				e.IsValid = false;
			}
		}
		catch
		{
			// An error occured in the conversion.
			// The value is not valid.
			e.IsValid = false;
		}
	}
}
