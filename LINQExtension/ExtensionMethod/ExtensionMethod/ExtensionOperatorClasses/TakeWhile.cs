using ExtensionMethod.DataClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class TakeWhile : EmployeeData
    {
        public void TakeWhileMethod()
        {
            Console.WriteLine("-> TakeWhile Operator <-");
            Console.WriteLine();

            IList<string> stringList = new List<string>()
                                        {
                                            "One",
                                            "Two",
                                            "Three",
                                            "Four",
                                            "Five",
                                            "Six",
                                            "Seven"};

            var resultList = stringList.TakeWhile(s => s.Length < 4);

            foreach (string str in resultList)
                Console.WriteLine(str);

            Console.WriteLine();
        }
    }
}
