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
using System.Collections.Generic;
using System.Linq;

public partial class IterativeVsDeclarative : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void cmdForeach_Click(object sender, EventArgs e)
    {
        // Get the full collection of employees from a helper method.
        List<Employee> employees = Employee.GetEmployees();

        // Find the matching employees.
        List<Employee> matches = new List<Employee>();
        foreach (Employee employee in employees)
        {
            if (employee.LastName.StartsWith("D"))
            {
                matches.Add(employee);
            }
        }

        gridEmployees.DataSource = matches;
        gridEmployees.DataBind();
    }

    protected void cmdLinq_Click(object sender, EventArgs e)
    {
        // Get the full collection of employees from a helper method.
        List<Employee> employees = Employee.GetEmployees();
        
        var matches = from employee in employees
                  where employee.LastName.StartsWith("D")
                  select employee;

        gridEmployees.DataSource = matches;
        gridEmployees.DataBind();
    }

}
