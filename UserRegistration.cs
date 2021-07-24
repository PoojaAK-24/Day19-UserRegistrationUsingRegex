using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class UserRegistration
    {
        public void validateUpperCasePassword(string uppercasepassword)
        {
            string stringForUpperCasePassword = "[A-Z]+.{8,}?";
            if (Regex.IsMatch(uppercasepassword, stringForUpperCasePassword))
                Console.WriteLine(uppercasepassword + " is Valid");
            else
                Console.WriteLine(uppercasepassword + " is Invalid");
        }
    }
}

