using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=1,Name = "suyog"},
                new Employee(){Id=2,Name = "Ojasvi" },
               
            };
            Console.WriteLine("-------------Using IEnumerable-------------");

            IEnumerable<Employee> query = from e in employees
                                     where e.Id == 2
                                     select e;
            foreach (Employee e in query)
            {
                Console.WriteLine($"The id is {e.Id} and name is {e.Name}");
            }

            Console.WriteLine("---------------Using IQueryable-----------------");

            IQueryable<Employee> query2 = employees.AsQueryable().Where(q => q.Id == 2);


            foreach (Employee e in query2) {
                Console.WriteLine($"The id is {e.Id} and name is {e.Name}");
            }
            Console.WriteLine("---------------------------");


            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
          


            var linqObj = from obj in list
                          where obj > 2
                          select obj;
            //  LINQ Syntax
            foreach (var item in linqObj)
            {
                Console.WriteLine(item);
               
            }
            // Method LINQ Syntax
            Console.WriteLine("---------------------------");

            var methodQuery =list.Where(x => x > 2);

            foreach (var item in methodQuery)
            {
                Console.WriteLine(item);

            }
            // mixed LINQ Syntax
            Console.WriteLine("---------------------------");

            var mixedLinq = (from obj in list
                            select obj).Max();

           Console.WriteLine($"Maximum value =  {mixedLinq}");
            Console.ReadLine();
           
        }


       

        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}
