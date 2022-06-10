using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class DisplayResult
    {
        // Ovreloading a method

        public int MathMethod(int a3)
        {
            int math1 = a3 * 111 / 32 + 9472 - 685;
            return math1;
        }

        public int MathMethod(decimal b5)
        {
            decimal x = b5 + 39.3m * 39.3m;
            int convert = Convert.ToInt32(x);
            return convert;
        }

        public int MathMethod(string c7)
        {
            try
            {
                int dataTypeConversion = Convert.ToInt32(c7);
                int result = dataTypeConversion + 5;
                return result;
            }
            catch (System.FormatException xy)
            {
                Console.WriteLine(xy.Message + " , terminating program.");
                Console.ReadLine();
                Environment.Exit(0);
                return 0;
            }
        }
    }
}
