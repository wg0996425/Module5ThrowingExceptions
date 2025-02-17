using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5TE
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string password) : base("Your password is invalid. Make sure it's at least 8 characters. Try again!")
        {
            Password = password;
        }

        public string Password { get; }
    }
}
