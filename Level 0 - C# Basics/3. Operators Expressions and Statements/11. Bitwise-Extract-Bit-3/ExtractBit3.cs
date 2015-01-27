using System;

class ExtractBit3
{
    static void Main()
    {

        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        
        uint mask = (n >> 3);
        uint bit = mask & 1;

        Console.WriteLine("Bit #3 = {0}", bit);
    }
}