using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ELementOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1,2,3,4,5,6,7,8};

            Console.WriteLine("------------------Element At & ElementAtorDefault______________________");

            var ms = num.Where(x=>x>3).ElementAt(3);

            var eledefault = num.ElementAtOrDefault(11);

            var mixedsyntax = (from n in num
                              select n).ElementAt(2);

            Console.WriteLine("------------------First & FirstOrDefault______________");

            var usingWhere = num.Where(x=>x>5).First();
            var usingWher1e = num.Where(x => x > 15).FirstOrDefault();


            var usingFirst = num.First(x=>x>5);
            var usingFirst1 = num.FirstOrDefault(x => x > 15);

          

            List<User> users = new List<User>() {new User()
            {
                Id=1,UserName="admin",Password="admin"

            } ,
            new User() { Id=2,UserName="admin1",Password="admin1"},
            new User() { Id=3,UserName="admin2",Password="admin2"},
            new User() { Id=4,UserName="admin3",Password="admin3"},
            };


            Console.WriteLine("------------------Last & LastOrDefault-------------------");

            List<int> sequenceNum = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8,9,10 };

            var last1 = sequenceNum.Last();
            var last2 = sequenceNum.LastOrDefault(x=>x>15);
            Console.WriteLine(last1);
            Console.WriteLine(last2);


            Console.WriteLine("------------------SIngle & SingleORdefault-------------------");

            List<int> numData = new List<int>() { 1,2,3};

            var newData = numData.SingleOrDefault(x=>x>12);

            Console.WriteLine(newData);


            Console.ReadLine();
        }
    }

    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
