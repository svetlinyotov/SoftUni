using System;

class SumOfNNumbers
{
    static void Main()
    {
        uint countOfNumbers = uint.Parse(Console.ReadLine());
        double sum = 0;

        Console.WriteLine("---");

        for (int i = 1; i <= countOfNumbers; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("---");
        Console.WriteLine(sum);

    }
}
