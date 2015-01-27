using System;

class BitsUp
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        int position;
        position = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            for (int bit = 7; bit >= 0; bit--)
            {
                if ((position % step == 1) || (step == 1 && position > 0))
                {
                    number = number | (1 << bit);
                }

                position++;

            }
            Console.WriteLine(number);
        }
        
    }
}
