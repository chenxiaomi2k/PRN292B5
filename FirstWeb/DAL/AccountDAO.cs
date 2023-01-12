using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FirstWeb.DAL
{
    class AccountDAO
    {
        public List<Account> GetAllAccount()
        {
            DataTable dt = DAO.GetDataBySql("select * from Account");
            List<Account> list = new List<Account>();
            foreach (DataRow dr in dt.Rows)
            {
                Account a;
                if (dr["salary"] != DBNull.Value)
                    a = new Employee(dr["username"].ToString(),
                                     dr["password"].ToString(),
                                     dr["role"].ToString(),
                                     Convert.ToDecimal(dr["salary"]));
                else if (dr["fullname"] != DBNull.Value)
                    a = new Customer(dr["username"].ToString(),
                                     dr["password"].ToString(),
                                     dr["fullname"].ToString(),
                                     Convert.ToDateTime(dr["dob"]));
                else a = new Account(dr["username"].ToString(),
                                     dr["password"].ToString());
                list.Add(a);
            }
            return list;
        }

        public void AddAccToDatabase(Account a)
        {
            string query = @"insert into Account(username, [password]) values(@user, @pass)";
            SqlParameter[] param = new SqlParameter[] {new SqlParameter("@user", a.Username),
                                    new SqlParameter("@pass", a.Password)};
            DAO.InsertDataBySQL(query, param);
        }

        public void AddEmplToDatabase(Employee e)
        {
            string query = @"insert into Account(username, [password], salary, [role]) values(@user, @pass, @sal, @role)";
            SqlParameter[] param = new SqlParameter[] {new SqlParameter("@user", e.Username),
                                    new SqlParameter("@pass", e.Password),
                                    new SqlParameter("@sal", e.Salary),
                                    new SqlParameter("@role", e.Role)};
            DAO.InsertDataBySQL(query, param);
        }

        public void AddCusToDatabase(Customer c)
        {
            string query = @"insert into Account(username, [password], fullname, dob) values(@user, @pass, @name, @dob)";
            SqlParameter[] param = new SqlParameter[] {new SqlParameter("@user", c.Username),
                                    new SqlParameter("@pass", c.Password),
                                    new SqlParameter("@name", c.Name),
                                    new SqlParameter("@dob", c.DOB)};
            DAO.InsertDataBySQL(query, param);
        }

        public List<Account> GetAllEmployee()
        {
            DataTable dt = DAO.GetDataBySql("select * from Account where salary is not null");
            List<Account> list = new List<Account>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Employee(dr["username"].ToString(),
                                     dr["password"].ToString(),
                                     dr["role"].ToString(),
                                     Convert.ToDecimal(dr["salary"])));
            }
            return list;
        }

        public List<Account> GetAllCustomer()
        {
            DataTable dt = DAO.GetDataBySql("select * from Account where fullname is not null");
            List<Account> list = new List<Account>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Customer(dr["username"].ToString(),
                                     dr["password"].ToString(),
                                     dr["fullname"].ToString(),
                                     Convert.ToDateTime(dr["dob"])));
            }
            return list;
        }
    }
}
