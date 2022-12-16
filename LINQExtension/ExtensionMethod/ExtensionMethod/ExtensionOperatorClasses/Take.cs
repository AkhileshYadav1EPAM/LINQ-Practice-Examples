using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class Take : EmployeeData
    {
        public void TakeMethod()
        {
            Console.WriteLine("-> Take Operator <-");
            Console.WriteLine();

            var newEmployeeList = employeeList.Take(2);

            foreach (var item in newEmployeeList)
            {
                Console.WriteLine("Employee id : " + item.EmployeeId + " and Name : " + item.Name);
            }

            Console.WriteLine();
        }
    }
}
