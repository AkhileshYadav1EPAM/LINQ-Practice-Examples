using ExtensionMethod.DataClass;
using ExtensionMethod.DefinitionClass;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class OfType : EmployeeData
    {
        public void OfTypeMethod()
        {
            Console.WriteLine("|-> OfType operator <-|");
            Console.WriteLine();

            IList mixedList = new ArrayList();
            mixedList.Add(1);
            mixedList.Add("Akhilesh");
            mixedList.Add("Yadav");
            mixedList.Add(1);
            mixedList.Add(new Employee() { EmployeeId = 1001, Name = "Akhilesh", DepartmentId = 1, skills = new List<string> { ".Net", "MVC", "Agular" } });

            //var ofTypeResult = from m in mixedList.OfType<string>() select m;
            var ofTypeResult = mixedList.OfType<string>();


            foreach (var item in ofTypeResult)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
        }
    }
}
