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

        public decimal Decimal(decimal b5)
        {
            decimal decimal1 = b5 + 182.387m * 23.374m;
            Math.Round(decimal1);
            return decimal1;
        }

        public string String(string c7)
        {
            string string1 = c7;

            try
            {
                //string string1 = c7;

                int dataTypeConversion = Convert.ToInt32(c7);

                Console.WriteLine(dataTypeConversion);
            }
            catch (System.FormatException xy)
            {
                Console.WriteLine(xy.Message + " , terminating program.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            return string1;
        }
    }
}
