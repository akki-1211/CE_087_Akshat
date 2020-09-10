using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            for (int j = 1; j < 101; j++)
            {
                numbers.Add(j);
            }
            var evennum = numbers.Where(n => n % 2 == 0);
            var oddnum = numbers.Where(n => n % 2 != 0);
            var min = numbers.Max();
            var max = numbers.Min();
            var avg = numbers.Average();
            Console.WriteLine("Even numbers:");
            int i = 0;
            foreach (int num in evennum)
            {
                Console.Write(num + " ");
                if (i == 10)
                {
                    Console.WriteLine(num + " ");
                    i = 0;
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Odd numbers:");
            i = 0;
            foreach (int num in oddnum)
            {
                Console.Write(num + " ");
                if (i == 10)
                {
                    Console.WriteLine(num + " ");
                    i = 0;
                }
                i++;
                
            }
            Console.WriteLine();
            Console.WriteLine("Avg Value {0}", avg);
            Console.WriteLine("Maximum value {0} and Minimum value {1}", max, min);
            Console.ReadKey();

        }
    }
}
