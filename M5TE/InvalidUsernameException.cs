using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5TE
{
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException(string username) : base("Your username does not meet character requirements. Try again!")
        {
            Username = username;
        }

        public string Username { get; }
    }
}
