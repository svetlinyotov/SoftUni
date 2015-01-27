using System;

class FourDigitNum
{
    static void Main()
    {
        int abcd, a, b, c, d;

        Console.Write("Number: ");
        abcd = int.Parse(Console.ReadLine());
        a = b = c = d = abcd;

        a /= 1000;
        a %= 10;

        b /= 100;
        b %= 10;

        c /= 10;
        c %= 10;

        d %= 10;

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Number: {0}", abcd);
        Console.WriteLine("Sum of digits: {0}", a + b + c + d);
        Console.WriteLine("Reversed number: " + d + c + b + a);
        Console.WriteLine("Last digit in front: " + d + a + b + c);
        Console.WriteLine("Second and third digits exchanged: " + a + c + b + d);
    }
}
