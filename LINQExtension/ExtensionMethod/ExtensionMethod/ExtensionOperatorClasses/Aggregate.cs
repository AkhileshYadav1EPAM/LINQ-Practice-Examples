using ExtensionMethod.DataClass;
using ExtensionMethod.DefinitionClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class Aggregate : EmployeeData
    {
        public void AggregateMethod()
        {
            Console.WriteLine("-> Aggregate Operator <-");
            Console.WriteLine();

            var commaSepareatedEmployeeNameWithSeedValue = 
                                            employeeList.Aggregate<Employee, string>(
                                            "Employee Name - ",
                                            (finalList, name) => finalList += name.Name + ", ");

            Console.WriteLine(commaSepareatedEmployeeNameWithSeedValue);

            Console.WriteLine();
        }
    }
}
