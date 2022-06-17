using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    public static class StaticBool
    {
        public static bool Parameter(this int c)
        {
            int d = 50;
            int e = 70;
            return (c + e) >= d + d;
        }
    }
}
