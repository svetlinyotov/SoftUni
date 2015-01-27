using System;
using System.Linq;

class FiveSpecialLetters
{
    static void Main()
    {
        long start = long.Parse(Console.ReadLine());
        long end = long.Parse(Console.ReadLine());

        int counter = 0;

        for (char i = 'a'; i <= 'e'; i++)
        {
            for (char i1 = 'a'; i1 <= 'e'; i1++)
            {
                for (char i2 = 'a'; i2 <= 'e'; i2++)
                {
                    for (char i3 = 'a'; i3 <= 'e'; i3++)
                    {
                        for (char i4 = 'a'; i4 <= 'e'; i4++)
                        {
                            string word = "" + i + i1 + i2 + i3 + i4;
                            long weight = convertToNum(word);

                            if (weight >= start && weight <= end)
                            {
                                if (counter > 0)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(word);

                                counter++;
                            }

                        }
                    }
                }
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("No");
        }


    }

    private static long convertToNum(string sequence)
    {

        var word = sequence.ToCharArray().Distinct().ToArray();

        int sum = 0;
        int i = 1;
        foreach (char character in word)
        {
            switch (character)
            {
                case 'a': sum += 5 * i; break;
                case 'b': sum += -12 * i; break;
                case 'c': sum += 47 * i; break;
                case 'd': sum += 7 * i; break;
                case 'e': sum += -32 * i; break;
            }
            i++;
        }

        return sum;
    }
}
