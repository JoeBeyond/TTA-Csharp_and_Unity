using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsOverloaded
{
    public class Employee
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public static bool operator== (Employee obj1, Employee obj2)
        {
            return obj1.ID == obj2.ID;
        }
        public static bool operator!= (Employee obj1, Employee obj2)
        {
            return obj1.ID != obj2.ID;
        }
    }
}
