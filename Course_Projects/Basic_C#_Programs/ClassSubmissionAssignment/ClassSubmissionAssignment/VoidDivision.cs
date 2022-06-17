using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public class VoidDivision
    {
        public void DataHandling(int userInput)
        {
            int output = userInput / 2;
            Console.WriteLine(output);
        }

        public string Data(int dollars1, out string money)
        {
            int a = 30;
            int b = dollars1 + a;
            money = "Money is awesome, you have " + b + " dollars.";
            return money;
        }

        public int Data(int a, int b)
        {
            return a + b;
        }
    }
}
