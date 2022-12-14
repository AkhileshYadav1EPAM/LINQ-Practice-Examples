using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class Average : EmployeeData
    {
        public void AverageMethod()
        {
            Console.WriteLine("-> Average Operator <-");
            Console.WriteLine();

            var averageAgeOfEmployee = employeeList.Average(emp => emp.Age);

            Console.WriteLine("The average age of employees is - {0}", averageAgeOfEmployee);

            Console.WriteLine();
        }
    }
}
