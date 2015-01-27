using System;

class TheExplorer
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        char star = '*';
        char dash = '-';
        int middlePartLenght = n - (n - 1);

        for (int row = 1; row <= n; row++)
        {
            double middleRow = Math.Ceiling(n / 2.0);

            if (row == 1 || row == n)
            {
                Console.WriteLine("{0}{1}{0}", new string(dash, (n - 1) / 2), star);
            }
            else if (row < middleRow)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(dash, (n - 2 - middlePartLenght) / 2), star, new string(dash, middlePartLenght));
                middlePartLenght += 2;
            }
            else if (row == middleRow)
            {
                Console.WriteLine("{0}{1}{0}", star, new string(dash, (n - 2)));
            }
            else if (row > middleRow)
            {
                Console.WriteLine("{0}{1}{2}{1}{0}", new string(dash, (n - middlePartLenght) / 2), star, new string(dash, middlePartLenght - 2));
                middlePartLenght -= 2;
            }


        }
    }
}
