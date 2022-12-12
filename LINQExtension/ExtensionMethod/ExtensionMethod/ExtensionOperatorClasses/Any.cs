using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class Any : EmployeeData
    {
        public void AnyMethod()
        {
            Console.WriteLine("-> Any Operator <-");
            Console.WriteLine();

            bool isAnyEmployeeTeenager = employeeList.Any(emp => emp.Age >= 12 && emp.Age < 20);

            Console.WriteLine("Is any employee who is a teenager - {0}", isAnyEmployeeTeenager);

            Console.WriteLine();
        }
    }
}
