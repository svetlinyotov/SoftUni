using System;

class Joro
{
    static void Main()
    {
        string leap = Console.ReadLine(); // Leap or non-leap year (t or f)
        ushort holidaysCount = ushort.Parse(Console.ReadLine()); // Holidays
        byte weekendsHomeCount = byte.Parse(Console.ReadLine()); // Weekends in hometown

        byte weeksInYear = 52;
        int normalWeekends = weeksInYear - weekendsHomeCount;
        double playsCount = 0;

        playsCount += weekendsHomeCount;
        playsCount += normalWeekends * (2D / 3D);
        playsCount += holidaysCount * 1D / 2D;
        if (leap == "t")
        {
            playsCount += 3;
        }

        playsCount = Math.Floor(playsCount);

        Console.WriteLine(String.Empty);
        Console.WriteLine(playsCount);

    }
}
