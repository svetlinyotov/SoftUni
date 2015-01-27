using System;

class InCircleOutRectangle
{
    static void Main()
    {
        double circleX, circleY, circleRadius, rectT, rectR, rectB, rectL, inputX, inputY;

        circleX = 1;
        circleY = 1;
        circleRadius = 1.5;
        rectT = 1;
        rectR = 5;
        rectB = -1;
        rectL = -1;

        Console.Write("x = ");
        inputX = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        inputY = double.Parse(Console.ReadLine());

        bool isInCircle = (Math.Pow((inputX - circleX), 2) + Math.Pow((inputY - circleY), 2) <= Math.Pow(circleRadius, 2));
        bool isInRectangle = (inputX >= rectL || inputX <= rectR) && (inputY >= rectB && inputY <= rectT);

        if (isInCircle && !isInRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
