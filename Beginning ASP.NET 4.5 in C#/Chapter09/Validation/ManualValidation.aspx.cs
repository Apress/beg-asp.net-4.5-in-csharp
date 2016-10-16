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

public partial class ManualValidation : System.Web.UI.Page
{

	protected void cmdOK_Click(object sender, EventArgs e)
	{
		string errorMessage = "<b>Mistakes found:</b><br />";

		bool pageIsValid = true;
		// Search through the validation controls.
		foreach (BaseValidator ctrl in this.Validators)
		{
			if (!ctrl.IsValid)
			{
				pageIsValid = false;
				errorMessage += ctrl.ErrorMessage + "<br />";

				// Find the corresponding input control, and change the
				// generic Control variable into a TextBox variable.
				// This allows access to the Text property.
				TextBox ctrlInput = (TextBox)this.FindControl(ctrl.ControlToValidate);
				errorMessage += " * Problem is with this input: ";
				errorMessage += ctrlInput.Text + "<br />";
			}
		}
		if (!pageIsValid) lblMessage.Text = errorMessage;

	}
}
