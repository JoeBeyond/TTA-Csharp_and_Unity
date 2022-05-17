using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("PRESS ENTER");
            Console.ReadLine();

            int hourRate1 = 15;
            int hourRate2 = 20;
            int hourWeekA = 40;
            int salary1 = 32000;
            int salary2 = 41600;

            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate: " + hourRate1);
            Console.ReadLine();
            Console.WriteLine("Hours Worked per Week: " + hourWeekA);
            Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate: " + hourRate2);
            Console.ReadLine();
            Console.WriteLine("Hours Worked per Week: " + hourWeekA);
            Console.ReadLine();

            
            Console.WriteLine("Person 1 Salary: " + salary1);
            Console.ReadLine();
            Console.WriteLine("Person 2 Salary: " + salary2);
            Console.ReadLine();

            Console.WriteLine("Does person 1 make more money than person 2?");
            Console.ReadLine();
            Console.WriteLine(salary1 > salary2);
            Console.ReadLine();
            Console.WriteLine("END");
            Console.ReadLine();
            // test
        }
    }
}
