using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());

        Console.WriteLine(String.Empty);

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
