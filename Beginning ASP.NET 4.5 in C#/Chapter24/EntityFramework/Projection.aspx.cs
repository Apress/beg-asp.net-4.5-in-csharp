using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Collections.Generic;

public partial class Projection : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Get the full collection of employees from a helper method.
        List<Employee> employees = Employee.GetEmployees();

        // Anonymous type.
        var matches = from employee in employees
                  select new {First = employee.FirstName, Last = employee.LastName};

        gridEmployees.DataSource = matches;
        gridEmployees.DataBind();
    }
}
