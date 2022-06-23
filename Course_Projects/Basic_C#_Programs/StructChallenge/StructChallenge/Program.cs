using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructChallenge
{
    class Program
    {
        public struct Number
        {
            public decimal Amount;
        }

        static void Main(string[] args)
        {
            Number number100;

            number100.Amount = 100.5m;

            Console.WriteLine(number100.Amount);
            Console.ReadLine();
        }
    }
}
