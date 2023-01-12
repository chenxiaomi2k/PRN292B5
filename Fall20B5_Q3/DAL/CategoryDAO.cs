using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Fall20B5_Q3.DAL
{
    public class CategoryDAO
    {
        public List<Category> GetCategories()
        {
            string query = "select * from Categories";
            DataTable dt = DAO.GetDataBySql(query);
            List<Category> list = new List<Category>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Category(Convert.ToInt32(dr["CategoryID"]),
                                        dr["CategoryName"].ToString()));
            }
            return list;
        }
    }
}