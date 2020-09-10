using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "karma", "akshat", "mubarak", "lucy", "hulk", "krunal", "aum", "kunj", "om", "binod" };
            var res1 = names.Where(n => n.StartsWith("k"));
            Console.WriteLine("Names which have first letter 'K' is");
            foreach (string s in res1)
                Console.WriteLine(s);
            //Console.ReadKey();
            var res2 = names.Where(n => n.Length < 4);
            Console.WriteLine("Names which have length less than 4");
            foreach (string s in res2)
                Console.WriteLine(s);
            //Console.ReadKey();
            var res3 = names.Where(n => n.Length == 3);
            Console.WriteLine("Names which have length equal to 3");
            foreach (string s in res3)
                Console.WriteLine(s);
            //Console.ReadKey();
            var res4 = names.OrderBy(n => n);
            Console.WriteLine("Names in Ascending Order");
            foreach (string s in res4)
                Console.Write(s+" ");
            Console.ReadKey();
        }
    }
}
