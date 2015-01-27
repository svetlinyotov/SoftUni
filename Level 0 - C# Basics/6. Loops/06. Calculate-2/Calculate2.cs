using System;

class Calculate2
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        double factN = 1;
        double factK = 1;

        for (int i = n; i >= 1; i--)
        {
            factN *= i;
            if (i == k)
            {
                factK *= i;
                k--;
            }
        }

        Console.WriteLine("{0}", factN / factK);
    }
}
