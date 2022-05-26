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


            Console.WriteLine("Search for a person, please input first name; Alice, James, Brie or Sam.");
            List<string> names = new List<string>() { "Alice", "James", "Brie", "Sam" };

            int j = 0;
            int index = 0;

            bool var1 = false;
            int ab1 = 0;

            while (!var1)
            {
                j = 0;
                string nameA = Convert.ToString(Console.ReadLine());

                foreach (string nameB in names)
                {
                    if (nameB == nameA)
                    {
                        index = j;
                        ab1 = j + 1;
                    }
                    j++;
                }

                if (ab1 == 0)
                {
                    Console.WriteLine("Name is not valid.");
                }

                else
                {
                    var1 = true;
                }
            }

            Console.WriteLine("Here is your index element:" + index);
            Console.ReadLine();


            List<string> measurements = new List<string>() { "Inches", "Feet", "Yards", "Inches" };
            Console.WriteLine("Input a measurement; Inches, Feet, Yards.");

            string inputMeasurement = Console.ReadLine();

            int indexCounter = 0;

            for (indexCounter = 0; indexCounter < measurements.Count; indexCounter++)
            {
                if (inputMeasurement == measurements[indexCounter])
                {
                    Console.WriteLine(indexCounter);
                }
            }
            Console.ReadLine();


            Console.WriteLine("Here is a list of strings ( Fruits ).");
            List<string> fruitSmoothie = new List<string>() { "Bananna", "Mango", "Orange", "Mango", "Pineapple" };
            List<string> doubleIngredient = new List<string>();

            foreach (string fruit in fruitSmoothie)
            {
                if (doubleIngredient.Contains(fruit))
                {
                    Console.WriteLine("This fruit has been seen before " + fruit);
                }

                else
                {
                    Console.WriteLine("This fruit has not been seen before " + fruit);
                    doubleIngredient.Add(fruit);
                }
            }

            //bool upgradeItem = true;
            //bool money = true;
            //bool satisfiedCustomer = true;
            //bool endTransaction = true;

            //foreach (string fruits in fruitSmoothie)
            //{
            
            //    if (upgradeItem == money)
            //    {
            //        doubleIngredient.Add(fruits);
            //    }

            //    else if (satisfiedCustomer == endTransaction)
            //    {
            //        Console.WriteLine("Enjoy your " + doubleIngredient + " smoothie!");
            //    }
            //}

            Console.WriteLine("END of Program");
            Console.ReadLine();

        }
    }
}
