using System;

class DivideBy7And5
{
    static void Main()
    {
        int checkedNumber = 140;
        bool result = ((checkedNumber % 5 == 0) && (checkedNumber % 7 == 0) && (checkedNumber != 0));

        Console.WriteLine(result);
    }
}
