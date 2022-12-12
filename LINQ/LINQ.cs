using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQ
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 20, 30, 22, 40, 50, 75, 85 };

            IEnumerable<int> scoreQuery = from score in scores where score < 50 select score;
            IEnumerable<int> scoreLambda = scores.Where(score => score < 50);

            Console.Write("Using Query Syntax - ");
            foreach(int score in scoreQuery) { Console.Write(score + " "); }

            Console.WriteLine(); // For new line

            Console.Write("Using Lambda Syntax - ");
            foreach(int score in scoreLambda) { Console.Write(score + " "); }

            Console.ReadLine();
        }
    }
}
