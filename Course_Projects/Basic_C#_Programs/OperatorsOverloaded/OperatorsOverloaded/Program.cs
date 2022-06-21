using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloaded
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee obj1 = new Employee();
            Employee obj2 = new Employee();
            obj1.ID = 0;
            obj2.ID = 0;
            Console.WriteLine(obj1.ID == obj2.ID);
            Console.ReadLine();
            
        }
    }
}
