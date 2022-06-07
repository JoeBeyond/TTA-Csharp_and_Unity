using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    // Class below; the subprogram
    public class IntegerMath
    {
        // Function below; of the class

        public int AddNumber(int x)
        {
            int sum = x + 28;
            return sum;
        }

        public int SubtractNumber(int x)
        {
            int difference = x - 28;
            return difference;
        }

        public int MultiplyNumber(int x)
        {
            int product = x * 28;
            return product;
        }
    }
}
