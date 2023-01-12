using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace _19SpB5_Q1.DAL
{
    class DAO
    {
        public static SqlConnection GetConnection()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["con"].ToString();
            return new SqlConnection(ConnectionString);
        }

        public static DataTable GetDataBySql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters.Length != 0)
                command.Parameters.AddRange(parameters);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        public static int DeleteDataBySql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters.Length != 0)
                command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int n =  command.ExecuteNonQuery();
            command.Connection.Close();
            return n;
        }

        public static void UpdateDataBySql(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters.Length != 0)
                command.Parameters.AddRange(parameters);
            command.Connection.Open();
            command.ExecuteNonQuery();
            command.Connection.Close();
        }
    }
}
