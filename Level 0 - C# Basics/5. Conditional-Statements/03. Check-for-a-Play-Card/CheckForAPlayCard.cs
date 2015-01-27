using System;

class CheckForAPlayCard
{
    static void Main()
    {
        string[] cardFace = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        Console.Write("Check Card Face:");
        string faceInput = Console.ReadLine();

        int countFaces = 0;

        foreach (var face in cardFace)
        {
            if (face == faceInput)
            {
                countFaces++;
            }
        }

        if (countFaces == 1)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

        /********************************/
        // Second Option

        switch (faceInput)
        {
            case "2":
            case "3":
            case "4": 
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A": Console.WriteLine("yes"); break;
            default: Console.WriteLine("no"); break;
        }
    }
}
