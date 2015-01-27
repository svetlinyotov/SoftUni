using System;

class BitExchangeAdvanced
{
    static void Main()
    {
        long number, result;
        int firstSegmentStart, secondSegmentStart, lenght, lenghtBin, firstMask, secondMask, firstSegment, secondSegment, firstFinalMask, secondFinalMask;

        Console.Write("Number: ");
        number = long.Parse(Console.ReadLine()); // 01000100 00000000 01000000 00010101 = 1140867093
        Console.Write("First Bits Start: ");
        firstSegmentStart = int.Parse(Console.ReadLine()); // p
        Console.Write("Second Bits Start: ");
        secondSegmentStart = int.Parse(Console.ReadLine()); // q
        Console.Write("Lenght: ");
        lenght = int.Parse(Console.ReadLine()); // k

        if (firstSegmentStart + lenght >= 32)
        {
            Console.WriteLine("out of range");
        }
        else if (firstSegmentStart < secondSegmentStart && ((firstSegmentStart + secondSegmentStart) < lenght))
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            lenghtBin = Convert.ToInt32(new string('1', lenght), 2);

            firstMask = (int)number >> firstSegmentStart;
            firstSegment = firstMask & lenghtBin;

            secondMask = (int)number >> secondSegmentStart;
            secondSegment = secondMask & lenghtBin;

            firstFinalMask = secondSegment << firstSegmentStart;
            secondFinalMask = firstSegment << secondSegmentStart;

            result = (number & (~(lenghtBin << firstSegmentStart) & ~(lenghtBin << secondSegmentStart))) | (firstFinalMask | secondFinalMask);


            Console.WriteLine(result);
        }
    }
}
