using _19SpB5_Q1.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace _19SpB5_Q1.DAL
{
    class CorpDAO
    {
        public List<Corporation> GetAllCorp()
        {
            string query = "select c.corp_no, c.corp_name, c.street, r.region_name, c.expr_dt from corporation c, region r where c.region_no = r.region_no";
            DataTable dt = DAO.GetDataBySql(query);
            List<Corporation> list = new List<Corporation>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Corporation(Convert.ToInt32(dr["corp_no"]),
                                            dr["corp_name"].ToString(),
                                            dr["street"].ToString(),
                                            dr["region_name"].ToString(),
                                            Convert.ToDateTime(dr["expr_dt"])));
            }
            return list;
        }

        public int DeleteCorp(int num)
        {
            string query = @"delete from member where corp_no = @num";
            string query1 = @"delete from corporation where corp_no = @num";
            SqlParameter param = new SqlParameter("@num", num);
            SqlParameter param1 = new SqlParameter("@num", num);
            DAO.DeleteDataBySql(query, param);
            return DAO.DeleteDataBySql(query1, param1);
        }

        public void UpdateCorp(Corporation c, int num)
        {
            string query = @"update corporation set corp_name = @name, street = @street, expr_dt = @date where corp_no = @num";
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@name", c.Corp_name),
                                                        new SqlParameter("@street", c.Street),
                                                        new SqlParameter("@date", c.expr_dt),
                                                        new SqlParameter("@num", num)};
            DAO.UpdateDataBySql(query, param);
        }
    }
}
