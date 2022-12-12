using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class ThenBy : EmployeeData
    {
        public void ThenByMethod()
        {
            Console.WriteLine("-> ThenBy Operator Sorting After DeaprtmentId <-");
            Console.WriteLine();

            //var resultThenBy = employeeList.OrderBy(emp => emp.DepartmentId).ThenBy(emp => emp.Name);
            var resultThenBy = employeeList.OrderBy(emp => emp.DepartmentId).ThenBy(emp => emp.Name);

            foreach (var item in resultThenBy)
            {
                Console.WriteLine(" " + item.Name);
            }

            Console.WriteLine();
        }
    }
}
