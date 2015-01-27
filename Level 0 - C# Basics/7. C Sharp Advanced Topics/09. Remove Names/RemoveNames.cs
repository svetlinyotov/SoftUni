using System;
using System.Collections.Generic;
using System.Linq;

class RemoveNames
{
    static void Main()
    {
        string[] names1 = Console.ReadLine().Split(' ');
        string[] names2 = Console.ReadLine().Split(' ');

        var remain = names1.Except(names2).ToArray();

        foreach (var item in remain)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
