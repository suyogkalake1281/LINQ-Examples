using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SetOperator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> uniqNum = new List<int>() { 1,2,3,1,2,3,5,6,7,8,4,3};

            var unique = uniqNum.Where(s => s > 3).Distinct().OrderBy(x=>x).ToList();
            Console.WriteLine(unique);


            Console.WriteLine("_______Except Operator______________");

            List<string> dataSource1 = new List<string>() { "A", "B", "C", "D" };
            List<string> dataSource2 = new List<string>() { "C", "D", "E", "F" };

            var exceptData = dataSource1.Except(dataSource2).ToList();

            Console.WriteLine(exceptData);

            Console.WriteLine("Intersect  Operator______________");

            var intersect = dataSource1.Intersect(dataSource2).ToList();
            Console.WriteLine(intersect);


            Console.WriteLine("________________Union  Operator______________");

            var unionApp = dataSource1.Union(dataSource2).ToList();
            Console.WriteLine(unionApp);


            Console.WriteLine("________________Union Operator Using Annonymous function ______________");


            List<Student> data1 = new List<Student>() { new Student()
            {
                Id=1,Name="john"

            },
            new Student(){Id=2,Name="kim"},
            new Student(){Id=3,Name="doe"},
            };
             List<Student> data2 = new List<Student>() { new Student(){Id=1,Name="john"},
                                   new Student(){Id=2,Name="kim"},
                                 new Student(){Id=3,Name="doee"},

            };

            var uniDta = data1.Select(x => new { x.Id, x.Name }).Union(data2.Select(x => new {x.Id, x.Name}).ToList()); 
            Console.WriteLine(uniDta);
            Console.ReadLine();



           
           
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
