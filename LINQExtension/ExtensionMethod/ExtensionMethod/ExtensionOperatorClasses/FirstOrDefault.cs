using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class FirstOrDefault : EmployeeData
    {
        public void FirstOrDefaultMethod()
        {
            Console.WriteLine("-> FirstOrDefault Operator <-");
            Console.WriteLine();

            try
            {
                var employeeAtFirstIndex = employeeList.FirstOrDefault();

                if (employeeAtFirstIndex != null)
                {
                    Console.WriteLine("The employee details at index 0 is -");
                    Console.WriteLine("Employee Id - " + employeeAtFirstIndex.EmployeeId);
                    Console.WriteLine("Employee Name - " + employeeAtFirstIndex.Name);
                    Console.WriteLine("Employee Department - " + employeeAtFirstIndex.DepartmentId);
                    Console.WriteLine("Employee Age - " + employeeAtFirstIndex.Age);
                    Console.Write("Employee Skills - ");
                    foreach (var skill in employeeAtFirstIndex.skills)
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
                var firstEmployeeWithAgeMoreThan30 = employeeList.FirstOrDefault(emp => emp.Age > 30);
                Console.WriteLine("The employee details whose age is greater than 30 is -");

                if (firstEmployeeWithAgeMoreThan30 != null)
                {
                    Console.WriteLine("Employee Id - " + firstEmployeeWithAgeMoreThan30.EmployeeId);
                    Console.WriteLine("Employee Name - " + firstEmployeeWithAgeMoreThan30.Name);
                    Console.WriteLine("Employee Department - " + firstEmployeeWithAgeMoreThan30.DepartmentId);
                    Console.WriteLine("Employee Age - " + firstEmployeeWithAgeMoreThan30.Age);
                    Console.Write("Employee Skills - ");
                    foreach (var skill in firstEmployeeWithAgeMoreThan30.skills)
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
