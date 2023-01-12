using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstForm
{
    class Employee : Account
    {
        public string Role { get; set; }
        public decimal Salary { get; set; }

        public Employee(string username, string password, string role, decimal salary) : base(username, password)
        {
            this.Role = role;
            this.Salary = salary;
        }
        public Employee(string[] c)
        {
            if (c.Length != 5)
            {
                throw new FormatException("Cannot read");
            }
            base.Username = c[1];
            base.Password = c[2];
            Salary = Convert.ToDecimal(c[3]);
            Role = c[4];
        }
        public override string ToString()
        {
            return base.ToString() + "|" + Role + "|" + Salary;
        }
    }
}
