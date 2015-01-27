using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());

        string sequence = "";

        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            {
                sequence += i + " ";
            }
        }

        Console.WriteLine(sequence);
    }
}
