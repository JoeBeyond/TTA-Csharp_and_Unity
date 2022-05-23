using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test 1: Array initialization");
            string[] array1 = new string[] { "A", "B", "C" };
            int[] array2 = new int[] { 1, 2, 3 };


            Console.WriteLine("Test 2A: Array Conversion, Input Array Index 0-2");
            int x = Convert.ToInt32(Console.ReadLine());


            if (x >= 3)
            {
                Console.WriteLine("Test Exit: Error Message");
                Console.WriteLine("ERROR");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                string inputA = array1[x];
                Console.WriteLine("Your 1st index is: " + inputA);
            }


            Console.WriteLine("Test 2B: Array Conversion, Input Array Index 0-2");
            int y = Convert.ToInt32(Console.ReadLine());


            if (y >= 3)
            {
                Console.WriteLine("Test Exit: Error Message");
                Console.WriteLine("ERROR");
                Console.ReadLine();
                Environment.Exit(1);
            }
            else
            {
                int inputB = array2[y];
                Console.WriteLine("Your 1st index is: " + inputB);
            }


            Console.WriteLine("Test 5: List initialization; add values");
            List<string> ListA = new List<string>();
            ListA.Add("X");
            ListA.Add("Y");
            ListA.Add("Z");


            Console.WriteLine("Test 6: List Conversion; Input index 0-2");
            int z = Convert.ToInt32(Console.ReadLine());

            if (z >= 3)
            {
                Console.WriteLine("Test Exit: Error Message");
                Console.WriteLine("ERROR");
                Console.ReadLine();
                Environment.Exit(2);
            }
            else
            {
                string inputC = ListA[z];
                Console.WriteLine("Your 1st index is: " + inputC);
            }


            Console.WriteLine("END of Program");
            Console.ReadLine();
        }
    }
}
