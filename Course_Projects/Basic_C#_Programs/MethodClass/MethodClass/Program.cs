using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IntegerOutput output = new IntegerOutput();

            output.ParameterOperation(3, 5);

            output.ParameterOperation(b: 33, a: 55);

            Console.ReadLine();
        }

        
    }
}
