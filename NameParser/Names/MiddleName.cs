using System;
using System.Collections.Generic;
using System.Text;


namespace NameParser.Names
{
    class MiddleName
    {

        public string Name { get; private set; } = "";

        bool ConfrimMiddleName()
        {
            Console.WriteLine("Do you have a middle name (y/n)");

            var hasMiddleName = Console.ReadLine();

            return hasMiddleName == "y";
        }

        public void GetName(string firstName)
        {
            if (ConfrimMiddleName())
            {
                Console.WriteLine("What it is");
                Name = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($@"{firstName}, that's fine.");
            }
        }


        public void PrintName()
        {
            var i = 0;

            foreach (var letter in Name)
            {
                Console.WriteLine(letter.ToString().PadLeft(++i));
            }
        }  

    }
}
