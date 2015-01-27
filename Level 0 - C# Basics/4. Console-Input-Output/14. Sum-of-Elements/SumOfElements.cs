using System;
using System.Linq;

class SumOfElements
{
    static void Main()
    {
        string[] input = (Console.ReadLine()).Split(' ');
        long[] numbers = Array.ConvertAll(input, long.Parse);
        long sumOfAllArrVals = numbers.Sum();
        long maxVal = numbers.Max();
        long sumOfOthers = sumOfAllArrVals - maxVal;

        if (sumOfOthers == maxVal)
        {
            Console.WriteLine("Yes, sum={0}", sumOfOthers);
        }
        else
        {
            long diff = sumOfOthers - maxVal;
            diff = (diff < 0) ? diff * (-1) : diff;

            Console.WriteLine("No, diff={0}", diff);
        }

        
    }
}
