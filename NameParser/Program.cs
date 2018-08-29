using System;
using NameParser.Names;

namespace NameParser
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = new FirstName();
            var middleName = new MiddleName(firstName);
            var lastName = new LastName();

            firstName.GetName();
            firstName.PrintName();

            lastName.GetName();
            lastName.PrintName();

            middleName.GetName(firstName.Name);
            middleName.PrintName();

            Console.WriteLine($@"GoddBye {firstName.Name} {middleName.Name} {lastName.Name}. Press Enter and gtfo");
            Console.ReadLine();
        }
    }
}
