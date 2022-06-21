using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersSubmission
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee<string> thing1 = new Employee<string>();
            thing1.Things = new List<string>() { "Clock-In", "Clock-Out", "Rock-in Out" };

            

            Employee<int> thing2 = new Employee<int>();
            thing2.Things = new List<int>() { 5, 3, 0 };

            
            foreach (var thing in thing1.Things)
            {
                Console.WriteLine(thing);
            }

            foreach (var thing in thing2.Things)
            {
                Console.WriteLine(thing);
            }

            
            Console.ReadLine();
        }
    }
}
