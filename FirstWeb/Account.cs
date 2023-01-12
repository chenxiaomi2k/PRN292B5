using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstWeb
{
    class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Account()
        {
        }

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public Account(string[] c)
        {
            if (c.Length != 3)
            {
                throw new FormatException("Cannot read");
            }
            this.Username = c[1];
            this.Password = c[2];
        }
        public override string ToString()
        {
            return GetType().ToString().Substring(10) + "|" + Username + "|" + Password;
        }
    }
}
