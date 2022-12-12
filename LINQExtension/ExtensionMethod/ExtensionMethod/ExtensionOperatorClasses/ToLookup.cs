using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class ToLookup : EmployeeData
    {
        public void ToLookupMethod()
        {
            Console.WriteLine("-> ToLookUp Operator <-");
            Console.WriteLine();

            var resultGroupBy = employeeList.ToLookup(emp => emp.DepartmentId);

            foreach (var department in resultGroupBy)
            {
                Console.WriteLine("Department Id group - {0}", department.Key);

                foreach (var emp in department)
                {
                    Console.WriteLine("Employee name - {0}", emp.Name);
                }
            }

            Console.WriteLine();
        }
    }
}
