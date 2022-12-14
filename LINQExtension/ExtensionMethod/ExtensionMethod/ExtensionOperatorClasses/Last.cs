using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class Last : EmployeeData
    {
        public void LastMethod()
        {
            Console.WriteLine("-> Last Operator <-");
            Console.WriteLine();

            var employeeAtFirstIndex = employeeList.Last();

            Console.WriteLine("The employee details at the last index is -");
            Console.WriteLine("Employee Id - " + employeeAtFirstIndex.EmployeeId);
            Console.WriteLine("Employee Name - " + employeeAtFirstIndex.Name);
            Console.WriteLine("Employee Department - " + employeeAtFirstIndex.DepartmentId);
            Console.WriteLine("Employee Age - " + employeeAtFirstIndex.Age);
            Console.Write("Employee Skills - ");
            foreach (var skill in employeeAtFirstIndex.skills)
            {
                Console.Write(skill + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();

            var lastEmployeeWithOddAge = employeeList.Last(emp => emp.Age % 2 == 1);

            Console.WriteLine("The details of last employee with odd age -");
            Console.WriteLine("Employee Id - " + lastEmployeeWithOddAge.EmployeeId);
            Console.WriteLine("Employee Name - " + lastEmployeeWithOddAge.Name);
            Console.WriteLine("Employee Department - " + lastEmployeeWithOddAge.DepartmentId);
            Console.WriteLine("Employee Age - " + lastEmployeeWithOddAge.Age);
            Console.Write("Employee Skills - ");
            foreach (var skill in lastEmployeeWithOddAge.skills)
            {
                Console.Write(skill + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
