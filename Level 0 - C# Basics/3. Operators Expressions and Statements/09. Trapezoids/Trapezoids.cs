using System;

class Trapezoids
{
    static void Main()
    {
        double inputA, inputB, inputH, area;

        Console.Write("a = ");
        inputA = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        inputB = double.Parse(Console.ReadLine());
        Console.Write("h = ");
        inputH = double.Parse(Console.ReadLine());

        area = ((inputA + inputB) / 2) * inputH;

        Console.WriteLine("Area = {0}", area);
    }
}
