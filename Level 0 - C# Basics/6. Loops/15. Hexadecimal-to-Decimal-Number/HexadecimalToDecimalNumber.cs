using System;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        string hex = Console.ReadLine();
        long decimalNumber = 0;


        for (int i = hex.Length - 1, counter = 0; i >= 0; i--, counter++)
        {
            string letter = "";

            switch (hex[i])
            {
                case 'A': letter = "10"; break;
                case 'B': letter = "11"; break;
                case 'C': letter = "12"; break;
                case 'D': letter = "13"; break;
                case 'E': letter = "14"; break;
                case 'F': letter = "15"; break;
            }

            long number = (letter != "") ? Convert.ToInt64(letter) : Convert.ToInt64(Char.GetNumericValue(hex[i]));

            decimalNumber +=  number * (long)Math.Pow(16, counter);
        }

        Console.WriteLine(decimalNumber);

    }
}
