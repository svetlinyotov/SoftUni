using System;

class MagicStrings
{
    static void Main()
    {
        int diff = int.Parse(Console.ReadLine());
        char[] chars = { 'k', 'n', 'p', 's' };
        int counter = 0;

        for (int i = 0; i < 4; i++)
        {
            for (int i1 = 0; i1 < 4; i1++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    for (int i3 = 0; i3 < 4; i3++)
                    {
                        string firstSequence = "" + chars[i] + chars[i1] + chars[i2] + chars[i3] + "";
                        int firstSequenceInt = convertToNum(firstSequence);

                        for (int i4 = 0; i4 < 4; i4++)
                        {
                            for (int i5 = 0; i5 < 4; i5++)
                            {
                                for (int i6 = 0; i6 < 4; i6++)
                                {
                                    for (int i7 = 0; i7 < 4; i7++)
                                    {
                                        string secondSequence = "" + chars[i4] + chars[i5] + chars[i6] + chars[i7] + "";
                                        int secondSequenceInt = convertToNum(secondSequence);
                                        
                                        if (Math.Abs(firstSequenceInt - secondSequenceInt) == diff)
                                        {
                                            Console.WriteLine(firstSequence + secondSequence);
                                            counter++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("No");
        }


    }

    private static int convertToNum(string sequence)
    {
        int sum = 0;
        foreach (char character in sequence)
        {
            switch (character)
            {
                case 'k': sum += 1; break;
                case 's': sum += 3; break;
                case 'n': sum += 4; break;
                case 'p': sum += 5; break;
                default: break;
            }
        }

        return sum;
    }
}
