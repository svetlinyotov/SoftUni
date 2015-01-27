using System;

class HalfSum
{
    static void Main()
    {
        ushort nNumber = ushort.Parse(Console.ReadLine());
        int firstSum = 0;
        int secondSum = 0;

        for (int i = 1; i <= nNumber; i++)
        {
            int summedNumber = int.Parse(Console.ReadLine()); // Input of the first sequence
            firstSum += summedNumber;
        }

        for (int i = 1; i <= nNumber; i++)
        {
            int summedNumber = int.Parse(Console.ReadLine()); // Input of the second sequence
            secondSum += summedNumber;
        }

        if (firstSum == secondSum)
        {
            Console.WriteLine("Yes, sum = {0}", firstSum);
        }
        else
        {
            int difference = Math.Abs(firstSum - secondSum);
            Console.WriteLine("No, diff = {0}", difference);
        }



    }
}
