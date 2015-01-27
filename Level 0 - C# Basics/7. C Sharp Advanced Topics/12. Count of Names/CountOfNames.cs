using System;
using System.Collections.Generic;
using System.Linq;

class CountOfNames
{
    static void Main()
    {
        string[] row1 = Console.ReadLine().Split(' ');
        List<string> sequence1 = new List<string>();

        for (int i = 0; i < row1.Length; i++)
        {
            sequence1.Add(row1[i]);
        }

        var query = sequence1.GroupBy(x => x).OrderBy(x => x.Key);

        foreach (var result in query)
        {
            Console.WriteLine("\"{0}\" -> {1}", result.Key, result.Count());
        }
    }
}
