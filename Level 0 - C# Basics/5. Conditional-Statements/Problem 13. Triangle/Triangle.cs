using System;

class Triangle
{
    static void Main()
    {
        double Ax = double.Parse(Console.ReadLine());
        double Ay = double.Parse(Console.ReadLine());
        double Bx = double.Parse(Console.ReadLine());
        double By = double.Parse(Console.ReadLine());
        double Cx = double.Parse(Console.ReadLine());
        double Cy = double.Parse(Console.ReadLine());

        double aSide = Math.Sqrt(Math.Pow((Bx - Ax), 2) + Math.Pow((By - Ay), 2));
        double bSide = Math.Sqrt(Math.Pow((Cx - Bx), 2) + Math.Pow((Cy - By), 2));
        double cSide = Math.Sqrt(Math.Pow((Ax - Cx), 2) + Math.Pow((Ay - Cy), 2));

        if (aSide + bSide > cSide && bSide + cSide > aSide && aSide + cSide > bSide)
        {
            double halfParametr = (aSide + bSide + cSide) / 2;
            double Area = Math.Sqrt(halfParametr * (halfParametr - aSide) * (halfParametr - bSide) * (halfParametr - cSide));

            Console.WriteLine("Yes");
            Console.WriteLine("{0:0.00}", Area);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:0.00}", aSide);
        }

        


    }
}
