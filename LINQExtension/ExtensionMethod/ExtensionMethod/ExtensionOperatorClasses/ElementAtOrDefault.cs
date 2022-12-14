using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class ElementAtOrDefault : EmployeeData
    {
        public void ElementAtOrDefaultMethod()
        {
            Console.WriteLine("-> ElementAtOrDefault Operator <-");
            Console.WriteLine();

            try
            {
                var employeeAtIndex = employeeList.ElementAtOrDefault(0);

                if(employeeAtIndex != null)
                {
                    Console.WriteLine("The employee details at index 2 is -");
                    Console.WriteLine("Employee Id - " + employeeAtIndex.EmployeeId);
                    Console.WriteLine("Employee Name - " + employeeAtIndex.Name);
                    Console.WriteLine("Employee Department - " + employeeAtIndex.DepartmentId);
                    Console.WriteLine("Employee Age - " + employeeAtIndex.Age);
                    Console.Write("Employee Skills - ");
                    foreach (var skill in employeeAtIndex.skills)
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
        }
    }
}
