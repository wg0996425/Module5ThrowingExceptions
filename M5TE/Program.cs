using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the username: ");
            ValidateUsername();

            Console.WriteLine("Enter the password: ");
            string password = Console.ReadLine();
        }
        catch (InvalidUsernameException)
        {
            Console.WriteLine("Wrong");
        }
        catch (InvalidPasswordException)
        {

        }
    }
    public static void ValidateUsername()
    {
        string username = Console.ReadLine();
        if (username.Length < 8)
        {
            throw new InvalidUsernameException("Something");
        }
    }

    public class InvalidUsernameException : System.Exception
    {
        public InvalidUsernameException(string? message) : base(message)
        {
        }
    }
    public class InvalidPasswordException : System.Exception { }
}