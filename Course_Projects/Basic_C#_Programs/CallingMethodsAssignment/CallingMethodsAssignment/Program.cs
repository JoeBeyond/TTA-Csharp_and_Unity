using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Initialize a sub program with its own routine. Able to call the routine as needed. The methods in Program.cs file apply to []Main.

            IntegerMath obj1 = new IntegerMath();

            Console.WriteLine("Please Input a mnumber.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int result1 = obj1.AddNumber(num1);
            Console.WriteLine(result1);
            int result2 = obj1.SubtractNumber(num1);
            Console.WriteLine(result2);
            int result3 = obj1.MultiplyNumber(num1);
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
