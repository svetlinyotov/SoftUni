using System;

class IsThirdDigit7
{
    static void Main()
    {
        int checkedNumber = 9999799;
        checkedNumber /= 100;
        checkedNumber %= 10;
        bool result = (checkedNumber == 7);

        Console.WriteLine(result);

    }
}
