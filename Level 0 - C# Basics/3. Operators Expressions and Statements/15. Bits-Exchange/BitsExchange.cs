using System;

class BitsExchange
{
    static void Main()
    {
        uint number, firstMask, secondMask, firstSegment, secondSegment, firstFinalMask, secondFinalMask;
        object exchange;

        Console.Write("Number: ");
        number = uint.Parse(Console.ReadLine()); // 01000100 00000000 01000000 00010101 = 1140867093

        firstMask = number >> 3;         // 00001000 10000000 00001000 00000010
        firstSegment = firstMask & 7;    // 00000000 00000000 00000000 00000111
                                         //                                 010

        secondMask = number >> 24;       // 00000000 00000000 00000000 01000100
        secondSegment = secondMask & 7;  // 00000000 00000000 00000000 00000111
                                         //                                 100

        firstFinalMask = secondSegment << 3;             // 00000010 00000000 00000000 00000000
        secondFinalMask = firstSegment << 24;            // 00000000 00000000 00000000 00100000

        exchange = (number & (~(7 << 3) & ~(7 << 24)))|(firstFinalMask | secondFinalMask);

        // 01000100 00000000 01000000 00010101
        // 11111000 11111111 11111111 11000111 (~(7 << 3) & ~(7 << 24))
        // ------------------------------------ &
        // 01000000 00000000 01000000 00000111

        // 01000000 00000000 01000000 00000111
        // 00000010 00000000 00000000 00100000 (firstFinalMask | secondFinalMask)
        // ------------------------------------ |
        // 01000010 00000000 01000000 00100101


        Console.WriteLine(exchange);
        




    }
}

