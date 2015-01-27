using System;

class ExtractBitFromInt
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("position = ");
        int p = int.Parse(Console.ReadLine());

        int mask = n >> p;
        int bit = mask & 1;

        Console.WriteLine("Bit = {0}", bit);
    }
}
