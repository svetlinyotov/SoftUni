using System;
using System.Linq;
using System.Collections.Generic;

class MinMaxSumAvg
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> sequence = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            sequence.Add(number);
        }

        Console.WriteLine("min = {0}", sequence.Min());
        Console.WriteLine("max = {0}", sequence.Max());
        Console.WriteLine("sum = {0}", sequence.Sum());
        Console.WriteLine("avg = {0:0.00}", sequence.Average());
    }
}
