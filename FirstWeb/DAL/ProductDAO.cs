using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace FirstWeb.DAL
{
    public class ProductDAO
    {
        public List<Product> GetProductsByCateID(int id)
        {
            string query = @"select p.ProductID, p.ProductName, p.UnitPrice, c.CategoryName from Products p, Categories c where p.CategoryID = c.CategoryID and p.CategoryID = @id";
            SqlParameter param = new SqlParameter("@id", id);
            DataTable dt = DAO.GetDataBySql(query, param);
            List<Product> list = new List<Product>();
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Product(Convert.ToInt32(dr["ProductID"]),
                                        dr["ProductName"].ToString(),
                                        Convert.ToDouble(dr["UnitPrice"]),
                                        dr["CategoryName"].ToString()));
            }
            return list;
        }
    }
}