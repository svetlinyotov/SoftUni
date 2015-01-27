using System;

class PointInACircle
{
    static void Main()
    {
        double circleX, circleY, circleRadius, inputX, inputY;

        circleX = 0;
        circleY = 0;
        circleRadius = 2;

        Console.Write("x = ");
        inputX = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        inputY = double.Parse(Console.ReadLine());

        /*
         * Pythagorean theorem (a^2 + b^2 = c^2) 
         * a = lenght of the triangle's side on x
         * b = lenght of the triangle's side on y
         * c = lenght of the hypotenuse on radius
         */

        bool isInCircle = (Math.Pow((inputX - circleX), 2) + Math.Pow((inputY - circleY), 2) <= Math.Pow(circleRadius, 2)); 

        Console.WriteLine(isInCircle);
    }
}