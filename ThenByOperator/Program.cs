using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThenByOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentData = new List<Student>()
            {
                new Student() { Id = 1,FirstName= "Suyog",LastName="Kalake",Email="s@gmail.com"},
                new Student() { Id = 2,FirstName="oju",LastName="Patil", Email="o@gmail.com"},
                 new Student() { Id = 2,FirstName="sam",LastName="Patil", Email="f@gmail.com"}





            };
            var ms = studentData.OrderBy(emp => emp.Id).ToList();

            int[] rollNums = new int[]{1, 2, 3, 4, 5, 6, 7, 8};
            _ = rollNums.Reverse();

            var mq = rollNums.Reverse();
            foreach (var student in mq)
            {
                Console.WriteLine(student);
            }
            Console.ReadLine();
        }
        
    }
}
