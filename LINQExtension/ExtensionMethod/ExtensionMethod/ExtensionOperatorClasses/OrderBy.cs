using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class OrderBy : EmployeeData
    {
        public void OrderByMethod()
        {
            Console.WriteLine("-> orderby operator <-");
            Console.WriteLine();

            //var groupByResult = from emp in employeeList orderby emp by emp.DepartmentId;
            var groupByResult = employeeList.OrderBy(emp => emp.DepartmentId);

            foreach (var deptgroup in groupByResult)
            {
                Console.WriteLine(deptgroup.DepartmentId + " - " + deptgroup.Name);
            }

            Console.WriteLine();
        }
    }
}
