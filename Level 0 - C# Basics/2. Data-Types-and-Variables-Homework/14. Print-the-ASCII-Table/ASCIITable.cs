using System;
using System.Text;

class ASCIITable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine(new string('-', 39));
        Console.WriteLine("ASCII table");
        Console.WriteLine(new string('-', 39));
        Console.WriteLine("| Hex | Dec | Oct |  Bynary  | Symbol |");
        Console.WriteLine(new string('-', 39));

        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("| {0:x2}  | {0:d3} | {1, -3} | {2, -8} | {3, -6} |", i, (Convert.ToString(i, 8)), (Convert.ToString(i, 2)), (char)i);
        }

        Console.WriteLine(new string('-', 39));
    }
}
