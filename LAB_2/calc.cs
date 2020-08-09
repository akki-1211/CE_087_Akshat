using System;
using System.Reflection;
//using add;
//using mul;
[assembly: AssemblyVersion("1.0.0.0")]
class calc
{
 
    public static void Main()
    {
        //addition ad = new addition();
        //multiply m = new multiply();
        Console.WriteLine("Enter Two Numbers:");
        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        //Console.WriteLine("Addition:",ad.add(a,b));
        //Console.WriteLine("Muliplication:", m.mul(a, b));
        Console.WriteLine("Addition:{0}",addition(a, b));
        Console.WriteLine("Multiplication:{0}",multiplication(a, b));
        Console.ReadKey();
    }
    public static int addition(int a,int b)
    {
        return a + b;
    }
    public static int multiplication(int a, int b)
    {
        return a * b;
    }

}