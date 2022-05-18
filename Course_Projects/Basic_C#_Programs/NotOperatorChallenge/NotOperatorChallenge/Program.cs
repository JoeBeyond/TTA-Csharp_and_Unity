using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotOperatorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("This is a, not-operator. Input an integer please.");
            string num1 = Console.ReadLine();
            int num2 = Convert.ToInt32(num1);


            Console.WriteLine("Now input the same as last or a different integer please.");
            string num3 = Console.ReadLine();
            int num4 = Convert.ToInt32(num3);


            if (num2 != num4)
            {
                Console.WriteLine("Not Equal.");
            }
            else if (num2 == num4)
            {
                Console.WriteLine("Equal");
            }
            Console.ReadLine();
        }
    }
}
