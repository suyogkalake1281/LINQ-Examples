using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParttionaningOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> takeNum = new List<int>() { 1,2,6,7,8, 9,3, 4, 5, };

            Console.WriteLine("_Take Operator _________________");

            var firstData = takeNum.Take(6).ToArray();

            var mixedS = (from tk in takeNum
                         select tk).Take(6).ToList();
            Console.WriteLine(firstData);

            Console.WriteLine("_TakeWhile Operator _________________");

            var tkWhile = takeNum.TakeWhile(x => x < 7).ToArray();
            var where1 = takeNum.Where(x => x < 7).ToArray();

            Console.WriteLine(tkWhile);

            Console.WriteLine("------------Skip Operator _________________");

            var skipData = takeNum.Skip(3).ToArray();
            Console.WriteLine(skipData);

            Console.WriteLine("------------SkipWhile Operator _________________");

            List<int> skip1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            var skipWhile = skip1.SkipWhile(x => x < 7).ToArray();
            Console.WriteLine(skipWhile);




            Console.ReadLine();
        }
    }
}
