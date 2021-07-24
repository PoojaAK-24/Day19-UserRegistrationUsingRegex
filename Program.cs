using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("*Mobile Number should be starts from Country Code follow by space and 10 digit number");
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateMobileNo("91 8770422433");
           
            Console.ReadKey();
        }
    }
}
