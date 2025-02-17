using M5TE;
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        bool continuing = true;
        while (continuing)
        {
            try
            {
                Console.WriteLine("Enter the username (Minimum 4 characters, Maximum 20 characters): ");
                string username = Console.ReadLine()!;
                if (username.Length < 4 || username.Length > 20) throw new InvalidUsernameException(username);

                Console.WriteLine("Enter the password (Minimum 8 characters): ");
                string password = Console.ReadLine()!;
                if (password.Length < 8) throw new InvalidPasswordException(password);

                continuing = false;
            }
            catch (InvalidUsernameException userEX)
            {
                Console.WriteLine(userEX.Message);
            }
            catch (InvalidPasswordException passEX)
            {
                Console.WriteLine(passEX.Message);
            }
        }
    }
}