using System;
using System.Collections.Generic;
using System.Text;

namespace NameParser.Names
{
    class LastName : NameBase 
    {
        public LastName() : base("last")
        {}

        public override void PrintName()
        {
            var lastNameWithSpaces = "";

            foreach(var letter in Name.ToUpper())
            {
                Console.WriteLine(lastNameWithSpaces.Trim());
            }
        }

            
    }
}
