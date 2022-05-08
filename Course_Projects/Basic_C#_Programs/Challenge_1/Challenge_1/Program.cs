using System;

namespace Challenge_1
{
    class Program
    {
        static void Main()
        {
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;

            Console.WriteLine("Addition of 1 and 2.");
            int sum1 = num1 + num2;
            Console.WriteLine(sum1);
            Console.ReadLine();

            Console.WriteLine("Subtraction of 1 and 3.");
            int diff1 = num1 - num3;
            Console.WriteLine(diff1);
            Console.ReadLine();

            Console.WriteLine("Multiplication of 2 and 2.");
            int product1 = num2 * num2;
            Console.WriteLine(product1);
            Console.ReadLine();

            Console.WriteLine("Division of 2 and 1.");
            int dividend1 = num2 / num1;
            Console.WriteLine(dividend1);
            Console.ReadLine();
        }
    }
}
