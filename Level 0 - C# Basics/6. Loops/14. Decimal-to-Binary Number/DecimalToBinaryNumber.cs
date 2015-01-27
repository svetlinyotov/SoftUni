using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        string binaryResult = "";

        while (true)
        {
            
            long reminder = decimalNumber % 2;
            decimalNumber /= 2;
            binaryResult = reminder + binaryResult;

            if (decimalNumber == 0)
            {
                break;
            }
        }

        Console.WriteLine(binaryResult);
    }
}
