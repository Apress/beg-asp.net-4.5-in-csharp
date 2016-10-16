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

public partial class RegularExpressionTest : System.Web.UI.Page
{

	protected void cmdSetExpression_Click(object sender, EventArgs e)
	{
		TestValidator.ValidationExpression = txtExpression.Text;
		lblExpression.Text = "Current Expression: ";
		lblExpression.Text += txtExpression.Text;

	}
}
