using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer.");
            string num1 = Console.ReadLine();

            File.WriteAllText(@"C:\ThisPC\Documents\textfile.txt", num1);

            using (StreamWriter file = new StreamWriter(@"C:\ThisPC\Documents\textfile.txt", true))
            {
                file.WriteLine(num1);
            }

            Console.WriteLine("END PROGRAM");
            Console.ReadLine();
        }
    }
}
