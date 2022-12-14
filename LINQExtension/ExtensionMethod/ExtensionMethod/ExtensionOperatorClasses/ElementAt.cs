using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class ElementAt : EmployeeData
    {
        public void ElementAtMethod()
        {
            Console.WriteLine("-> ElementAt Operator <-");
            Console.WriteLine();

            var employeeAtIndex = employeeList.ElementAt(2);

            Console.WriteLine("The employee details at index 2 is -");
            Console.WriteLine("Employee Id - " + employeeAtIndex.EmployeeId);
            Console.WriteLine("Employee Name - " + employeeAtIndex.Name);
            Console.WriteLine("Employee Department - " + employeeAtIndex.DepartmentId);
            Console.WriteLine("Employee Age - " + employeeAtIndex.Age);
            Console.Write("Employee Skills - ");
            foreach(var skill in employeeAtIndex.skills)
            {
                Console.Write(skill + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
