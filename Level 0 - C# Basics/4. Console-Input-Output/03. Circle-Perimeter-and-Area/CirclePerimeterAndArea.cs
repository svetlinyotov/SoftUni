using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Radius = ");
        double r = double.Parse(Console.ReadLine());

        double pi = Math.PI;
        double P = 2 * pi * r;
        double A = pi * Math.Pow(r, 2);

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Perimeter = {0:0.00}", P);
        Console.WriteLine("Area = {0:0.00}", A);
    }
}
