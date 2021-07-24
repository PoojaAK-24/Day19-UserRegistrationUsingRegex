using System;

namespace UserRegistrationRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            Console.WriteLine("*Password should contain minimum 8 Characters");
            UserRegistration validateUser = new UserRegistration();
           
            validateUser.validateAllTypeEmail("pooja@yahoo.com");
            validateUser.validateAllTypeEmail("pooja-100@yahoo.com");
            validateUser.validateAllTypeEmail("abc.100@yahoo.com");
            validateUser.validateAllTypeEmail("abc111@abc.com");
            validateUser.validateAllTypeEmail("abc-100@abc.net");
            validateUser.validateAllTypeEmail("abc-100@abc.com.ac");
            validateUser.validateAllTypeEmail("abc@1.com");
            validateUser.validateAllTypeEmail("abc@gmail.com.com");
            validateUser.validateAllTypeEmail("abc+100@gmail.com");
            Console.ReadKey();
        }
    }
}
