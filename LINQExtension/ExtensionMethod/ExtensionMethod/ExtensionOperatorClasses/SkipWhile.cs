using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod.ExtensionOperatorClasses
{
    public class SkipWhile
    {
        public void SkipWhileMethod()
        {
            Console.WriteLine("-> SkipWhile Operator <-");
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

            var resultList = stringList.SkipWhile(s => s.Length < 4);

            foreach (string str in resultList)
                Console.WriteLine(str);

            Console.WriteLine();
        }
    }
}
