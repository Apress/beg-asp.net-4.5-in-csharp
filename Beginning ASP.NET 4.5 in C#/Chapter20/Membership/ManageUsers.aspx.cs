using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.ComponentModel;

public partial class ManageUsers : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        gridUsers.DataSource = Membership.GetAllUsers();
        gridUsers.DataBind();
    }
    protected void gridUsers_SelectedIndexChanged(object sender, EventArgs e)
    {
        List<MembershipUser> list = new List<MembershipUser>();
        list.Add(Membership.GetUser(gridUsers.SelectedValue.ToString()));
        detailsUser.DataSource = list;
        detailsUser.DataBind();
    }

    protected void cmdCreateTestUsers_Click(object sender, EventArgs e)
    {
        MembershipCreateStatus createStatus;
        Membership.CreateUser("joes", "ignreto12__", "joes@domains.com", "How many menus are in tibet?", "16", true, out createStatus);
        Membership.CreateUser("sallyr", "ignreto12__", "sally@domains.com", "How many menus are in tibet?", "16", true, out createStatus);
        Membership.CreateUser("user014", "ignreto12__", "user014@home.ca", "How many menus are in tibet?", "16", true, out createStatus);
        Membership.CreateUser("hmac_r", "ignreto12__", "", "How many menus are in tibet?", "16", true, out createStatus);
        Membership.CreateUser("liu_liu", "ignreto12__", "liu@company.com", "How many menus are in tibet?", "16", true, out createStatus);

        // Rebind.
        gridUsers.DataSource = Membership.GetAllUsers();
        gridUsers.DataBind();
    }
}
