using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class GroupBy : EmployeeData
    {
        public void GroupByMethod()
        {
            Console.WriteLine("-> GroupBy Operator <-");
            Console.WriteLine();

            //var resultGroupBy = from emp in employeeList group emp by emp.DepartmentId;
            var resultGroupBy = employeeList.GroupBy(emp => emp.DepartmentId);

            foreach(var department in resultGroupBy)
            {
                Console.WriteLine("Department Id group - {0}" , department.Key);

                foreach(var emp in department)
                {
                    Console.WriteLine("Employee name - {0}", emp.Name);
                }
            }

            Console.WriteLine();
        }
    }
}
