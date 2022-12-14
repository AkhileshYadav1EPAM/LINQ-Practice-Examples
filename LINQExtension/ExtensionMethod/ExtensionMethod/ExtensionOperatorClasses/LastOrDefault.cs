using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class LastOrDefault : EmployeeData
    {
        public void LastOrDefaultMethod()
        {
            Console.WriteLine("-> LastOrDefault Operator <-");
            Console.WriteLine();

            try
            {
                var employeeAtLastIndex = employeeList.LastOrDefault();

                if (employeeAtLastIndex != null)
                {
                    Console.WriteLine("The employee details at last index is -");
                    Console.WriteLine("Employee Id - " + employeeAtLastIndex.EmployeeId);
                    Console.WriteLine("Employee Name - " + employeeAtLastIndex.Name);
                    Console.WriteLine("Employee Department - " + employeeAtLastIndex.DepartmentId);
                    Console.WriteLine("Employee Age - " + employeeAtLastIndex.Age);
                    Console.Write("Employee Skills - ");
                    foreach (var skill in employeeAtLastIndex.skills)
                    {
                        Console.Write(skill + ", ");
                    }
                }
                else
                {
                    throw (new IndexOutOfRangeException());
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine();

            try
            {
                var lastEmployeeWithAgeMoreThan30 = employeeList.LastOrDefault(emp => emp.Age > 30);
                Console.WriteLine("The employee details whose age is greater than 30 is -");

                if (lastEmployeeWithAgeMoreThan30 != null)
                {
                    Console.WriteLine("Employee Id - " + lastEmployeeWithAgeMoreThan30.EmployeeId);
                    Console.WriteLine("Employee Name - " + lastEmployeeWithAgeMoreThan30.Name);
                    Console.WriteLine("Employee Department - " + lastEmployeeWithAgeMoreThan30.DepartmentId);
                    Console.WriteLine("Employee Age - " + lastEmployeeWithAgeMoreThan30.Age);
                    Console.Write("Employee Skills - ");
                    foreach (var skill in lastEmployeeWithAgeMoreThan30.skills)
                    {
                        Console.Write(skill + ", ");
                    }
                }
                else
                {
                    throw (new Exception());
                }
            }
            catch (Exception noSuchEmployee)
            {
                Console.WriteLine("No such employee.");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
