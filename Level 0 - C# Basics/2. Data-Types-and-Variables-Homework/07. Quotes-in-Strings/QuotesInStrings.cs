using System;

class QuotesInStrings
{
    static void Main()
    {
        string sentence1 = "The \"use\" of quotations causes difficulties.";
        string sentence2 = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(sentence1);
        Console.WriteLine(sentence2);
    }
}
