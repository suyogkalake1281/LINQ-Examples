// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace fibbo
{
     class Program
    {
        static void Main(string[] args)
        {
            var fibboNumber = new List<int>{ 1,1};

            while (fibboNumber.Count < 20)
            {
                var fib1 = fibboNumber[fibboNumber.Count - 1];
                var fib2 = fibboNumber[fibboNumber.Count - 2];

                fibboNumber.Add(fib1 + fib2);


            }

            foreach (var fib in fibboNumber)
            {
               Console.WriteLine(fib);
                
            }
            

        }
       

    }
}
