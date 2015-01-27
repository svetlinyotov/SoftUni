using System;
using System.Linq;
using System.Collections.Generic;

class Pairs
{
    static void Main()
    {
        string[] number = Console.ReadLine().Split(' ');
        List<int> sumOfPairs = new List<int>();

        for (int pair = 0; pair < number.Length; pair+=2)
        {
            sumOfPairs.Add(Convert.ToInt32(number[pair]) + Convert.ToInt32(number[pair + 1]));
        }

        if (!sumOfPairs.Any(o => o != sumOfPairs[0]))
        {
            Console.WriteLine("Yes, value={0}",sumOfPairs[0]);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", Math.Abs(sumOfPairs.Max() - sumOfPairs.Min()));
        }
    }
}
