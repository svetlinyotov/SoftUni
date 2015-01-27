using System;

class ExamSchedule
{
    static void Main()
    {
        int startHour = int.Parse(Console.ReadLine());
        int startMin = int.Parse(Console.ReadLine());
        string startDayPart = Console.ReadLine();
        int durationHour = int.Parse(Console.ReadLine());
        int durationMins = int.Parse(Console.ReadLine());

        if (startDayPart == "PM")
        {
            startHour += 12;
        }

        DateTime startTime = new DateTime(2014, 1, 1, startHour, startMin, 0);

        DateTime endTime = startTime.AddHours(durationHour).AddMinutes(durationMins);

        Console.WriteLine(endTime.ToString("hh:mm:tt"));
    }
}
