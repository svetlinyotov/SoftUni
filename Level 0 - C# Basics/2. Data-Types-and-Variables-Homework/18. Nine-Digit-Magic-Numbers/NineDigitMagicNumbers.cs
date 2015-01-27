using System;

class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine()); // Sum
        int diff = int.Parse(Console.ReadLine()); // Diff
        int resultsCount = 0;
        int num1, num2, num3 = 0;

        for (num1 = 111; num1 <= 777; num1++)
        {
            num2 = num1 + diff;
            num3 = num2 + diff;

            if (CalcSumOfDigits(num1) + CalcSumOfDigits(num2) + CalcSumOfDigits(num3) == sum &&
                (num3 <= 777) &&
                IsAllowedNumber(num1) && IsAllowedNumber(num2) && IsAllowedNumber(num3))
            {
                Console.WriteLine("{0}{1}{2}", num1, num2, num3);
                resultsCount++;
            }
        }

        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalcSumOfDigits(int n)
    {
        int sum = 0;
        while (n != 0)
        {
            sum += n % 10;
            n /= 10;
        }

        return sum;
    }

    private static bool IsAllowedNumber(int n)
    {
        string number = n.ToString();
        foreach (var num in number)
        {
            if (num < '1' || num > '7')
            {
                return false;
            }
        }
        return true;
    }
}
