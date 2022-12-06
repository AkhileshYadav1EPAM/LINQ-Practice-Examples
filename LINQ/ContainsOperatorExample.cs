using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class ContainsOperatorExample
    {
        public static void main(string[] args)
        {
            List<string> stringLists = new List<string>();
            stringLists.Add("Akhilesh kumar");
            stringLists.Add("Virat Kholi");
            stringLists.Add("Modi Kumar");
            stringLists.Add("Putin Kumar");

            var resultQuery = from stringList in stringLists where stringList.Contains("Kumar") select stringLists;
            Console.WriteLine(resultQuery);
            var resultLambda = stringLists.Where(stringList => stringList.Contains("Kumar"));
            Console.WriteLine(resultLambda);

            Console.ReadLine();
        }
    }
}
