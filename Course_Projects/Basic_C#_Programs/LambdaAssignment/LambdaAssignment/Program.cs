using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>
            {
                new Employee{FirstName = "Joe", LastName = "Franke", ID = 0 },
                new Employee{FirstName = "Jon", LastName = "Osterman", ID = 1},
                new Employee{FirstName = "Zed", LastName = "Fyreston", ID = 2},
                new Employee{FirstName = "Morpheus", LastName = "Shades", ID = 3},
                new Employee{FirstName = "Joe", LastName = "Frankenstein", ID = 4},
                new Employee{FirstName = "Scorpion", LastName = "McPuhler", ID = 5},
                new Employee{FirstName = "Esse", LastName = "Dragon", ID = 6},
                new Employee{FirstName = "Isaac", LastName = "Clarke", ID = 7},
                new Employee{FirstName = "Thor", LastName = "Odinson", ID = 8},
                new Employee{FirstName = "Tom", LastName = "Hardy", ID = 9}
            };

            List<Employee> joeList = new List<Employee>();
            
            foreach (Employee item in empList)
            {
                if (item.FirstName == "Joe")
                {
                    Console.WriteLine(item.FirstName + item.LastName);
                    joeList.Add(item);
                }
            }

            List<Employee> joes = empList.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee joe in joes)
            {
                Console.WriteLine(joe.FirstName + joe.LastName);
            }

            List<Employee> idFiver = empList.Where(y => y.ID > 5).ToList();

            foreach ( Employee id in idFiver)
            {
                Console.WriteLine(id.ID);
            }

            Console.ReadLine();
        }
    }
}
