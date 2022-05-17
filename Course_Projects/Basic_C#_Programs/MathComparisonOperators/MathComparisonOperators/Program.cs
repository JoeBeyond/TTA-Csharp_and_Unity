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


            Console.WriteLine("Person 1: input rate of pay as an integer.");
            int hourRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hourly Rate: " + hourRate1);
            Console.WriteLine("Person 1: input hours per week as an integer.");
            int hourWeekA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked per Week: " + hourWeekA);


            Console.WriteLine("Person 2: input rate of pay as an integer.");
            int hourRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hourly Rate: " + hourRate2);
            Console.WriteLine("Person 2: input hours per week as an integer.");
            int hourWeekB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked per Week: " + hourWeekB);
            Console.ReadLine();


            int salary1 = (hourRate1 * hourWeekA * 52);
            Console.WriteLine("Person 1 Salary: " + salary1);
            Console.ReadLine();

            int salary2 = (hourRate2 * hourWeekB * 52);
            Console.WriteLine("Person 2 Salary: " + salary2);
            Console.ReadLine();

            Console.WriteLine("Does person 1 make more money than person 2? Press ENTER.");
            Console.ReadLine();
            Console.WriteLine(salary1 > salary2);
            Console.ReadLine();
            Console.WriteLine("END");
            Console.ReadLine();
        }
    }
}
