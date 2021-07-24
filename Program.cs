using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("*Password should contain minimum 8 Characters");
            Console.WriteLine("Password should contain numeric values");
            UserRegistration validateUser = new UserRegistration();
            validateUser.validateSpecialCharPassword("reddy#123");
           
            Console.ReadKey();
        }
    }
}
