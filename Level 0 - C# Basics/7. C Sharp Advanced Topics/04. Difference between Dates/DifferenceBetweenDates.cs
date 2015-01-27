using System;
using System.Globalization;

class DifferenceBetweenDates
{
    static void Main()
    {
        string startI = Console.ReadLine();
        string endI = Console.ReadLine();

        DateTime start = DateTime.ParseExact(startI, "d.MM.yyyy", CultureInfo.InvariantCulture);
        DateTime end = DateTime.ParseExact(endI, "d.MM.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine((end - start).Days);
    }
}
