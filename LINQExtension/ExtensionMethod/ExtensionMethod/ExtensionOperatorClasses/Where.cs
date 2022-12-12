using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class Where : EmployeeData
    {
        public void WhereMethod()
        {
            Console.WriteLine("-> where operator <-");
            Console.WriteLine();
            /*var whereResult = from emp in employeeList
                              where emp.DepartmentId == 101
                              select new { emp.Name, emp.DepartmentId };*/

            var whereResult = employeeList.Where(emp => emp.DepartmentId == 101);

            foreach (var item in whereResult)
            {
                Console.WriteLine("Department : " + item.DepartmentId + " and Employee Name : " + item.Name);
            }

            Console.WriteLine();
        }
    }
}
