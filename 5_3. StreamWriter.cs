///<summury>
/// StreamWriter
/// WriteLine ReadLine 을 통해서 문장을 간편하게 입출력 할수 있다.
///</summury>


using System;
using System.IO;
using System.Text;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"c:\test.txt";
            string textToAdd = "Example text in file";

            using (StreamWriter writer = new StreamWriter(fileName, true, Encoding.UTF8))
            {
                writer.Write(textToAdd);
            }

        }
    }
}