using System;

class Sunglasses
{
    static void Main()
    {
        int glassesSize = int.Parse(Console.ReadLine()); // Size of the Glasses

        int width = glassesSize * 2;
        int height = glassesSize;
        int bridgeWidth = glassesSize;
        int lensWidth = width - 2;
        double bridgeRow = Math.Ceiling(height / 2D);

        string frame = new string('*', width);
        string bridge = new string(' ', bridgeWidth);
        string bridgeMiddle = new string('|', bridgeWidth);
        string lens = new string('/', lensWidth);
        string bridgeCurrent;


        for (int row = 1; row <= height; row++)
        {
            if (row == 1 || row == height)
            {

                Console.WriteLine("{0}{1}{0}", frame, bridge);
            }
            else
            {
                bridgeCurrent = (row == bridgeRow) ? bridgeMiddle : bridge;
                Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", '*', lens, bridgeCurrent);
                bridgeCurrent = bridge;
            }
        }

    }
}
