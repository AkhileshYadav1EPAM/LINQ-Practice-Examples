using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class ThenByDescending : EmployeeData
    {
        public void ThenByDescendingMethod()
        {
            Console.WriteLine("-> ThenByDescending Operator Sorting After DeaprtmentId <-");
            

            var resultThenByDescending = employeeList.OrderBy(emp => emp.DepartmentId).ThenByDescending(emp => emp.Name);

            foreach (var item in resultThenByDescending)
            {
                Console.WriteLine(" " + item.Name);
            }

            Console.WriteLine();
        }
    }
}
