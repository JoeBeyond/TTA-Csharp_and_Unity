using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input integer one.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input integer two.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input integer three.");
            int num3 = Convert.ToInt32(Console.ReadLine());


            string result1 = "Gorilla";
            string result2 = "Crocodile";
            string result3 = "Zebra";


            do
            {
                Console.WriteLine(result1);
                num1++;
                Console.ReadLine();
            }
            while (num1 <= num2);
            {
                Console.WriteLine(result2);
                num3--;
                Console.ReadLine();
            }

            while (num1 == num3 && num1 == num2)
            {
                Console.WriteLine(result3);
                num1--;
                num3++;
                Console.ReadLine();
            }
            Console.WriteLine("END OF PROGRAM");
            Console.ReadLine();
        }
    }
}
