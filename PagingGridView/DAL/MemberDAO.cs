using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PagingGridView.DAL
{
    public class MemberDAO
    {
        public List<Member> GetMembers()
        {
            string query = "select * from member";
            DataTable dt = DAO.GetDataBySql(query);
            List<Member> list = new List<Member>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Member(Convert.ToInt32(dr["member_no"]),
                                    dr["lastname"].ToString(),
                                    dr["firstname"].ToString(),
                                    Convert.ToDateTime(dr["issue_dt"]),
                                    Convert.ToDateTime(dr["expr_dt"])));
            }
            return list;
        }

        public List<Member> GetMembersByRegion(int reno)
        {
            string query = @"select * from member where region_no = @reno";
            SqlParameter param = new SqlParameter("@reno", reno);
            DataTable dt = DAO.GetDataBySql(query, param);
            List<Member> list = new List<Member>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Member(Convert.ToInt32(dr["member_no"]),
                                    dr["lastname"].ToString(),
                                    dr["firstname"].ToString(),
                                    Convert.ToDateTime(dr["issue_dt"]),
                                    Convert.ToDateTime(dr["expr_dt"])));
            }
            return list;
        }

        public List<Member> GetMembersByRegionAndCorp(int reno, int cono)
        {
            string query = @"select * from member where region_no = @reno and corp_no = @cono";
            SqlParameter[] param = new SqlParameter[] {new SqlParameter("@reno", reno),
                                                        new SqlParameter("@cono", cono)};
            DataTable dt = DAO.GetDataBySql(query, param);
            List<Member> list = new List<Member>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Member(Convert.ToInt32(dr["member_no"]),
                                    dr["lastname"].ToString(),
                                    dr["firstname"].ToString(),
                                    Convert.ToDateTime(dr["issue_dt"]),
                                    Convert.ToDateTime(dr["expr_dt"])));
            }
            return list;
        }
    }
}