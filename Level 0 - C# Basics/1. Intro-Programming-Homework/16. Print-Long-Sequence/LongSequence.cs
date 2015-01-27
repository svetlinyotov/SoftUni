using System;

class LongSequence
{
    static void Main()
    {
        int start = 2;
        int count = 1000;
        for (int n = start; n <= count + start; n++)
        {
            var definer = (n % 2 == 0) ? 1 : -1;
            Console.WriteLine(definer * n);
        }
    }
}
