using System;
using System.Collections.Generic;

namespace Classes_and_methods
{
    class program
    {
        static void main(string[] args)
        {
            Contact myObj = new Contact();
            myObj.Name = "Hope";
            Console.WriteLine(myObj.Name);

            Contact myObj = new Contact();
            myObj.EmailAddress = "Hope@blahblah.com";
            Console.WriteLine(myObj.EmailAddress);

            Contact myObj = new Contact();
            myObj.PhoneNumber = "6789045";
            Console.WriteLine(myObj.PhoneNumber);
        }
    }
}