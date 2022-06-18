using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee individual = new Employee();
            individual.FirstName = "Sample";
            individual.LastName = "Student";
            individual.SayName();
            Console.ReadLine();
        }
    }
}
