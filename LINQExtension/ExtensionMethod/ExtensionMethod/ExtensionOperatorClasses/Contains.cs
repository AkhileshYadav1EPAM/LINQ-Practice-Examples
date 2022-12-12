using ExtensionMethod.DataClass;
using ExtensionMethod.DefinitionClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            if(x.Age == y.Age && x.EmployeeId == y.EmployeeId && x.Name == y.Name && x.DepartmentId == y.DepartmentId)
            {
                if(x.skills.SequenceEqual(y.skills))
                {
                    return true;
                }
            }

            return false;
        }

        public int GetHashCode(Employee obj)
        {
            return obj.GetHashCode();
        }
    }
    public class Contains : EmployeeData
    {
        public void ContainsMethod()
        {
            Console.WriteLine("-> Contains Operator <-");
            Console.WriteLine();

            Employee employee = new Employee() { Age = 23, EmployeeId = 1001, Name = "Suraj", DepartmentId = 103, skills = new List<string> { ".Net", "MVC", "Agular" } };

            bool resultContains = employeeList.Contains(employee, new EmployeeComparer());

            Console.WriteLine("Given employee exist - " + resultContains);

            Console.WriteLine();
        }
    }
}
