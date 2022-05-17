using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicSubmissionAssigment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cosmic-Insurance, let's get you qualified!");
            Console.WriteLine("PRESS ENTER");
            Console.ReadLine();

            Console.WriteLine("What is your age?");
            string age1 = Console.ReadLine();
            int age2 = Convert.ToInt32(age1);
            Console.WriteLine("Your age is: " + age2);
            Console.ReadLine();

            Console.WriteLine("Have you ever had a DUI? Answer \"true\" or \"false\".");
            string response1 = Console.ReadLine();
            Console.WriteLine(response1 + ", proceeding.");
            Console.ReadLine();

            Console.WriteLine("How many speeding tickets do you have?");
            string ticket1 = Console.ReadLine();
            int ticket2 = Convert.ToInt32(ticket1);
            Console.WriteLine(ticket2 + " tickets.");


        }
    }
}
