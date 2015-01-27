using System;

class QuadraticEquation
{
    static void Main()
    {
        double coefA = double.Parse(Console.ReadLine());
        double coefB = double.Parse(Console.ReadLine());
        double coefC = double.Parse(Console.ReadLine());
        
        double discriminant, root1, root2;

        discriminant = Math.Pow(coefB, 2) - (4 * coefA * coefC);

        if (discriminant > 0)
        {
            root1 = (-coefB - Math.Sqrt(discriminant)) / (2 * coefA);
            root2 = (-coefB + Math.Sqrt(discriminant)) / (2 * coefA);
            Console.WriteLine("root1 = {0} \nroot2 = {1}", root1, root2);
        }
        else if (discriminant == 0)
        {
            root1 = root2 = (-coefB) / (2 * coefA);
            Console.WriteLine("root1 = root2 = {0}", root1);
        }
        else
        {
            Console.WriteLine("No real roots (D < 0)");
        }

    }
}
