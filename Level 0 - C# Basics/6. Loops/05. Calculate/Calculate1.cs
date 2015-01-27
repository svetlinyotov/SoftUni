using System;

class Calculate
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        double sum = 1;
        double fact = 1;
        double multiply = 1;

        for (int i = 1; i <= n; i++)
        {
            fact *= i;
            multiply *= x;
            sum += fact / multiply;
        }

        Console.WriteLine("{0:0.00000}", sum);
    }
}
