using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOutputChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Greater Than Operation

            Console.WriteLine("This is a Greater Than and Lesser Than test.");
            Console.WriteLine("Input an integer please.");
            string num1 = Console.ReadLine();
            int num2 = Convert.ToInt32(num1);
            Console.WriteLine("First number is: " + num2);
            Console.ReadLine();


            Console.WriteLine("Input an integer please.");
            string num3 = Console.ReadLine();
            int num4 = Convert.ToInt32(num3);
            Console.WriteLine("Second number is: " + num4);
            Console.ReadLine();


            Console.WriteLine("Is the first number GREATER THAN the second?");
            Console.WriteLine(num2 > num4);
            Console.ReadLine();

            // Lesser Than Operation

            Console.WriteLine("Input an integer please.");
            string num5 = Console.ReadLine();
            int num6 = Convert.ToInt32(num5);
            Console.WriteLine("First number is: " + num6);
            Console.ReadLine();


            Console.WriteLine("Input an integer please.");
            string num7 = Console.ReadLine();
            int num8 = Convert.ToInt32(num7);
            Console.WriteLine("Second number is: " + num8);
            Console.ReadLine();


            Console.WriteLine("Is the first number LESSER THAN OR EQUAL TO the second?");
            Console.WriteLine(num6 <= num8);
            Console.WriteLine("END OF TEST: Please Press ENTER to exit program.");
            Console.ReadLine();
        }
    }
}
