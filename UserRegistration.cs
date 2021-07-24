using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class UserRegistration
    {
        public void validateSpecialCharPassword(string specialcharpassword)
        {
            string stringForSpecialCharPassword = "^([a-zA-Z0-9])*[!@#$%^&*]{1}([a-zA-Z0-9])*$";
            if (Regex.IsMatch(specialcharpassword, stringForSpecialCharPassword))
                Console.WriteLine(specialcharpassword + " is Valid");
            else
                Console.WriteLine(specialcharpassword + " is Invalid");
        }
    }
}

