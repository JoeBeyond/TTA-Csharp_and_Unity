using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<<< Welcome to Package Express. Please follow the instructions below. >>>");

            Console.WriteLine("Input package weight below as an integer, in pounds.");
            string packageWeightA = Console.ReadLine();
            int packageWeightB = Convert.ToInt32(packageWeightA);
            

            if (packageWeightB > 50)
            {
                Console.WriteLine("Package is TOO HEAVY to be shipped via Package Express. Have a good day. Press ENTER to Exit.");
                Console.ReadLine();

                // Terminates the program here
                Environment.Exit(0);
            }


            Console.WriteLine("What is the WIDTH, as an integer, in inches?");
            string widthA = Console.ReadLine();
            int widthB = Convert.ToInt32(widthA);

            Console.WriteLine("What is the HEIGHT, as an integer, in inches?");
            string heightA = Console.ReadLine();
            int heightB = Convert.ToInt32(heightA);

            Console.WriteLine("What is the LENGTH, as an integer, in inches?");
            string lengthA = Console.ReadLine();
            int lengthB = Convert.ToInt32(lengthA);


            int dimensionsA = widthB + heightB + lengthB;

            if (dimensionsA > 50)
            {
                Console.WriteLine("Package TOO BIG to be shipped via Package Express. Have a good day. Press ENTER to Exit.");
                Console.ReadLine();

                // Terminates the program here
                Environment.Exit(1);
            }

            int dimensionsB = heightB * widthB * lengthB * packageWeightB / 100;


            Console.WriteLine("Here is your Quote to send you package: " + dimensionsB + " dollars. Congratulations!");
            Console.ReadLine();
        }
    }
}
