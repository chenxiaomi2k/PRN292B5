using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    class Customer : Account
    {
        public DateTime DOB { get; set; }
        public string name { get; set; }

        public Customer(string username, string password, string name, DateTime dOB) : base(username, password)
        {
            DOB = dOB;
            this.name = name;
        }

        public Customer()
        {
        }

        public Customer(string[] c)
        {
            if (c.Length != 5)
            {
                throw new FormatException("Cannot read");
            }
            base.name = c[1];
            base.pass = c[2];
            name = c[3];
            DOB = Convert.ToDateTime(c[4]);
        }
        public void input()
        {
            base.input();
            Console.WriteLine("Name:");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("DOB:");
            DOB = Convert.ToDateTime(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() +"|"+ name + "|" + DOB;
        }
    }
}
