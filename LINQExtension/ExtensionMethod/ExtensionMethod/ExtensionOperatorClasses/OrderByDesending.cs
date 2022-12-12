using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class OrderByDesending : EmployeeData
    {
        public void OrderByDesendingMethod()
        {
            Console.WriteLine("-> orderbydescending operator <-");
            Console.WriteLine();

            var groupByResult = from emp in employeeList orderby emp.DepartmentId descending select emp ;
            //var groupByResult = employeeList.OrderByDescending(emp => emp.DepartmentId);

            foreach (var deptgroup in groupByResult)
            {
                Console.WriteLine(deptgroup.DepartmentId + " - " + deptgroup.Name);
            }

            Console.WriteLine();
        }
    }
}
