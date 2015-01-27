using System;

class ChangeBitAtAPosition
{
    static void Main()
    {
        Console.Write("Number = ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Position = ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Bit Value = ");
        int value = int.Parse(Console.ReadLine());
        

        if (value == 0)
        {
            int mask = ~(1 << position);
            Console.WriteLine(number & mask);
        }
        else if(value == 1)
        {
            int mask = 1 << position;
            Console.WriteLine(number | mask);
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
}
