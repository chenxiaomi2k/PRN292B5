using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstWeb
{
    class Customer : Account
    {
        public string Name { get; set; }
        public DateTime DOB { get; set; }

        public Customer(string username, string password, string name, DateTime dOB) : base(username, password)
        {
            Name = name;
            DOB = dOB;
        }
        public Customer(string[] c)
        {
            if (c.Length != 5)
            {
                throw new FormatException("Cannot read");
            }
            base.Username = c[1];
            base.Password = c[2];
            Name = c[3];
            DOB = Convert.ToDateTime(c[4]);
        }
        public override string ToString()
        {
            return base.ToString() + "|" + Name + "|" + DOB;
        }
    }
}
