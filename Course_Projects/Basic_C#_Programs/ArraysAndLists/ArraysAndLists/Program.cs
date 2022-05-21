using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 integers in array with hard-coded values

            int[] numArray = new int[5];

            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            Console.WriteLine(numArray[3]);

            // Same array but quicker and cleaner

            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
            Console.WriteLine(numArray1);
            Console.ReadLine();

            // End of Program
        }
    }
}
