using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantifieroperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Student> students = new List<Student>()
            {
                new Student(){Name="john",Marks=80},
                new Student(){Name="Lee",Marks=75}
            };

            var ms = students.All(s => s.Marks > 70);
            Console.WriteLine(ms);

            var qm = (from s in students
                     select s).All(s=>s.Marks > 75);
            Console.WriteLine(qm);


            Console.WriteLine("____________Any Operator__________");

            List<int> num  = new List<int>() { 1,2,3,4,5,6};

            var nums = num.Any();
            Console.WriteLine(nums);


            Console.WriteLine("Contains Operator__________");

            List<string> name = new List<string>() { "Kim", "john", "jcob", "doe" };

            var isExist = name.Contains("doe");

            Console.WriteLine(isExist);


            Console.ReadLine();

        }
    }


    public class Student
    {
        public int Marks { get; set; }
        public string Name { get; set; }

        
       
    }
    class Subject
    {
        public string SubName { get; set;}
        public int SubMarks { get; set; }
    }
}
