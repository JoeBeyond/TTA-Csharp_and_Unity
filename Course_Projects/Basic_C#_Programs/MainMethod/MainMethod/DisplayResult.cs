using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class DisplayResult
    {
        public int Integer(int a3)
        {
            int math1 = a3 * 111 / 32 + 9472 - 685;
            return math1;
        }

        public int Decimal(decimal b5)
        {
            decimal x = b5 + 3;
            int convert = Convert.ToInt32(x);
            return convert;
        }

        public int String(string c7)
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
