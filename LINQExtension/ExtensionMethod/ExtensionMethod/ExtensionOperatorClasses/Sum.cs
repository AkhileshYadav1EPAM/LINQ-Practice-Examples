using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class Sum : EmployeeData
    {
        public void SumMethod()
        {
            Console.WriteLine("-> Sum Operator <-");
            Console.WriteLine();

            var sumOfEmployeeAge = employeeList.Sum(emp => emp.Age);

            Console.WriteLine("The sum of age of all employee is - {0}", sumOfEmployeeAge);

            Console.WriteLine();
        }
    }
}
