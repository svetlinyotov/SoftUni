using System;

class SumOf5Numbers
{
    static void Main()
    {
        string numbers = Console.ReadLine();
        string[] arrNumbers = numbers.Split(' ');
        double sum = 0;

        for (int i = 0; i < arrNumbers.Length; i++)
        {
            sum += Convert.ToDouble(arrNumbers[i]);
        }

        Console.WriteLine(new string('-', 20));
        Console.WriteLine("Sum = {0}", sum);
    }
}
