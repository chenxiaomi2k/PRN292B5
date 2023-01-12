using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace _19SpB5_Q3.DAL
{
    public class MemberDAO
    {
        public void AddMember(Member m)
        {
            string query = @"insert into member(firstname, lastname, region_no, corp_no) values (@first, @last, @rno, @cono)";
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@first", m.FirstName),
                                                        new SqlParameter("@last", m.LastName),
                                                        new SqlParameter("@rno", m.RegionNo),
                                                        new SqlParameter("@cono", m.CorpNo)};
            DAO.InsertDataBySQL(query, param);
        }
    }
}