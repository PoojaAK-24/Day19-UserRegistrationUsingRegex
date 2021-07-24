using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("*Password should contain minimum 8 Characters");
            Console.WriteLine("First letter should be capital");
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateUpperCasePassword("Pooja@123");
           
            Console.ReadKey();
        }
    }
}
