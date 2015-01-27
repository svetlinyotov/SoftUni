using System;

class ComparingFloats
{
    static void Main()
    {
        double a, b, epsilon;

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());

        epsilon = 0.000001;

        double absA = Math.Abs(a);
        double absB = Math.Abs(b);
        double diff = Math.Abs(a - b);

        if (a == b)
        {
            Console.WriteLine("The numbers are absouletly equal");
        }
        else if (diff < epsilon)
        {
            Console.WriteLine("The numbers are nearly equal");
        }
        else if (diff >= epsilon)
        {
            Console.WriteLine("The numbers are not equal");
        }
    }
}
