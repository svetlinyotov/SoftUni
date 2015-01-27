using System;

class ZeroSubset
{
    static void Main()
    {
        Console.Write("Numbers: ");
        string[] numbers = Console.ReadLine().Split(' ');
        int num1 = Convert.ToInt32(numbers[0]);
        int num2 = Convert.ToInt32(numbers[1]);
        int num3 = Convert.ToInt32(numbers[2]);
        int num4 = Convert.ToInt32(numbers[3]);
        int num5 = Convert.ToInt32(numbers[4]);
        int counter = 0;

        if (num1 + num2 == 0) { Console.WriteLine("{0} + {1} = 0", num1, num2); counter++; }
        if (num1 + num3 == 0) { Console.WriteLine("{0} + {1} = 0", num1, num3); counter++; }
        if (num1 + num4 == 0) { Console.WriteLine("{0} + {1} = 0", num1, num4); counter++; }
        if (num1 + num5 == 0) { Console.WriteLine("{0} + {1} = 0", num1, num5); counter++; }
        if (num2 + num3 == 0) { Console.WriteLine("{0} + {1} = 0", num2, num3); counter++; }
        if (num2 + num4 == 0) { Console.WriteLine("{0} + {1} = 0", num2, num4); counter++; }
        if (num2 + num5 == 0) { Console.WriteLine("{0} + {1} = 0", num2, num5); counter++; }
        if (num3 + num4 == 0) { Console.WriteLine("{0} + {1} = 0", num3, num4); counter++; }
        if (num3 + num5 == 0) { Console.WriteLine("{0} + {1} = 0", num3, num5); counter++; }
        if (num4 + num5 == 0) { Console.WriteLine("{0} + {1} = 0", num4, num5); counter++; }

        if (num1 + num2 + num3 == 0) { Console.WriteLine("{0} + {1} + {2} = 0", num1, num2, num3); counter++; }
        if (num1 + num2 + num4 == 0) { Console.WriteLine("{0} + {1} + {2} = 0", num1, num2, num4); counter++; }
        if (num1 + num2 + num5 == 0) { Console.WriteLine("{0} + {1} + {2} = 0", num1, num2, num5); counter++; }
        if (num1 + num3 + num4 == 0) { Console.WriteLine("{0} + {1} + {2} = 0", num1, num3, num4); counter++; }
        if (num1 + num3 + num5 == 0) { Console.WriteLine("{0} + {1} + {2} = 0", num1, num3, num5); counter++; }
        if (num1 + num4 + num5 == 0) { Console.WriteLine("{0} + {1} + {2} = 0", num1, num4, num5); counter++; }
        if (num2 + num3 + num4 == 0) { Console.WriteLine("{0} + {1} + {2} = 0", num2, num3, num4); counter++; }
        if (num2 + num3 + num5 == 0) { Console.WriteLine("{0} + {1} + {2} = 0", num2, num3, num5); counter++; }
        if (num2 + num4 + num5 == 0) { Console.WriteLine("{0} + {1} + {2} = 0", num2, num4, num5); counter++; }
        if (num3 + num4 + num5 == 0) { Console.WriteLine("{0} + {1} + {2} = 0", num3, num4, num5); counter++; }

        if (num1 + num2 + num3 + num4 == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", num1, num2, num3, num4); counter++; }
        if (num1 + num2 + num3 + num5 == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", num1, num2, num3, num5); counter++; }
        if (num1 + num2 + num4 + num5 == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", num1, num2, num4, num5); counter++; }
        if (num1 + num3 + num4 + num5 == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", num1, num3, num4, num5); counter++; }
        if (num2 + num3 + num4 + num5 == 0) { Console.WriteLine("{0} + {1} + {2} + {3} = 0", num2, num3, num4, num5); counter++; }

        if (num1 + num2 + num3 + num4 + num5 == 0) { Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", num1, num2, num3, num4, num5); counter++; }

        if (counter == 0)
        {
            Console.WriteLine("no zero subset");
        }
    }
}
