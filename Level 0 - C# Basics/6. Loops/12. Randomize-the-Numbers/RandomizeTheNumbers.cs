using System;
using System.Collections.Generic;
using System.Linq;

class RandomizeTheNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int max = n;

        List<int> usedNums = new List<int>();

        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            int randNum = random.Next(1, max + 1);

            while (usedNums.Contains(randNum))
            {
                randNum = random.Next(1, max + 1);
            }

            usedNums.Add(randNum);

            Console.Write(randNum + " ");
        }

        Console.WriteLine(String.Empty);
    }
}
