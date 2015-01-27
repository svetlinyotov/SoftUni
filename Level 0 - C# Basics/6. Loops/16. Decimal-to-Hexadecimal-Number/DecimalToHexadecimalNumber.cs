using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());

        string hexResult = "";

        while (true)
        {

            string reminder = Convert.ToString(decimalNumber % 16);
            decimalNumber /= 16;

            switch (reminder)
            {
                case "10": reminder = "A"; break;
                case "11": reminder = "B"; break;
                case "12": reminder = "C"; break;
                case "13": reminder = "D"; break;
                case "14": reminder = "E"; break;
                case "15": reminder = "F"; break;
            }

            hexResult = reminder + hexResult;

            if (decimalNumber == 0)
            {
                break;
            }
        }

        Console.WriteLine(hexResult);
    }
}
