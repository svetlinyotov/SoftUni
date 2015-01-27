using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixOfPalindromes
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int rows = Convert.ToInt32(input[0]);
        int cols = Convert.ToInt32(input[1]);

        string[,] matrix = new string[rows, cols];

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                matrix[r, c] = "" + (char)('a' + r) + (char)('a' + r + c) + (char)('a' + r);
            }
        }

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Console.Write(matrix[r, c] + " ");
            }
            Console.WriteLine();
        }
    }
}
