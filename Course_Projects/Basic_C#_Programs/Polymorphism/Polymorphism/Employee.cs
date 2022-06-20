using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I QUIT! I'm taking the doughnuts.");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
