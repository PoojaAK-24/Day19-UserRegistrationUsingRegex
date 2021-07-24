using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    class UserRegistration
    {
        public void validateMobileNo(string mobileno)
        {
            string stringForMobileNo = "^[0-9]{2}[ ][6-9][0-9]{9}$";
            if (Regex.IsMatch(mobileno, stringForMobileNo))
                Console.WriteLine(mobileno + " is Valid");
            else
                Console.WriteLine(mobileno + " is Invalid");
        }
    }
}

