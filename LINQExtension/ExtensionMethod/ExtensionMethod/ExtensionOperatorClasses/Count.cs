using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class Count : EmployeeData
    {
        public void CountMethod()
        {
            Console.WriteLine("-> Count Operator <-");
            Console.WriteLine();

            var adultEmployee = employeeList.Count(emp => emp.Age >= 18);

            Console.WriteLine("The number of adult employees is - {0}", adultEmployee);

            Console.WriteLine();
        }
    }
}
