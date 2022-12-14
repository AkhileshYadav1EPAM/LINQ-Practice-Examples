using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class Max : EmployeeData
    {
        public void MaxMethod()
        {
            Console.WriteLine("-> Max Operator <-");
            Console.WriteLine();

            var oldestEmployeeAge = employeeList.Max(emp => emp.Age);

            Console.WriteLine("The age of oldest employee is - {0}", oldestEmployeeAge);

            Console.WriteLine();
        }
    }
}
