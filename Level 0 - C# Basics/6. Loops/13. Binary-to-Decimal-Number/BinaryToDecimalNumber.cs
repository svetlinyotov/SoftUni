using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string binary = Console.ReadLine();
        long decimalNumber = 0;


        for (int i = binary.Length-1, counter = 0; i >= 0; i--, counter++)
        {
            
            decimalNumber += Convert.ToInt64(Char.GetNumericValue(binary[i])) * (long)Math.Pow(2, counter);
        }

       

        Console.WriteLine(decimalNumber);
    }
}
