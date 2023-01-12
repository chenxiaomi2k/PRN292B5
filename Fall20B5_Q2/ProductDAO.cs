using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Fall20B5_Q2
{
    class ProductDAO
    {
        public List<Product> GetAllProduct()
        {
            string query = "select p.ProductID, p.ProductName, s.CompanyName, c.CategoryName, p.QuantityPerUnit, p.UnitPrice, p.UnitsInStock, p.UnitsOnOrder, p.ReorderLevel, p.Discontinued from Products p, Suppliers s, Categories c"
                            + " where p.CategoryID = c.CategoryID and p.SupplierID = s.SupplierID";
            List<Product> list = new List<Product>();
            DataTable dt = DAL.GetDataBySql(query);
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Product(Convert.ToInt32(dr["ProductID"]),
                                        dr["ProductName"].ToString(),
                                        dr["CompanyName"].ToString(),
                                        dr["CategoryName"].ToString(),
                                        dr["QuantityPerUnit"].ToString(),
                                        Convert.ToDouble(dr["UnitPrice"]),
                                        Convert.ToInt32(dr["UnitsInStock"]),
                                        Convert.ToInt32(dr["UnitsOnOrder"]),
                                        Convert.ToInt32(dr["ReorderLevel"]),
                                        dr["Discontinued"].ToString()));
            }
            return list;
        }
    }
}
