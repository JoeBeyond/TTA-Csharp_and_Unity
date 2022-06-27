using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2022, 06, 27, 4, 52, 30);

            Console.WriteLine(DateTime.Now);

            Console.WriteLine("Enter an integer.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(DateTime.Now.AddHours(num1));

            Console.WriteLine("END PROGRAM");
            Console.ReadLine();

            
        }
    }
}
