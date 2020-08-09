using System;
using System.Reflection;
[assembly:AssemblyVersion("1.0.0.0")]
namespace cal
{
    public class calc
    {
        public int addition(int a, int b)
        {
            Console.WriteLine("New Version");
            return a + b;
        }
        public int multiplication(int a, int b)
        {
            Console.WriteLine("New Version");
            return a * b;
        }

    }
}