using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class SelectMany : EmployeeData
    {
        public void SelectManyMethod()
        {
            Console.WriteLine("|-> selectmany operator <-|");
            Console.WriteLine();
            var selectmanyResult = employeeList.SelectMany(emp => emp.skills);


            foreach (var item in selectmanyResult)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
