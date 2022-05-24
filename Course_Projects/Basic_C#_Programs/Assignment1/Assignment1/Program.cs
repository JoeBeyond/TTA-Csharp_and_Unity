using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initalize array
            string[] array1 = new string[] { "Hi", "Hello", "Hey" };
            Console.WriteLine("Input some text please.");
            string input1 = Console.ReadLine();


            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Here is the string with user input tied to end: " + array1[i] + input1);
            }
            Console.WriteLine("Press ENTER");
            Console.ReadLine();


            int b = 0;

            do
            {
                Console.WriteLine("Int B is: " + array1[b]);
                b++;
            }
            while (b <= 2);

            Console.ReadLine();


            Console.WriteLine("B is greater than or equal to 2");
            Console.ReadLine();

            for (int c = 0; c < 10; c++)
            {
                Console.WriteLine("C WAS Infinite...");
                b++;
            }
            while (b == 10);

            Console.WriteLine("Until B became equal to 10");
            Console.ReadLine();


            Console.WriteLine("You may checkout books");
            List<int> borrowBooks = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> inventoryStock = new List<int>();

            foreach (int books in borrowBooks)
            {
                if (books < 5)
                {
                    inventoryStock.Add(books);
                }
            }

            Console.WriteLine("Just be sure to bring back your " + inventoryStock.Count + " books!");
            Console.ReadLine();


            Console.WriteLine("There is one mama duck parent.");

            List<int> ducklings = new List<int> { 1, 2, 3, 4, 5 };

            foreach (int ducks in ducklings)
            {
                if (ducks <= 1)
                {
                    Console.WriteLine("The number of ducklings is: " + ducklings[4]);
                }
            }

            Console.ReadLine();







            Console.WriteLine("END of Program");
            Console.ReadLine();

        }
    }
}
