using System;

namespace SimpleLoginSystem
{
    class Program
    {
        static string GenrateOTP()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString();
        }

        // Utility function to pause the console
        static void PauseConsole()
        {
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            const string USERNAME = "username";
            const string PASSWORD = "password";

            Console.WriteLine("Welcome to the Simple Login System!");
            Console.Write("Please write your username: ");
            string username = Console.ReadLine() ?? "";
            Console.Write("Please write your password: ");
            string password = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Username or password cannot be empty.");
                PauseConsole();
                return;
            }

            if (username != USERNAME || password != PASSWORD)
            {
                Console.WriteLine("Invalid username or password. Access denied.");
                PauseConsole();
                return;
            }
            string otp = GenrateOTP();
            Console.WriteLine(otp);

            Console.Write("Enter the otp: ");
            string receivedOtp = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(receivedOtp) || otp != receivedOtp)
            {
                Console.WriteLine("Invalid OTP. Access denied.");
                PauseConsole();
                return;
            }
            else
            {
                Console.WriteLine("Success! You are logged in.");
            }
        }
    }
}
