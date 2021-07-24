using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class UserRegistration
    {
        public void validateLastName(string lastName)
        {
            string stringForLastName = "^[A-Z][a-z]{3,}$";
            if (Regex.IsMatch(lastName, stringForLastName))
                Console.WriteLine(lastName + " is Valid");
            else
                Console.WriteLine(lastName + " is Invalid");
        }
    }
}

