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

                Console.WriteLine("Enter the password (Minimum 8 characters): ");
                string password = Console.ReadLine()!;

                var validate = new ValidateCredentials("", "");
                validate.Validate(username, password);

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