using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initalize array
            string[] array1 = new string[] { "Hi", "Hello", "Hey" };
            Console.WriteLine("Input some text please.");
            string input1 = Console.ReadLine();


            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Test 1: " + array1[i] + input1);
            }
            Console.WriteLine("Press Enter");
            Console.ReadLine();


            int b = 0;

            do
            {
                Console.WriteLine("Test 2: " + array1[b]);
                b++;
            }
            while (b <= 2);


            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
