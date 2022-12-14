using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class First : EmployeeData
    {
        public void FirstMethod()
        {
            Console.WriteLine("-> First Operator <-");
            Console.WriteLine();

            var employeeAtFirstIndex = employeeList.First();

            Console.WriteLine("The employee details at index 2 is -");
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

            var firstEmployeeWithEvenAge = employeeList.First(emp => emp.Age % 2 == 0);

            Console.WriteLine("The details of first employee with even age -");
            Console.WriteLine("Employee Id - " + firstEmployeeWithEvenAge.EmployeeId);
            Console.WriteLine("Employee Name - " + firstEmployeeWithEvenAge.Name);
            Console.WriteLine("Employee Department - " + firstEmployeeWithEvenAge.DepartmentId);
            Console.WriteLine("Employee Age - " + firstEmployeeWithEvenAge.Age);
            Console.Write("Employee Skills - ");
            foreach (var skill in firstEmployeeWithEvenAge.skills)
            {
                Console.Write(skill + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
