using System;

class BitKiller
{
    static void Main()
    {
        int countNumbers = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int position = 0;
        int obtainByte = 0;
        int byteCount = 0;


        for (int i = 0; i < countNumbers; i++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int bit = 7; bit >= 0; bit--)
            {
                if (!((position % step == 1) || (step == 1 && position > 0)))
                {
                    int bitAtPotition = (number >> bit) & 1;
                    obtainByte = obtainByte << 1;
                    obtainByte = obtainByte | bitAtPotition;
                    byteCount++;

                    if (byteCount == 8)
                    {
                        Console.WriteLine(obtainByte);
                        obtainByte = 0;
                        byteCount = 0;
                    }
                }
                position++;

            }
        }

        if (byteCount > 0)
        {
            obtainByte = obtainByte << (8 - byteCount);
            Console.WriteLine(obtainByte);
        }
    }
}
