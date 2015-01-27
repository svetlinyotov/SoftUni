using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Numbers: ");
        string[] numbers = Console.ReadLine().Split(' ');

        int sumOfOdd = 1;
        int sumOfEven = 1;

        for (int i = 0; i < numbers.Length; i+=2)
        {
            sumOfOdd *= Convert.ToInt32(numbers[i]);
        }

        for (int i = 1; i < numbers.Length; i += 2)
        {
            sumOfEven *= Convert.ToInt32(numbers[i]);
        }

        if (sumOfOdd == sumOfEven)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = " + sumOfEven);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + sumOfOdd);
            Console.WriteLine("even_product = " + sumOfEven);
        }

    }
}
