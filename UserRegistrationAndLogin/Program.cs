using System;

namespace UserRegistrationAndLogin
{
    class Program
    {
        static string username;
        static string password;

        static void Main(string[] args)
        {
            Register();
            Login();
        }

        public static void Register()
        {
            Console.WriteLine("Please enter a user name: ");
             username = Console.ReadLine();
            Console.WriteLine("Please enter a password: ");
             password = Console.ReadLine();
            Console.WriteLine("User Registration was a success!");
            Console.WriteLine("----------------------------------");

        }

        public static void Login()
        {
            Console.WriteLine("Please enter username to login to account: ");
            if ( username == Console.ReadLine()) {
                Console.WriteLine("Please enter password: ");
                    if( password == Console.ReadLine())
                {
                    Console.WriteLine(" Login was a success! ");
                }
                else
                {
                    Console.WriteLine(" Wrong password. Restart program!  ");
                    Register();
                }
            } else
            {
                Console.WriteLine(" Wrong username. Restart program! ");
                Register();
            }

        }
    }
}
