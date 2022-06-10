using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DisplayResult data = new DisplayResult();

            Console.WriteLine("Please input an integer.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int result1 = data.Integer(num1);
            Console.WriteLine(result1);

            Console.WriteLine("Please input a decimal.");
            decimal dec1 = Convert.ToDecimal(Console.ReadLine());
            int result2 = data.Decimal(dec1);
            Console.WriteLine(result2);

            Console.WriteLine("Please input a string.");
            string str1 = Convert.ToString(Console.ReadLine());
            int result3 = data.String(str1);
            Console.WriteLine(result3);

            Console.WriteLine("END PROGRAM");
            Console.ReadLine();
        }
    }
}
