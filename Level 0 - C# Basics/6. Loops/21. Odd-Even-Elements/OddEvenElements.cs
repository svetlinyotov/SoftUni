using System;
using System.Linq;
using System.Collections.Generic;

class OddEvenElements
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture =
            System.Globalization.CultureInfo.InvariantCulture;

        string[] numbers = Console.ReadLine().Split(' ');

        if (numbers[0] == "")
        {
            numbers = new string[0];
        }

        if (numbers.Length == 0)
        {
            Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
            return;
        }

        List<double> oddNumbers = new List<double>();
        List<double> evenNumbers = new List<double>();

        for (int i = 0; i < numbers.Length; i += 2)
        {
            oddNumbers.Add(Convert.ToDouble(numbers[i]));
        }
        for (int i = 1; i < numbers.Length; i += 2)
        {
            evenNumbers.Add(Convert.ToDouble(numbers[i]));
        }

        double evenSum = 0;
        double evenMin = 0;
        double evenMax = 0;
        double oddSum = oddNumbers.Sum();
        double oddMin = oddNumbers.Min();
        double oddMax = oddNumbers.Max();

        
        if (evenNumbers.Count == 0)
        {
            Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", oddSum, oddMin, oddMax);
            return;
        }
        else
        {
            evenSum = evenNumbers.Sum();
            evenMin = evenNumbers.Min();
            evenMax = evenNumbers.Max();
        }

        Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
    }
}
