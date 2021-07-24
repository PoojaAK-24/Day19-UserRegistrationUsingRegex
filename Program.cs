using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("*First letter should be capital.");
            Console.WriteLine("*length should be Minimum three characters.");
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateLastName("Reddy");
           
            Console.ReadKey();
        }
    }
}
