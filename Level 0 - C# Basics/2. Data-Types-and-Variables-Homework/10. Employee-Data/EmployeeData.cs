using System;

class EmployeeData
{
    static void Main()
    {
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter Age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.Write("Enter Gender (m/f): ");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Enter Personal ID: ");
        ulong personalId = ulong.Parse(Console.ReadLine());
        Console.Write("Enter Employee Number (from 27560000 to 27569999): ");
        int employeeId = int.Parse(Console.ReadLine());

        Console.WriteLine(String.Empty);
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Employee Information");
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("ID: " + personalId);
        if (employeeId > 27569999)
        {
            Console.WriteLine("!!!The employee Id is too large!!!");
        }
        else if (employeeId < 27560000)
        {
            Console.WriteLine("!!!The employee Id is too small!!!");
        }
        else
        {
            Console.WriteLine("Employee ID: " + employeeId);
        }
        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        if (age > 100)
        {
            Console.WriteLine("!!!The employee age is too large!!!");
        }
        else
        {
            Console.WriteLine("Age: " + age);
        }
        if (gender == 'm')
        {
            Console.WriteLine("Gender: male");
        }
        else if (gender == 'f')
        {
            Console.WriteLine("Gender: female");
        }
        else
        {
            Console.WriteLine("!!!Wrong input for gender!!!");
        }

    }
}
