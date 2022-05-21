using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //User input for strings

            Console.WriteLine("Input a string.");
            string str1 = Console.ReadLine();

            Console.WriteLine("Input second string.");
            string str2 = Console.ReadLine();

            Console.WriteLine("Input third string.");
            string str3 = Console.ReadLine();

            // String concatenation

            string concat = str1 + str2 + str3;
            Console.WriteLine(concat);

            concat = concat.ToUpper();
            Console.WriteLine(concat);

            // StringBuilders forming paragraph

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Don't forget to ration your coffee.");
            Console.WriteLine(sb1);

            StringBuilder sb2 = new StringBuilder();
            sb2.Append("A long time ago there were these creatures that tended the plants for us...");
            Console.WriteLine(sb2);

            StringBuilder sb3 = new StringBuilder();
            sb3.Append("We've taken the mantle of their labor to sustain life. So appreciate that cup of Joe.");
            Console.WriteLine(sb3);

            // End of Program

            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
