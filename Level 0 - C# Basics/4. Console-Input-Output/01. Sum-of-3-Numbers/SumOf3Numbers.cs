using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("a = ");
        double numberA = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double numberB = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double numberC = double.Parse(Console.ReadLine());

        double sum = numberA + numberB + numberC;

        Console.WriteLine(new string('-', 20));
        Console.WriteLine("a + b + c = {0} + {1} + {2} = {3}", numberA, numberB, numberC, sum);
    }
}
