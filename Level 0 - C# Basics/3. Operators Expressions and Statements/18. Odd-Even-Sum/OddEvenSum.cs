using System;

class OddEvenSum
{
    static void Main()
    {
        int sum, diff;

        ushort n = byte.Parse(Console.ReadLine());
        int even = 0;
        int odd = 0;

        for (int i = 1; i <= n; i++)
        {
            odd += int.Parse(Console.ReadLine());
            even += int.Parse(Console.ReadLine());
        }

        if (odd == even)
        {
            sum = odd;
            Console.WriteLine("Yes, sum={0}", sum);
        }
        else
        {
            diff = odd - even;
            Console.WriteLine("No, diff={0}", diff);
        }
    }
}
