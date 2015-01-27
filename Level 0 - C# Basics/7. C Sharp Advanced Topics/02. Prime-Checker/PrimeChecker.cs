using System;

class PrimeChecker
{
    static bool isPrime(long n)
    {
        bool isPrime = true;

        if (n == 0 || n == 1 || 0 > n)
        {
            isPrime = false;
            return isPrime;
        }
        int counter = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                counter++;
            }
        }
        if (counter > 2)
        {
            isPrime = false;
            return isPrime;
        }
        isPrime = true;
        return isPrime;
    }

    static void Main()
    {
        Console.Write("Enter n number: ");
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(isPrime(number)));
    }
}
