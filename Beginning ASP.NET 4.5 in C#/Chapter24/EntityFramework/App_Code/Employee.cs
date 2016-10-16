using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Employee
/// </summary>
public class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TitleOfCourtesy { get; set; }

    public Employee(int employeeID, string firstName, string lastName, string titleOfCourtesy)
    {
        EmployeeID = employeeID;
        FirstName = firstName;
        LastName = lastName;
        TitleOfCourtesy = titleOfCourtesy;
    }

    public static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee(1, "Nancy", "Davolio", "Ms."));
        employees.Add(new Employee(2, "Andrew", "Fuller", "Dr."));
        employees.Add(new Employee(3, "Janet", "Leverling", "Ms."));
        employees.Add(new Employee(4, "Margaret", "Peacock", "Mrs."));
        employees.Add(new Employee(5, "Steven", "Buchanan", "Mr."));
        employees.Add(new Employee(6, "Michael", "Suyama", "Mr."));
        employees.Add(new Employee(7, "Robert", "King", "Mr."));
        employees.Add(new Employee(8, "Laura", "Callahan", "Ms."));
        employees.Add(new Employee(9, "Anne", "Dodsworth", "Ms."));
        return employees;
    }
}