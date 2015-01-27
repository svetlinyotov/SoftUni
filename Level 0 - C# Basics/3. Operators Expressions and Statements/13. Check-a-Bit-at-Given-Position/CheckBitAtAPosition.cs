using System;

class CheckBitAtAPosition
{
    static void Main()
    {
        Console.Write("Number = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Position = ");
        int p = int.Parse(Console.ReadLine());

        int mask = n >> p;
        int bit = mask & 1;

        bool isBitEquals1 = (bit == 1);

        Console.WriteLine(isBitEquals1);
    }
}
