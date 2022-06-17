using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VoidDivision arithmetic = new VoidDivision();

            Console.WriteLine("Enter an integer");
            int input1 = Convert.ToInt32(Console.ReadLine());

            arithmetic.DataHandling(input1);
            int x = arithmetic.Data(1000, 3000);
            Console.WriteLine(x);

            string y = arithmetic.Data(100, out string money);
            Console.WriteLine(money);

            Console.WriteLine(StaticBool.Parameter(30));

            Console.WriteLine("END PROGRAM");
            Console.ReadLine();
        }
    }
}
