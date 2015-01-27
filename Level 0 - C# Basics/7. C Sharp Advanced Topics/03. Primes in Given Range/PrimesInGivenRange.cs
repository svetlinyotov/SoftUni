using System;
using System.Collections.Generic;
using System.Linq;

class PrimesInGivenRange
{
    static void Main()
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        int counter = 0;

        foreach (var item in FindPrimesInRange(startNum, endNum))
        {
            if (counter + 1 == (FindPrimesInRange(startNum, endNum).Count()))
            {
                Console.Write(item);
            }
            else
            {
                Console.Write(item + ", ");
            }
            counter++;
        }

        if (counter == 0)
        {
            Console.WriteLine("(empty list)");
        }
        else
        {
            Console.WriteLine();
        }
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> numbers = new List<int>();

        for (int i = startNum; i < endNum; i++)
        {
            if (isPrime(i))
            {
                numbers.Add(i);
            }
        }

        return numbers;
    }

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


}
