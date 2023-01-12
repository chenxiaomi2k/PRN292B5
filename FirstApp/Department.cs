using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FirstApp
{
    public delegate void OnNumberOfCountChange();
    class Department : IDisplayable, IComparer<Account>
    {
        public event OnNumberOfCountChange CountChange;
        private List<Account> accounts = new List<Account>();
        private string departmentName;

        public Department(string departmentName)
        {
            this.departmentName = departmentName;
        }

        public Department()
        {
        }

        public string DepartmentName
        {
            get
            {
                return departmentName;
            }
            set
            {
                departmentName = value;
            }
        }

        public int GetNumberOfAccount()
        {
            return accounts.Count();
        }

        public void AddAccount(Account a)
        {
            if (accounts.Contains(a))
            {
                throw new MyExcetion("Cannot duplicate");
            }
            accounts.Add(a);           
            Console.WriteLine("Add successfull");
            CountChange();
        }

        public void RemoveAccount(Account a)
        {
            Console.WriteLine("Username:");
            string user = Convert.ToString(Console.ReadLine());
            for (int i = 0; i < accounts.Count(); i++)
            {
                if (user.Equals(accounts[i].name))
                {
                    accounts.Remove(a);
                    Console.WriteLine("Remove successfull");
                    CountChange();
                    return;
                }
                else
                {
                    Console.WriteLine("Cant find account");
                }
            }
        }

        public void Input()
        {
            Console.WriteLine("Department name:");
            departmentName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Accounts:");
            for (int i = 0; i < accounts.Count(); i++)
            {
                Console.WriteLine("Username:");
                string user = Convert.ToString(Console.ReadLine());
                if (!user.Equals(accounts[i].name))
                {
                    accounts[i].name = user;
                    Console.WriteLine("Password:");
                    accounts[i].pass = Convert.ToString(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Account duplicate");
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Dept name:" + departmentName);
            foreach (Account a in accounts)
            {
                Console.WriteLine(a.ToString());
            }
        }

        public void Sort()
        {
            Console.WriteLine("Sort by username:");
            accounts.Sort(Compare);
            foreach (Account a in accounts)
            {
                Console.WriteLine(a.ToString());
            }
        }

        public void DelegateSortByName()
        {
            Console.WriteLine("Sort username using Comparision:");
            Comparison<Account> comparison = new Comparison<Account>(DelegateCompareByName);
            accounts.Sort(comparison);
            foreach (Account a in accounts)
            {
                Console.WriteLine(a.ToString());
            }
        }

        public void DelegateSortByPassword()
        {
            Console.WriteLine("Sort password using Comparision:");
            Comparison<Account> comparison = new Comparison<Account>(DelegateComareByPassword);
            accounts.Sort(comparison);
            foreach (Account a in accounts)
            {
                Console.WriteLine(a.ToString());
            }
        }

        public int DelegateComareByPassword(Account x, Account y)
        {
            return x.pass.CompareTo(y.pass);
        }

        public int DelegateCompareByName(Account x, Account y)
        {
            return x.name.CompareTo(y.name);
        }

        public int Compare(Account x, Account y)
        {
            if (x == null || y == null)
            {
                return 0;
            }
            return x.name.CompareTo(y.name);
        }

        public void ReadFromFile(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            try
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        Console.WriteLine(line);
                        string[] arr = line.Split('|');
                        Account a;
                        if (arr[0].Equals("Account"))
                        {
                            a = new Account(arr);
                        }
                        else if (arr[0].Equals("Employee"))
                        {
                            a = new Customer(arr);
                        }
                        else
                        {
                            a = new Employee(arr);
                        }
                        AddAccount(a);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Cannot read");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("khong tim thay file de doc");
            }
            finally
            {
                sr.Close();
            }
        }

        public void WriteFromFile(string filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename);
                sw.WriteLine(departmentName);
                foreach (Account a in accounts)
                {
                    sw.WriteLine(a.ToString());
                }
                Employee e1 = new Employee("trungnb", "123457", 1200.4, "Admin");
                sw.WriteLine(e1.ToString());
                Customer c1 = new Customer("trungnb", "123457", "Bao Trung", DateTime.Now);
                sw.WriteLine(c1.ToString());
                Console.WriteLine("Ghi thanh cong");
                sw.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("khong tim thay file de ghi");
            }
        }

        public void Message()
        {
            Console.WriteLine("Number of account in dept has been changed");
        }
    }
    public class MyExcetion : Exception
    {
        public MyExcetion()
        {
        }

        public MyExcetion(string message)
            : base(message)
        {
        }
    }
}
