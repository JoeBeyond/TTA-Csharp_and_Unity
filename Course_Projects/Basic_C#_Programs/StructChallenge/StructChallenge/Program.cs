using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number100 = new Number();
            number100.Amount = 100;
            Console.WriteLine(number100);
        }

        public struct Number
        {
            public decimal Amount { get; set; }
        }
        
    }
}
