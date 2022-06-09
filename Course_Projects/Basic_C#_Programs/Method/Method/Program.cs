using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IntegerMethods calculations = new IntegerMethods();

            Console.WriteLine("Input an integer.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have a choice to input another integer or not.");

            try
            {
                int num2 = Convert.ToInt32(Console.ReadLine());
                int outputB = calculations.Math1(num1, num2);
                Console.WriteLine(outputB);
            }
            catch
            {
                int outputA = calculations.Math1(num1);
                Console.WriteLine(outputA);
            }

            Console.WriteLine("END PROGRAM");
            Console.ReadLine();
        }
    }
}
