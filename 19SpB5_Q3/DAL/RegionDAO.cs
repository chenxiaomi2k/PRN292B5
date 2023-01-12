using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace _19SpB5_Q3.DAL
{
    public class RegionDAO
    {
        public List<Region> GetRegions()
        {
            string query = "select * from region";
            DataTable dt = DAO.GetDataBySql(query);
            List<Region> list = new List<Region>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Region(Convert.ToInt32(dr["region_no"]), dr["region_name"].ToString()));
            }
            return list;
        }
    }
}