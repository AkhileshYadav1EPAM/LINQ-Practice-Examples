using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethod.DataClass;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class Select : EmployeeData
    {
        public void SelectMethod()
        {
            Console.WriteLine("|-> select operator <-|");
            Console.WriteLine();

            /*var selectResult = from emp in employeeList select emp;*/

            var selectResult = employeeList.Select(s => new { EmployeeId = s.EmployeeId, Name = s.Name });

            foreach (var item in selectResult)
            {
                Console.WriteLine("Employee id : " + item.EmployeeId + " and Name : " + item.Name);
            }

            Console.WriteLine();
        }
        
    }
}
