using System;

class FibonacciNumbers
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint firstN = 0;
        uint secondN = 1;
        uint thirdN = 1;
        string fibonacciSequence = "";

        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                fibonacciSequence += "0 ";
            }
            else
            {
                fibonacciSequence += Convert.ToString(thirdN) + " ";
                thirdN = secondN + firstN;
                firstN = secondN;
                secondN = thirdN;
            }
        }

        Console.WriteLine(fibonacciSequence);
    }
}
