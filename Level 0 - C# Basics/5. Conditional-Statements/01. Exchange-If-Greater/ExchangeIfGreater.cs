using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("a = {0} b = {1}", a, b);

        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        Console.WriteLine("a = {0} b = {1}", a, b);
    }
}
