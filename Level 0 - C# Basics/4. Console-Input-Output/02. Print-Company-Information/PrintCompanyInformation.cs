using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string compName = Console.ReadLine();
        Console.Write("Company address: ");
        string compAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string compMobile = Console.ReadLine();
        Console.Write("Fax number: ");
        string compFax = Console.ReadLine();
        if (compFax == String.Empty)
        {
            compFax = "(no fax)";
        }
        Console.Write("Web Site: ");
        string compWebSite = Console.ReadLine();
        Console.WriteLine(new string('-', 4) + "Manager Info" + new string('-', 4));
        Console.Write("First Name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine(String.Empty);
        Console.WriteLine(new string('*', 40));
        Console.WriteLine(String.Empty);

        Console.WriteLine(compName);
        Console.WriteLine("Address: {0}", compAddress);
        Console.WriteLine("Tel. {0}", compMobile);
        Console.WriteLine("Fax: {0}", compFax);
        Console.WriteLine("Web site: {0}", compWebSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhone);
    }
}
