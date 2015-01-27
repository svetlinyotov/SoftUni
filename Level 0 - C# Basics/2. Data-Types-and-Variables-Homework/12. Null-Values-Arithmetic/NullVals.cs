using System;

class NullVals
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine("int? a = {0}\ndouble? b = {1}", a, b);
        Console.WriteLine("Get value or default: 'a' = {0} | 'b' = {1}", a.GetValueOrDefault(), b.GetValueOrDefault());
        Console.WriteLine("'a' (bool) = {0} \n'b' (bool) = {1}", a.HasValue, b.HasValue);

        Console.WriteLine(String.Empty);

        a = 635;
        b = 56.5647;
        Console.WriteLine("a = {0}", a.GetValueOrDefault());
        Console.WriteLine("b = {0}", b.GetValueOrDefault());
        Console.WriteLine("'a' (bool) = {0} \n'b' (bool) = {1}", a.HasValue, b.HasValue);

        Console.WriteLine(String.Empty);

        a = 0;
        Console.WriteLine("a = {0}", a.GetValueOrDefault());
        Console.WriteLine("'a' (bool) = {0}", a.HasValue);

    }
}
