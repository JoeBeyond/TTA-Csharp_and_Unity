using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Input the current day.");

                string wkInput = Convert.ToString(Console.ReadLine());

                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), wkInput);

                Console.WriteLine(day);

            }

            catch (Exception az23)
            {
                Console.WriteLine("Please Enter an actual day of the week.");
                Console.ReadLine();
                Environment.Exit(0);
            }


            Console.WriteLine("Dang.");         

            Console.ReadLine();
            

        }

        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
