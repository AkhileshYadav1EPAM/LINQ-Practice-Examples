using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadingFromFile
{
    internal class ReadingFromFiles
    {
        static void Main(string[] args)
        {
            string folderPathForReading = "C:\\Users\\Akhilesh_Yadav1\\Desktop\\C# Example Codes\\2 - C# Examples\\LINQ Practice\\File Handling\\Files folder";
            string fileNameForReading = "Reading.txt";
            string filePathForReading = Path.Combine(folderPathForReading, fileNameForReading);

            StreamReader sr = new StreamReader(filePathForReading);

            Console.WriteLine("Content of the File");

            string readingText = sr.ReadLine();

            while (readingText != null)
            {
                Console.WriteLine(readingText);
                readingText = sr.ReadLine();
            }

            Console.ReadLine();

            sr.Close();
        }
    }
}
