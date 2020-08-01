using System;
public class add
{
    static void Main(String[] args)
	{
        Console.WriteLine("Enter Two Numbers:");
        int x = Int32.Parse(Console.ReadLine());
        int y = Int32.Parse(Console.ReadLine());
        Console.WriteLine(x+y);
        Console.ReadKey();
	}
}
