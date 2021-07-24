using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class UserRegistration
    {
        public void validateNumericPassword(string numericpassword)
        {
            string stringForNumericPassword = "^.{8,}?";
            if (Regex.IsMatch(numericpassword, stringForNumericPassword))
                Console.WriteLine(numericpassword + " is Valid");
            else
                Console.WriteLine(numericpassword + " is Invalid");
        }
    }
}

