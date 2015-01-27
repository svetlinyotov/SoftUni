using System;

class BeerTime
{
    static void Main()
    {
        DateTime timeInput;

        try
        {
            Console.Write("Time (hh:mm tt): ");
            timeInput = DateTime.Parse(Console.ReadLine());
        }
        catch (System.FormatException)
        {

            Console.WriteLine("invalid time"); return;
        }
        

        var beerTimeStart = Convert.ToDateTime(DateTime.Now.ToShortDateString() + " 01:00 PM");
        var beerTimeEnd = Convert.ToDateTime(DateTime.Now.ToShortDateString() + " 02:59 AM");

        if (timeInput.Ticks < beerTimeStart.Ticks && timeInput.Ticks > beerTimeEnd.Ticks)
        {
            Console.WriteLine("non-beer time");
        }
        else
        {
            Console.WriteLine("beer time");
        }

    }
}
