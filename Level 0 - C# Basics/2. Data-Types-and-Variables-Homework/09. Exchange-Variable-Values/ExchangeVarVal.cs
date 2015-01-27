using System;

class ExchangeVarVal
{
    static void Main()
    {
        int a = 5;
        int b = 10;

        Console.WriteLine("Before the exchange");
        Console.WriteLine("a = {0} \nb = {1}", a, b);

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine("\n\nAfter the exchange");
        Console.WriteLine("a = {0} \nb = {1}", a, b);
    }
}

