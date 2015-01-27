using System;
using System.Collections.Generic;
using System.Linq;

class SortingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arrN = new int[n];

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            arrN[i] = num;
        }

        int[] arrOrdered = arrN.OrderBy(c => c).ToArray();
        Console.WriteLine(new string('-', 3));
        foreach (var item in arrOrdered)
        {
            Console.WriteLine(item);
        }
    }
}
