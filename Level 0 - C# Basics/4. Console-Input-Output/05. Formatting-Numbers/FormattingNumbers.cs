using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a < 0 || a > 500)
        {
            Console.WriteLine("Wrong input for a"); return;
        }
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        string aBin = Convert.ToString(a, 2).PadLeft(10, '0');
        bool checkB = Convert.ToString(b).IndexOf(".") > 0;
        bool checkC = Convert.ToString(c).IndexOf(".") > 0;

        Console.WriteLine(new string('-', 45));
        Console.Write("|{0,-10:X}|{1}|", a, aBin);
        Console.Write(checkB ? "{0,10:0.00}" : "{0, 10}", b);
        Console.Write("|");
        Console.Write(checkC? "{0,-10:0.000}":"{0, -10}", c);
        Console.WriteLine("|");
        Console.WriteLine(new string('-', 45));
    }
}
