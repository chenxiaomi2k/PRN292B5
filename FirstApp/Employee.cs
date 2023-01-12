using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstApp
{
    class Employee : Account
    {
        public string role { get; set; }
        public double salary { get; set; }

        public Employee(string username, string password, double salary, string role) : base(username, password)
        {
            this.role = role;
            this.salary = salary;
        }

        public Employee()
        {
        }

        public Employee(string[] c)
        {
            if (c.Length != 5)
            {
                throw new FormatException("Cannot read");
            }
            base.name = c[1];
            base.pass = c[2];
            salary = Convert.ToDouble(c[3]);
            role = c[4];
        }
        public void input()
        {
            base.input();
            Console.WriteLine("Salary:");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Role:");
            role = Convert.ToString(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() +"|"+ salary +"|"+ role;
        }
    }
}
