using System;
using add;
public class driver
{
    static void Main(String[] args)
	{
        addition a = new addition();
        Console.WriteLine("Enter Two Numbers:");
        int x = Int32.Parse(Console.ReadLine());
        int y = Int32.Parse(Console.ReadLine());
        Console.WriteLine(a.add(y,x));
        Console.ReadKey();
	}
}
