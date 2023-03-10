using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _19SpB5_Q3.DAL
{
    public class CorporationDAO
    {
        public List<Corporation> GetCorporations(int no)
        {
            string query = @"select * from corporation where region_no = @no";
            SqlParameter param = new SqlParameter("@no", no);
            DataTable dt = DAO.GetDataBySql(query, param);
            List<Corporation> list = new List<Corporation>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Corporation(Convert.ToInt32(dr["corp_no"]), dr["corp_name"].ToString()));
            }
            return list;
        }
    }
}