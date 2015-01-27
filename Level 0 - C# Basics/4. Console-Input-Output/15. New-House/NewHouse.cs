using System;

class NewHouse
{
    static void Main()
    {
        byte height = byte.Parse(Console.ReadLine());
        int roofStarsCount, roofDashesCount;

        for (int roof = 1; roof <= Math.Ceiling(height / 2.0); roof++)
        {
            roofStarsCount = roof * 2 - 1;
            roofDashesCount = (height - roofStarsCount) / 2;

            Console.WriteLine("{0}{1}{0}", new string('-', roofDashesCount), new string('*', roofStarsCount));
        }

        for (int floor = 1; floor <= height; floor++)
        {
            Console.WriteLine("{0}{1}{0}", '|', new string('*', height - 2));
        }
    }
}
