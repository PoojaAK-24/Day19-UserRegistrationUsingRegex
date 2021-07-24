using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class UserRegistration
    {
        public static string EMAIL_REGEX = "^[A-Z0-9a-z]+([+-.#$^*][0-9]+)?[0-9]*[@][A-Za-z0-9]+[.][A-Za-z]{2,}([.][a-zA-Z]{2,})?$";
        public void validateAllTypeEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL_REGEX))
                Console.WriteLine(email + " is Valid");
            else
                Console.WriteLine(email + " is Invalid");

        }
    }
}


