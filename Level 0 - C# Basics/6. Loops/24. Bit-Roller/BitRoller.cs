using System;
using System.Collections.Generic;
using System.Linq;

class BitRoller
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        string number = "";

        char[] binary = Convert.ToString(n, 2).PadLeft(19, '0').ToCharArray();
        List<char> chars = new List<char>();

        foreach (var digit in binary)
        {
            chars.Add(digit);
        }

        for (int i = 0; i < r; i++)
        {

            ListsFunction.MoveItemAtIndexToFront(chars, chars.Count - 1);

            int first = 0;
            int second = 0;

            if (f > 0)
            {
                first = 19 - f;
                second = 19 - f - 1;
            }
            else
            {
                first = 18;
                second = 0;
            }

            

            var currentItem = chars[first];
            var nextItem = chars[second];
            chars.RemoveAt(first);
            chars.RemoveAt(second);
            chars.Insert(second, currentItem);
            chars.Insert(first, nextItem);

        }

        foreach (var digit in chars)
        {
            number += digit;
        }


        Console.WriteLine(Convert.ToInt32(number, 2));

    }



}

static class ListsFunction
{
    public static char MoveItemAtIndexToFront<T>(this List<T> list, int index)
    {
        T item = list[index];
        for (int i = index; i > 0; i--)
            list[i] = list[i - 1];
        list[0] = item;
        return ' ';
    }
}