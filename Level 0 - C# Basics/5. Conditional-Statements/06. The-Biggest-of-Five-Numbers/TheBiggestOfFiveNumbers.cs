﻿using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());

        Console.Write("Biggest number: ");

        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine(a); return;
        }
        if (b >= a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine(b); return;
        }
        if (c >= a && c >= b && c >= d && c >= e)
        {
            Console.WriteLine(c); return;
        }
        if (d >= a && d >= b && d >= c && d >= e)
        {
            Console.WriteLine(d); return;
        }
        if (e >= a && e >= b && e >= c && e >= d)
        {
            Console.WriteLine(e); return;
        }
    }
}
