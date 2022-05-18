using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 0 and 5. Or not..");


            string num1 = Console.ReadLine();
            int num2 = Convert.ToInt32(num1);


            if (num2 <= 2)
            {
                num2++;
                Console.WriteLine(".IF. " + num2);
            }
            else if (num2 <= 5)
            {
                num2--;
                Console.WriteLine(".ELSE IF. " + num2);
            }
            else
            {
                Console.WriteLine(".ELSE. " + num2);
            }
            
            
            Console.ReadLine();
        }
    }
}
