using System;

class FibonacciNumbers
{
    static uint fibonacciNumber(uint n)
    {
        uint firstN = 1;
        uint secondN = 1;
        uint thirdN = 2;

        for (int i = 0; i < n; i++)
        {
            
                thirdN = secondN + firstN;
                firstN = secondN;
                secondN = thirdN;
            
        }

        return firstN;
    }

    static void Main()
    {
        Console.Write("Enter n-th number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine(fibonacciNumber(number));
    }
}
