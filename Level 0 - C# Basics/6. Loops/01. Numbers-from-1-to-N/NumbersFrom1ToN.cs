using System;

class NumbersFrom1ToN
{
    static void Main()
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());

        string sequence = "";

        for (int i = 1; i <= number; i++)
        {
            sequence += i + " ";
        }

        Console.WriteLine(sequence);
    }
}
