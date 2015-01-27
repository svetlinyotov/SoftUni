using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Biggest num: {0}", Math.Max(a, Math.Max(b, c)));
    }
}
