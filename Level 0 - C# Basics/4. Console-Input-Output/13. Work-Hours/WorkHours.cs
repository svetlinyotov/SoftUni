using System;

    class WorkHours
    {
        static void Main()
        {
            int workHours = int.Parse(Console.ReadLine());
            int availableDays = int.Parse(Console.ReadLine());
            int productivity = int.Parse(Console.ReadLine());
            double hours = 0;

            hours = (availableDays - ((10.0 / 100) * availableDays)) * 12;
            hours *= productivity / 100.0;
            hours = Math.Floor(hours);

            if ((workHours - hours) * (-1) >= 0)
            {
                Console.WriteLine("Yes");
                Console.WriteLine((workHours - hours) * (-1));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine((workHours - hours) * (-1));
            }
        }
    }
