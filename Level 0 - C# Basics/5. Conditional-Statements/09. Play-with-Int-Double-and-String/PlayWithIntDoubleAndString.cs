using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");

        Console.WriteLine(String.Empty);

        int choice = int.Parse(Console.ReadLine());
        
        Console.WriteLine(String.Empty);

        if (choice == 1)
        {
            Console.Write("Please enter an int: ");
            int intChoice = int.Parse(Console.ReadLine());
            Console.WriteLine(intChoice + 1);
        }
        else if (choice == 2)
        {
            Console.Write("Please enter a double: ");
            double doubleChoice = double.Parse(Console.ReadLine());
            Console.WriteLine(doubleChoice + 1.0);
        }
        else if (choice == 3)
        {
            Console.Write("Please enter a string: ");
            string stringChoice = Console.ReadLine();
            Console.WriteLine(stringChoice + "*");
        }
    }
}
