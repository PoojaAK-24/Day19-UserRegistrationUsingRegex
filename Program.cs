using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("*Email Should have @ symbol");
            Console.WriteLine("*Email should have domain name");
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateEmail("pooja.reddy@bridgelabz.co.in");
           
            Console.ReadKey();
        }
    }
}
