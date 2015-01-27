using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        string[] card = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        for (int i = 0; i < card.Length; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                Console.Write(card[i]);
                switch (j)
                {
                    case 1: Console.Write("\u2663"); break;
                    case 2: Console.Write("\u2666"); break;
                    case 3: Console.Write("\u2665"); break;
                    case 4: Console.Write("\u2660"); break;
                }
                Console.Write(" ");
            }

            Console.WriteLine("");
        }
    }
}
