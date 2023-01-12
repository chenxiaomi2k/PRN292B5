using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FirstForm.DAL
{
    class DAO
    {
        public static SqlConnection GetConnection()
        {
            string ConnectionString = "server=localhost;database=PRN292B5;user=sa;password=123";
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

        public static int InsertDataBySQL(string sql, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(sql, GetConnection());
            if (parameters.Length != 0)
                command.Parameters.AddRange(parameters);
            command.Connection.Open();
            int numRows = command.ExecuteNonQuery();
            command.Connection.Close();
            return numRows;
        }
    }
}
