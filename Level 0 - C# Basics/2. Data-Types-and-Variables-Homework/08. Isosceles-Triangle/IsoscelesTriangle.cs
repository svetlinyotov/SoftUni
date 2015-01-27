using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("In order to see the triangle properly \nYou need to set you Console font to non-raster font\n");

        char symbol = '\u00A9';
        int lines = 4; // Set the size of the triangle.

        for (int row = 1; row <= lines; row++)
        {
            int firstSidePosition = lines - row + 1;
            int secondSidePosition = row + row - 3;

            if (row == 1)
            {
                Console.WriteLine("{0,"+lines+"}", symbol);
            }
            else if (row == lines)
            {
                for (int iLastRow = lines; iLastRow >= 1; iLastRow--)
                {
                    Console.Write("{0} ", symbol);
                }
            }
            else 
            {
                Console.WriteLine("{0," + firstSidePosition + "} {0," + secondSidePosition + "}", symbol);
            }

        }

        Console.WriteLine(String.Empty);
        Console.WriteLine(String.Empty);
    }
}

