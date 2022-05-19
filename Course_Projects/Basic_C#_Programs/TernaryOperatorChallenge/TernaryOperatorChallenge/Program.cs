using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".: This is a Ternary Operation Program :.");
            Console.WriteLine("Input an integer.");
            string num1 = Console.ReadLine();
            int num2 = Convert.ToInt32(num1);
            Console.WriteLine("Your number is: " + num2);
            Console.ReadLine();


            Console.WriteLine("Input another integer.");
            string num3 = Console.ReadLine();
            int num4 = Convert.ToInt32(num3);
            Console.WriteLine("Your number is: " + num4);
            Console.ReadLine();


            Console.WriteLine("Ternary Operation");
            string operation = num2 > num4 ? "number 1 is greater than number 2." : "number 1 is not greater than number 2.";
            Console.WriteLine(operation);
            Console.WriteLine("END of program, press ENTER");
            Console.ReadLine();
        }
    }
}
