using System;

class PrimeNumbers
{
    static void Main()
    {
        int countNumbers = 0;
        bool isPrime = false;

        Console.Write("Number: ");
        int checkedNumber = int.Parse(Console.ReadLine());
        if (checkedNumber > 0)
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((checkedNumber % 1 == 0) && (checkedNumber % i == 0))
                {
                    countNumbers++;
                }

            }

            isPrime = (countNumbers != 2) ? false : true;
        }

        Console.WriteLine(isPrime);
    }
}
