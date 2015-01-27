using System;

class Sort3NumbersWithNestedIfs
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine(String.Empty);

        if (a > b && a > c)
        {
            Console.Write(a + " ");
            if (b > c)
            {
                Console.Write(b + " ");
                Console.Write(c);
            }
            else
            {
                Console.Write(c + " ");
                Console.Write(b);
            }
        }

        if (b > a && b > c)
        {
            Console.Write(b + " ");
            if (a > c)
            {
                Console.Write(a + " ");
                Console.Write(c);
            }
            else
            {
                Console.Write(c + " ");
                Console.Write(a);
            }
        }

        if (c > a && c > b)
        {
            Console.Write(c + " ");
            if (a > b)
            {
                Console.Write(a + " ");
                Console.Write(b);
            }
            else
            {
                Console.Write(b + " ");
                Console.Write(a);
            }
        }

        if (a == b && b == c)
        {
            Console.WriteLine(a + " " + b + " " + c);
        }

        Console.WriteLine(String.Empty);
    }
}
