using System;

class NumbersInInterval
{
    static void Main()
    {
        uint start = uint.Parse(Console.ReadLine());
        uint end = uint.Parse(Console.ReadLine());
        uint counter = 0;

        for (uint i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}
