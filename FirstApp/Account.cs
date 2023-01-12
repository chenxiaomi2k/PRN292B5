using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    class Account
    {
        private string username;
        private string password;

        public string name
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }

        public string pass
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public Account()
        {
        }

        public Account(string[] c)
        {
            if(c.Length != 3)
            {
                throw new FormatException("Cannot read");
            }
            this.name = c[1];
            this.pass = c[2];
        }
        public override bool Equals(object obj)
        {
            return obj is Account account &&
                   username == account.username;
        }

        
        public void input()
        {
            Console.WriteLine("Username: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Pass:");
            pass = Convert.ToString(Console.ReadLine());
        }

        public override string ToString()
        {
            string newstring = GetType().ToString().Substring(9);
            return newstring + "|" + username + "|" + password;
        }
    }
}
