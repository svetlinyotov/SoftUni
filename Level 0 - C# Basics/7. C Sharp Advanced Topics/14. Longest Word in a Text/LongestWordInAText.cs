using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


class LongestWordInAText
{
    static void Main()
    {
        string[] text = Console.ReadLine().Split(' ');
        string word = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i].Length > word.Length)
            {
                word = text[i];
            }
        }
        Console.WriteLine(word);
    }

}

