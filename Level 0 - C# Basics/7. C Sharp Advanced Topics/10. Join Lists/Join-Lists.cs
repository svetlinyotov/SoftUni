using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] row1 = Console.ReadLine().Split(' ');
        string[] row2 = Console.ReadLine().Split(' ');
        List<int> sequence1 = new List<int>();
        List<int> sequence2 = new List<int>();
        
        for (int i = 0; i < row1.Length; i++)
        {
            sequence1.Add(Convert.ToInt32(row1[i]));
        }

        for (int i = 0; i < row2.Length; i++)
        {
            sequence2.Add(Convert.ToInt32(row2[i]));
        }

        sequence1.AddRange(sequence2);
        sequence1 = sequence1.Distinct().ToList();
        sequence1.Sort();

        foreach (var item in sequence1)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
