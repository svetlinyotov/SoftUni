using System;

class Rectangles
{
    static void Main()
    {
        double width, height, parameter, area;

        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        height = double.Parse(Console.ReadLine());
        Console.WriteLine(new string('-', 10));

        parameter = 2 * (width + height);
        area = width * height;

        Console.WriteLine("Parameter: {0}\nArea: {1}", parameter, area);

        Console.WriteLine(String.Empty);


    }
}
