using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        BigInteger n = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine(factorial(2 * n) / (factorial(n + 1) * factorial(n)));

    }

    static private BigInteger factorial(BigInteger number)
    {
        if (number != 0)
        {
            for (BigInteger i = number; i >= 2; i--)
            {
                number *= i - 1;
            }
        }
        else
        {
            number = 1;
        }
        return number;
    }
}
