using System;

class MagicDates
{
    static void Main()
    {
        int startYear = int.Parse(Console.ReadLine());
        int endYear = int.Parse(Console.ReadLine());
        int weightInput = int.Parse(Console.ReadLine());
        int count = 0;

        DateTime startDate = new DateTime(startYear, 1, 1);
        DateTime endDate = new DateTime(endYear, 12, 31);

        for (DateTime day = startDate; day <= endDate; day = day.AddDays(1))
        {
            int digit1 = day.Day / 10;
            int digit2 = day.Day % 10;
            int digit3 = day.Month / 10;
            int digit4 = day.Month % 10;
            int digit5 = (day.Year / 1000) % 10;
            int digit6 = (day.Year / 100) % 10;
            int digit7 = (day.Year / 10) % 10;
            int digit8 = (day.Year / 1) % 10;
            
            int[] digits = {digit1, digit2, digit3, digit4, digit5, digit6, digit7, digit8};
            int weight = 0;

            for (int first = 0; first < digits.Length; first++)
            {
                for (int second = first+1; second < digits.Length; second++)
                {
                    weight += digits[first] * digits[second];
                }
            }

            if (weight == weightInput)
            {
                Console.WriteLine(day.ToString("dd-MM-yyyy"));
                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }

    }
}
