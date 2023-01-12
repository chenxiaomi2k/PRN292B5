using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace FirstWeb.DAL
{
    public class CategoryDAO
    {
        public List<Category> GetAllCategories()
        {
            string query = "select * from Categories";
            DataTable dt = DAO.GetDataBySql(query);
            List<Category> list = new List<Category>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Category(Convert.ToInt32(dr["CategoryID"]),
                                        dr["CategoryName"].ToString(),
                                        dr["Description"].ToString()));
            }
            return list;
        }
    }
}