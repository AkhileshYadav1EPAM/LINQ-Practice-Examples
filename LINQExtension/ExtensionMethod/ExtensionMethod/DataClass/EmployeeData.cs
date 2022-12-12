using ExtensionMethod.DefinitionClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.DataClass
{
    public class EmployeeData
    {
        public List<Employee> employeeList = new List<Employee>()
        {
            new Employee() {Age = 23, EmployeeId =1001, Name="Suraj", DepartmentId=103,skills = new List<string> { ".Net", "MVC", "Agular"}},
            new Employee() {Age = 13, EmployeeId =1002, Name="Nikku", DepartmentId=101,skills = new List<string> { ".Net", "Java", "JQuery"}},
            new Employee() {Age = 17, EmployeeId =1003, Name="Jhanvi",DepartmentId=101,skills = new List<string> { ".Net", "SQL", "API"}},
            new Employee() {Age = 21, EmployeeId =1004, Name="Shivashree", DepartmentId=102,skills = new List<string> { ".Net", "MVC", "Agular"}},
            new Employee() {Age = 19, EmployeeId =1005, Name="Gaurav", DepartmentId=102,skills = new List<string> { ".Net", "Python", "Linq"}},
            new Employee() {Age = 22, EmployeeId =1006, Name="Akhilesh", DepartmentId=103,skills = new List<string> { ".Net", "MVC", "Agular"}}
        };
    }
}
