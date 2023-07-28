using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Operator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "suyog", Email = "s@gmail.com" },
                new Employee() { Id = 2, Name = "Harshu", Email = "h@gmail.com" },
                new Employee() { Id = 3, Name = "ojasvi", Email = "o@gmail.com" },
                new Employee() { Id = 4, Name = "Supriya", Email = "super@gmail.com" },
            };
            var basicQuery = (from emp in employees
                              select emp).ToList();


            //Operations

            var basicPropQuery = (from emp in employees
                                  select emp.Id).ToList();


            var methodProp = employees.Select(emp => emp.Email).ToList();

            

            foreach (var item in basicQuery)
            {
                Console.WriteLine($"id is {item.Id} name is {item.Name} and email is {item.Email}");
            }


            var basicMethod = employees.ToList();

            Console.WriteLine(basicMethod);

            Console.WriteLine("--------------------------------");

            List<string> strList = new List<string>() { "Sam","Ram","Dom"};

            var methodRes = strList.SelectMany(str => str).ToList();

            var querySyn = (from qs in strList
                            from sr in qs
                            select sr).ToList();


            var nameData = new List<string>() { "Tom","Harry","Ponting","Sachin"};

            var querySyntax = (from qs in nameData
                              where qs.Length > 4
                              select qs).ToList();

            var methodSyntax = nameData.Where(x=>x.Length > 4).ToList();

            var objString = new List<object>() {"sam","Harry","Ram",1,2,3,4 };

            var methodQuery = objString.OfType<string>().Where(x=>x.Length > 3).ToList();

            var queryData = (from item in objString
                            where item is int
                            select item).ToList();



            Console.ReadLine();
        }
    }
}
