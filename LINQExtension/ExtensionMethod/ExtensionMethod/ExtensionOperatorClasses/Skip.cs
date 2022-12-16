using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class Skip : EmployeeData
    {
        public void SkipMethod()
        {
            Console.WriteLine("-> Skip Operator <-");
            Console.WriteLine();

            var newEmployeeList = employeeList.Skip(2);

            foreach (var item in newEmployeeList)
            {
                Console.WriteLine("Employee id : " + item.EmployeeId + " and Name : " + item.Name);
            }

            Console.WriteLine();
        }
    }
}
