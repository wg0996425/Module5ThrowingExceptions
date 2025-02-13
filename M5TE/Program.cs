using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Prompt();
        }
        catch (InvalidUsernameException)
        {
            Console.WriteLine("WRONG!");
        }
        catch (InvalidPasswordException)
        {

        }
    }
    public static void Prompt()
    {
        Console.WriteLine("Enter the username: ");
        string Username = Console.ReadLine();

        if (Username.Length < 8)
        {
            throw new InvalidPasswordException("kys");
        }

        Console.WriteLine("Enter the password: ");
        string Password = Console.ReadLine();
    }

    public class InvalidUsernameException : System.Exception
    {

    }

    public class InvalidPasswordException : System.Exception
    {
        public InvalidPasswordException(string? message) : base(message)
        {
        }
    }
}