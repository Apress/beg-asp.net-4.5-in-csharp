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

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Roles.RoleExists("User"))
        {
            Roles.CreateRole("User");
        }
    }

    protected void CreateUserWizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
    {
        Label lbl = (Label)CreateUserWizard1.CompleteStep.Controls[0].FindControl("lblSubscriptionList");
        CheckBoxList chk = (CheckBoxList)CreateUserWizard1.FindControl("chkSubscription");
        
        string selection = "";
        foreach (ListItem item in chk.Items)
        {
            if (item.Selected) selection += "<br />&nbsp;&nbsp;" + item.Text;
        }
        lbl.Text = selection;
    }

    protected void CreateUserWizard1_CreatedUser(object sender, EventArgs e)
    {
        Roles.AddUserToRole(CreateUserWizard1.UserName, "User");
    }
}
