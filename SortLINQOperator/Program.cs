using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SortLINQOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var datasourceInt = new List<int>() { 11,33,47,1,4,8,99,103};

            var orderData = (from dt in datasourceInt
                             where dt > 10             // using query syntax
                            orderby dt
                            select dt).ToList();

            var descenData = from data in datasourceInt
                             orderby data descending
                             select data;

            var methodSyntax = datasourceInt.Where(d=>d>11).OrderBy(x => x).ToList(); // using Method syntax


            var orderByDesc = datasourceInt.OrderByDescending(x => x).ToList(); // using Method syntax


            foreach (var item in orderByDesc)
            {
                Console.WriteLine(item);
            }

          
            Console.ReadLine();
        }
       
    }
}
