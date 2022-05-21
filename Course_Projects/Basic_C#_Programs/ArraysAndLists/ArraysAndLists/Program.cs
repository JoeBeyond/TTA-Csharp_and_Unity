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
            // ::::: ARRAYS :::::

            // 5 integers in array with hard-coded values

            int[] numArray = new int[5];

            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            Console.WriteLine(numArray[3]);
            Console.ReadLine();

            // Same array but quicker and cleaner

            int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            // Declaring a new array with a index 5 value changed

            int[] numArray2 = { 70, 14, 210, 28, 350, 42};
            numArray2[5] = 700;

            // Write output

            Console.WriteLine(numArray1[2]);
            Console.ReadLine();

            Console.WriteLine(numArray2[2]);
            Console.ReadLine();

            //:::::ARRAYS:::::

            //::::: LISTS :::::

            List<int> intListA = new List<int>();
            intListA.Add(4);
            intListA.Add(10);
            intListA.Remove(10);

            Console.WriteLine(intListA[0]);
            Console.ReadLine();

            // List can work with any data type to create a collection of data and can use different commands within the chunck of code

            List<string> intList1 = new List<string>();
            intList1.Add("Hello");
            intList1.Add("World");
            intList1.Remove("World");

            Console.WriteLine(intList1[0]);
            Console.ReadLine();

            // byte[] stores data as binary information

            byte[] byteArray = new byte[5000];
            Console.WriteLine(byteArray[0]);
            Console.WriteLine(byteArray[1]);
            Console.ReadLine();

            //::::: LISTS :::::

            Console.WriteLine("END of Program");
            Console.ReadLine();

            // End of Program
        }
    }
}
