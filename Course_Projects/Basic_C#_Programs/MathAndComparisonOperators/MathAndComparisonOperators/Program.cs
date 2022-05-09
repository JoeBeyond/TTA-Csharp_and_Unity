using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            Console.WriteLine("Five plus Ten = " + total.ToString());
            Console.ReadLine();


            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine("Five plus Ten plus Twelve plus Twenty-Two = " + combined.ToString());
            Console.ReadLine();

            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " + difference.ToString());
            Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine("Ten times Five = " + product.ToString());
            Console.ReadLine();

            int quotient1 = 100 / 5;
            Console.WriteLine("Hundred divided by Five = " + quotient1.ToString());
            Console.ReadLine();

            double quotient2 = 100.0 / 17.0;
            Console.WriteLine("Hundred divided by Seventeen = " + quotient2.ToString());
            Console.ReadLine();

            int remainder = 11 % 2;
            Console.WriteLine("Eleven divided by Two has a remainder of ... " + remainder.ToString());
            Console.ReadLine();
        }
    }
}
