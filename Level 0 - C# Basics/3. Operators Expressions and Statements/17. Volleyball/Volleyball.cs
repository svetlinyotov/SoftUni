using System;

class Volleyball
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        ushort numOfHolidays = ushort.Parse(Console.ReadLine());
        byte numOfHometownWeekends = byte.Parse(Console.ReadLine());
        byte numOfTotalWeekends = 48;
        double numOfPlays = 0;
        double additionalPlays = 0;

        if (yearType == "leap")
        {
            additionalPlays = 0.15;
        }

        numOfPlays += numOfHometownWeekends;
        numOfPlays += (numOfTotalWeekends - numOfHometownWeekends) * (3.0 / 4.0);
        numOfPlays += numOfHolidays * (2.0 / 3.0);
        numOfPlays += additionalPlays * numOfPlays;
        numOfPlays = Math.Floor(numOfPlays);

        Console.WriteLine(numOfPlays);

    }
}
