using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class All : EmployeeData
    {
        public void AllMethod()
        {
            Console.WriteLine("-> All Operator <-");
            Console.WriteLine();

            bool areAllEmployeeInEarly20s = employeeList.All(emp => emp.Age >= 20 && emp.Age < 25);

            Console.WriteLine("Are all the employee in early 20s - {0}", areAllEmployeeInEarly20s);

            Console.WriteLine();
        }
    }
}
