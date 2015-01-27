using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', n / 2), '*');
        for (int i = 1; i <= (n + 1) / 2 - 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (n / 2) - i), '*', new string('.', i * 2 - 1));
        }
        Console.WriteLine("{0}", new string('*', n));

        for (int i = 1; i <= n - ((n + 1) / 2); i++)
        {
            if (i != n - ((n + 1) / 2))
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 4), '*', new string('.', n - 2*(n/4) - 2));
            }
            else
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', n / 4), '*', new string('*', n - 2 * (n / 4) - 2));
            }
            
        }
    }
}
