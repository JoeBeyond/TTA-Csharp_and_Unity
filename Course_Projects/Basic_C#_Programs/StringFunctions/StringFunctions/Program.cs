using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "jesse";
            string quote = "the man said \\Hello Jesse\" \n hello on a new line \n \t hello on a new tab";
            string fileName = @"C:Users\jesse";


            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.StartsWith("s");

            name = name.ToUpper();

            int length = name.Length;


            Console.WriteLine(trueOrFalse);
            Console.WriteLine(quote);
            Console.WriteLine(name);
            Console.WriteLine(length);
            Console.WriteLine(fileName);


            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Joe.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
