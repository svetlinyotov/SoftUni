using System;

class BitsInverter
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine()); // n input
        byte step = byte.Parse(Console.ReadLine()); // step input
        int index = 0; // In order to find the 11-th bit of teh sequence
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine()); // Number input
            for (int bit = 7; bit >= 0; bit--)
            {
                index++;
                if ((step == 1) || (index % step == 1))
                {
                    num = num ^ (1 << bit);
                }
            }
            Console.WriteLine(num);
        }

    }
}
