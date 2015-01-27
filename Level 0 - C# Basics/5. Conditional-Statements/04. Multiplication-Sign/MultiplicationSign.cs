using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        string result = "";
        int countMinus = 0;

        if (a == 0)
        {
            result = "0";
        }
        if (b == 0)
        {
            result = "0";
        }
        if (c == 0)
        {
            result = "0";
        }

        if (result != "0")
        {
            if (a < 0)
            {
                countMinus++;
            }
            if (b < 0)
            {
                countMinus++;
            }
            if (c < 0)
            {
                countMinus++;
            }

            if (countMinus % 2 == 0)
            {
                result = "+";
            }
            else
            {
                result = "-";
            }
        }

        Console.WriteLine(result);
    }
}
