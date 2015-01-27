using System;

class Arroe
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}{1}{0}", new string('.', (n * 2 - 1 - n) / 2), new string('#', n));

        for (int i = 1; i <= n - 2; i++)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (n * 2 - 1 - n) / 2), '#', new string('.', (n * 2 - 3) / 2));
        }

        Console.WriteLine("{0}{1}{0}", new string('#', n / 2 + 1), new string('.', (n * 2 - 3) / 2));

        for (int i = 1, reverse = n - 2; i <= n - 2; i++, reverse--)
        {
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), '#', new string('.', reverse + reverse - 1));
        }

        Console.WriteLine("{0}{1}{0}", new string('.', n - 1), '#');
    }
}
