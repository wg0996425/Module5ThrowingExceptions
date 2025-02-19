using M5TE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M5TE
{
    public class ValidateCredentials
    {
        public ValidateCredentials(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; }
        public string Password { get; }

        public void Validate(string username, string password)
        {
            if (username.Length < 4 || username.Length > 20) throw new InvalidUsernameException(username);
            if (password.Length < 8) throw new InvalidPasswordException(password);
        }
    }
}
