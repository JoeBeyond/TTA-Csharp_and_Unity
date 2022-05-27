using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Initialize List of Ints.");
                List<int> multiplesOfTwelve = new List<int>() { 12, 24, 36, 48, 60 };

                Console.WriteLine("Please input an integer.");
                int userInput = Convert.ToInt32(Console.ReadLine());

                foreach (int multiple in multiplesOfTwelve)
                {
                    int division = multiple / userInput;
                    Console.WriteLine(division);
                }
            }
            
            catch (DivideByZeroException Void)
            {
                Console.WriteLine(Void.Message);
            }

            catch (FormatException Form)
            {
                Console.WriteLine(Form.Message);
                return;
            }

            catch (Exception Except)
            {
                Console.WriteLine("Error.");
            }

            finally
            {
                Console.WriteLine("END Program");
                Console.ReadLine();
            }
        }
    }
}
