using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class SingleOperator : EmployeeData
    {
        public void SingleMethod()
        {
            Console.WriteLine("-> Single Operator <-");
            Console.WriteLine();

            var employeeWithAge17 = employeeList.Single(emp => emp.Age == 17);

            Console.WriteLine("The employee details whose age is 17 -");
            Console.WriteLine("Employee Id - " + employeeWithAge17.EmployeeId);
            Console.WriteLine("Employee Name - " + employeeWithAge17.Name);
            Console.WriteLine("Employee Department - " + employeeWithAge17.DepartmentId);
            Console.WriteLine("Employee Age - " + employeeWithAge17.Age);
            Console.Write("Employee Skills - ");
            foreach (var skill in employeeWithAge17.skills)
            {
                Console.Write(skill + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();

            try
            {
                var employeeWithDepartmentIdAs102 = employeeList.Single(emp => emp.DepartmentId == 102);
                

                if (employeeWithDepartmentIdAs102 != null)
                {
                    Console.WriteLine("The details of only employee with department Id as 102 is - ");
                    Console.WriteLine("Employee Id - " + employeeWithDepartmentIdAs102.EmployeeId);
                    Console.WriteLine("Employee Name - " + employeeWithDepartmentIdAs102.Name);
                    Console.WriteLine("Employee Department - " + employeeWithDepartmentIdAs102.DepartmentId);
                    Console.WriteLine("Employee Age - " + employeeWithDepartmentIdAs102.Age);
                    Console.Write("Employee Skills - ");
                    foreach (var skill in employeeWithDepartmentIdAs102.skills)
                    {
                        Console.Write(skill + ", ");
                    }
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
            catch(InvalidOperationException invalidOperationException)
            {
                Console.WriteLine("The details of only employee with department Id as 102 is - " + invalidOperationException.Message);
            }
            

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
