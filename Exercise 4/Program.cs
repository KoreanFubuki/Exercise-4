using System;

namespace Exercise4
{
    class Program
    {
        static string Username;
        static string Password;
        static void Main(string[] args)
        {
            Register();
            Login();
            Console.ReadKey();
        }
        public static void Register()
        {
            Console.WriteLine("Please Enter your Username");
            Username = Console.ReadLine();
            Console.WriteLine("Please Enter your Password");
            Password = Console.ReadLine();
            Console.WriteLine("You have Succesfully Registered");
            Console.WriteLine("---------------------------------------");
        }
        public static void Login()
        {
            Console.WriteLine("Please Enter your Username");
            if (Username == Console.ReadLine())
            {
                Console.WriteLine("Please Enter your Password");
                if (Password == Console.ReadLine())
                {
                    Console.WriteLine("You have succesfully logged into your account");
                }
                else
                {
                    Console.WriteLine("The Password you have entered is incorrect please restart the program");
                }
            }
            else
            {
                Console.WriteLine("The Username you have entered is Incorrect please restart the program");
            }
            
           
        }
    }
}
