using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Application_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter input as an integer.");
            string a1 = Console.ReadLine();
            int a2 = Convert.ToInt32(a1);
            int ttl1 = a2 * 50;
            Console.WriteLine("Your number is multiplied by 50 and is a total of: " + ttl1);
            Console.ReadLine();

            Console.WriteLine("Enter input as an integer.");
            string a3 = Console.ReadLine();
            int a4 = Convert.ToInt32(a3);
            int ttl2 = a4 + 25;
            Console.WriteLine("Your number has 25 added to the sum equaling: " + ttl2);
            Console.ReadLine();

            Console.WriteLine("Enter input as an integer.");
            string a5 = Console.ReadLine();
            float a6 = Convert.ToInt32(a5);
            float ttl3 = a6 / 12.5f;
            Console.WriteLine("Your number is divided by 12.5 and is: " + ttl3);
            Console.ReadLine();

            Console.WriteLine("Enter input as an integer.");
            string a7 = Console.ReadLine();
            int a8 = Convert.ToInt32(a7);
            int a8B = 50;
            Console.WriteLine(a8 > a8B);
            Console.ReadLine();

            Console.WriteLine("Enter input as an integer.");
            string a9 = Console.ReadLine();
            int a10 = Convert.ToInt32(a9);
            int ttl5 = a10 % 7;
            Console.WriteLine("The number is divided by 7 and the remainder will be displayed here: " + ttl5);
            Console.ReadLine();

        }
    }
}
