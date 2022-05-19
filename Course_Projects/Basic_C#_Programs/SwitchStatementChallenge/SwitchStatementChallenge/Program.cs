using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatementChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer [1,2,3,4] to get output.");
            string input1 = Console.ReadLine();
            int output1 = Convert.ToInt32(input1);


            switch (output1)
            {
                case 1:
                    Console.WriteLine(output1 + " Apple");
                    break;
                case 2:
                    Console.WriteLine(output1 + " Super-Turkeys");
                    break;
                case 3:
                    Console.WriteLine(output1 + " Infinity Stones");
                    break;
                case 4:
                    Console.WriteLine(output1 + " Valkyrie of the Skies");
                    break;
            }
            

            if (output1 >= 5)
            {
                Console.WriteLine("You have encountered a gargantuan beast of long past, and it eats you in one whole bite.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Program END");
            Console.ReadLine();
        }
    }
}
