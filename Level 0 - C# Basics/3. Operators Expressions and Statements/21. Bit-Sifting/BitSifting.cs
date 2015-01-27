using System;

class BitSifting
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int countSieves = int.Parse(Console.ReadLine());
        int countBits = 0;

        for (int i = 0; i < countSieves; i++)
        {
            ulong sieveNumber = ulong.Parse(Console.ReadLine());
            number = (~sieveNumber) & number;
        }

        for (int i = 0; i < 64; i++)
        {
            if ((number & ((ulong)1 << i)) != 0)
            {
                countBits++;
            }
        }

        Console.WriteLine(countBits);
    }

}
