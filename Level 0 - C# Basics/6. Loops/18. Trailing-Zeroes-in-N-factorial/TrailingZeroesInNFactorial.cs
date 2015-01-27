using System;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        double traillingZeroesCount = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n / Math.Pow(5, i) > 1)
            {
                traillingZeroesCount += n / Math.Pow(5, i);
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(Math.Floor(traillingZeroesCount));
    }
}
