using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the numbers...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }

            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                Console.WriteLine(ex.Message);
                return;
            }

            catch (DivideByZeroException Zero)
            {
                Console.WriteLine("Please don't divide by zero.");
                Console.WriteLine(Zero.Message);
            }

            catch (Exception ex1)
            {
                Console.WriteLine("General Exception");
            }

            finally
            {
                Console.WriteLine("END preogram");
                Console.ReadLine();
            }
        }
    }
}
